using Infrastructure.Caches;
using Infrastructure.Db.Contexts;
using Infrastructure.Exceptions;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
            IReadOnlyCollection<T> toInsertData)
        {
            if (!(toInsertData?.Any() ?? false)) return;

            var isSelfControll = false;
            var conn = dbContext.Database.GetDbConnection() as NpgsqlConnection;

            if (conn.State != System.Data.ConnectionState.Open)
            {
                isSelfControll = true;
                conn.Open();
            }

            var idRecords = new string[toInsertData.Count];
            var i = 0;

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
                        if (field.IsKey)
                            idRecords[i++] = fieldValue.ToString();
                        writer.Write(fieldValue);
                    }
                    //await writer.WriteAsync(field.Field.GetValue(data));

                }
                writer.Complete();
                //await tran.CommitAsync();
            }
            catch (Exception ex)
            {
                throw new DataSynchronizationException(idRecords, SqlFormatter<T>.Table, ex);
            }
            finally
            {
                if (isSelfControll)
                    conn.Close();
            }

        }

        public static void BatchInsert(this FlytBIDbContext dbContext,
           ICollection toInsertData, PgDtoTypeCache typeCache)
        {
            if (toInsertData == null) return;

            var conn = dbContext.Database.GetDbConnection() as NpgsqlConnection;
            var isSelfControll = false;
            if (conn.State != System.Data.ConnectionState.Open)
            {
                isSelfControll = true;
                conn.Open();
            }

            var idRecords = new string[toInsertData.Count];
            var i = 0;

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
                        if (field.IsKey) idRecords[i++] = fieldValue.ToString();
                        writer.Write(fieldValue);
                    }
                    //await writer.WriteAsync(field.Field.GetValue(data));

                }
                writer.Complete();
                //await tran.CommitAsync();
            }
            catch (Exception ex)
            {
                throw new DataSynchronizationException(idRecords, typeCache.Table, ex);
            }
            finally
            {
                if (isSelfControll) conn.Close();
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
            return command;
        }

       

    }
}
