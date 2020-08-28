using Infrastructure.Caches;
using Infrastructure.Db.Contexts;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Infrastructure.Helpers
{
    public static class DbHelper
    {
        public static Type GetDbEntityType(this string tableName)
        {
            return Type.GetType($"Infrastructure.Db.Dtoes.Pg.{tableName}", true);
        }

        public static string GetTableName(this Type type)
        {
            if (type == null) return null;

            return type.GetCustomAttribute<TableAttribute>()?.Name ?? type.Name;
        }

        public static void BatchInsert<T>(this FlytBIDbContext dbContext, 
            IEnumerable<T> toInsertData, 
            ref ICollection<(string tableName, string keyName, string errorFieldName, object errorFieldValue, string errorMessage)> errors)
        {
            if (!(toInsertData?.Any() ?? false)) return;

            var conn =
                //new NpgsqlConnection("Host=192.168.5.238;Port=5432;User ID=postgres;Password=postgres;Database=FlytBIDW");
                dbContext.Database.GetDbConnection() as NpgsqlConnection;

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            //var tran = await conn.BeginTransactionAsync();

            var errorKey = string.Empty;
            var errorField = string.Empty;
            object errorFiledValue = null;

            try
            {

                var copyCommand = BuildBulkCopyCommand(SqlFormatter<T>.Fields, SqlFormatter<T>.Table);
                using var writer = conn.BeginBinaryImport(copyCommand);
                foreach (var data in toInsertData)
                {
                    writer.StartRow();
                    foreach (var field in SqlFormatter<T>.Fields)
                    {
                        var fieldInfo = field.Field;
                        var fieldValue = fieldInfo.GetValue(data);
                        if (field.IsKey) errorKey = fieldValue.ToString();
                        writer.Write(fieldValue);
                    }
                        //await writer.WriteAsync(field.Field.GetValue(data));

                }
                writer.Complete();
                //await tran.CommitAsync();
            }
            catch (NpgsqlException ex)
            {
                errors.Add((SqlFormatter<T>.Table, errorKey, ex.Data["Where"].ToString(), string.Empty, ex.Message));
                // todo 写道数据库日志里面
            }
            catch (Exception ex)
            {
                errors.Add((SqlFormatter<T>.Table, errorKey, string.Empty, string.Empty, ex.Message));
                // todo 写道数据库日志里面
            }
            finally
            {
                conn.Close();
            }

        }

        private static string BuildBulkCopyCommand(EntityFeildInfo[] fields, string tableName)
        {
            var commandBuilder = new StringBuilder();
            commandBuilder.Append("COPY ").Append("\"").Append(tableName).Append("\" ");
            commandBuilder.Append("(");
            for (int i = 0; i < fields.Length; i++)
            {
                var fieldInfo = fields[i];
                if (i != fields.Length - 1)
                {
                    commandBuilder.Append("\"");
                    commandBuilder.Append(fieldInfo.ColumnName);
                    commandBuilder.Append("\", ");
                }
                else
                {
                    commandBuilder.Append("\"");
                    commandBuilder.Append(fieldInfo.ColumnName);
                    commandBuilder.Append("\"");
                }
            }
            commandBuilder.Append(")");
            commandBuilder.Append(" FROM STDIN (FORMAT BINARY)");

            var command = commandBuilder.ToString();
            Console.WriteLine(command);
            return command;
        }

        public static void BatchInsert(this FlytBIDbContext dbContext,
            IEnumerable toInsertData, PgDtoTypeCache typeCache,
            ref List<(string tableName, string keyName, string errorFieldName, object errorFieldValue, string errorMessage)> errors)
        {
            if (toInsertData == null) return;

            var conn = dbContext.Database.GetDbConnection() as NpgsqlConnection;

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            //var tran = await conn.BeginTransactionAsync();

            var errorKey = string.Empty;
            var errorField = string.Empty;
            object errorFiledValue = null;

            try
            {

                var copyCommand = BuildBulkCopyCommand(typeCache.Fields, typeCache.Table);
                using var writer = conn.BeginBinaryImport(copyCommand);
                foreach (var data in toInsertData)
                {
                    writer.StartRow();
                    foreach (var field in typeCache.Fields)
                    {
                        var fieldInfo = field.Field;
                        var fieldValue = fieldInfo.GetValue(data);
                        if (field.IsKey) errorKey = fieldValue.ToString();
                        writer.Write(fieldValue);
                    }
                    //await writer.WriteAsync(field.Field.GetValue(data));

                }
                writer.Complete();
                //await tran.CommitAsync();
            }
            catch (NpgsqlException ex)
            {
                errors.Add((typeCache.Table, errorKey, ex.Data["Where"].ToString(), string.Empty, ex.Message));
                // todo 写道数据库日志里面
            }
            catch (Exception ex)
            {
                errors.Add((typeCache.Table, errorKey, string.Empty, string.Empty, ex.Message));
                // todo 写道数据库日志里面
            }
            finally
            {
                conn.Close();
            }

        }

    }
}
