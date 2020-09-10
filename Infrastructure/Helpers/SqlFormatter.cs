using Core.DataAnnotations.Db;
using Infrastructure.Caches;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Infrastructure.Helpers
{

    public class SqlFormatter<T>
    {

        #region 属性

        public static string Table { get; private set; }

        public static bool IsChildrenTable { get; private set; }

        public static string SelectFieldString;
        public static string NoKeyFieldString;
        public static string KeyFieldString;

        public static EntityFeildInfo[] Fields { get; private set; }
        public static EntityFeildInfo[] KeyFields { get; private set; }
        public static PropertyInfo[] NoIncFields { get; private set; }

        public static PropertyInfo AutoIncrement { get; private set; }

        #endregion

        static SqlFormatter()
        {
            InitFields();
        }

        #region 初始化字段属性

        private static void InitFields()
        {
            var type = typeof(T);
            Table = type.GetCustomAttribute<TableAttribute>()?.Name ?? type.Name;
            IsChildrenTable = type.GetCustomAttribute<ChildrenTableAttribute>() != null;
            Fields = type.GetProperties()
                .Where(f => f.CustomAttributes.All(a => a.AttributeType != typeof(NotMappedAttribute)))
                .Select(f => new EntityFeildInfo(f))
                .ToArray();
            KeyFields = Fields.Where(f => f.IsKey).ToArray();
            //AutoIncrement = Fields.SingleOrDefault(f => Attribute.IsDefined(f, typeof(DatabaseGeneratedAttribute)));
            //NoIncFields = AutoIncrement != null ? Fields.Where(f => f.Name != AutoIncrement.Name).ToArray() : Fields;
        }

        #endregion


    }

    #region 匿名类型缓存

    public static class DynamicEntity<T>
    {
        public static PropertyInfo[] Fields { get; private set; }

        public static string SqlFields { get; private set; }

        public static string InsertedSqlFields { get; private set; }

        static DynamicEntity()
        {
            Fields = typeof(T).GetProperties();
            SetSqlFields();
            SetInsertedFields();
        }

        private static void SetSqlFields()
        {
            var wroted = false;
            var builder = new StringBuilder();
            foreach (var field in Fields)
            {
                if (wroted)
                    builder.Append(",");
                builder.Append(field.Name);
                wroted = true;
            }
            SqlFields = builder.ToString();
        }

        private static void SetInsertedFields()
        {
            var wroted = false;
            var builder = new StringBuilder();
            foreach (var field in Fields)
            {
                if (wroted)
                    builder.Append(",");
                builder.Append("INSERTED.");
                builder.Append(field.Name);
                wroted = true;
            }
            InsertedSqlFields = builder.ToString();
        }
    }

    #endregion
}
