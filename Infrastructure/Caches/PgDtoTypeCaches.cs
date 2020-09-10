using Core.DataAnnotations.Db;
using Infrastructure.Helpers;
using Infrastructure.Schedule.Options;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Infrastructure.Caches
{
    public class PgDtoTypeCaches : ConcurrentDictionary<Type, PgDtoTypeCache>
    {
        private readonly IOptionsMonitor<DataSynchronizationOptions> _optionsMonitor;

        public PgDtoTypeCaches(IOptionsMonitor<DataSynchronizationOptions> optionsMonitor)
        {
            _optionsMonitor = optionsMonitor;
            OnChange(_optionsMonitor.CurrentValue);
            _optionsMonitor.OnChange(OnChange);
        }

        public void OnChange(DataSynchronizationOptions options)
        {
            if (this.Any()) this.Clear();

            var pgTables = options.TableMappings.Select(m => m.PgSql);
            foreach (var pgTable in pgTables)
            {
                var pgType = pgTable.GetDbEntityType();
                this.TryAdd(pgType, new PgDtoTypeCache(pgType));
            }
        }
    }

    public class PgDtoTypeCache
    {
        #region 属性

        public string Table { get; private set; }

        public string SelectFieldString;
        public string NoKeyFieldString;
        public string KeyFieldString;

        public EntityFeildInfo[] Fields { get; private set; }
        public EntityFeildInfo[] KeyFields { get; private set; }
        public PropertyInfo[] NoIncFields { get; private set; }

        public PropertyInfo AutoIncrement { get; private set; }

        #endregion

        public PgDtoTypeCache(Type type)
        {
            InitFields(type);
        }

        #region 初始化字段属性

        private void InitFields(Type type)
        {
            Table = type.GetCustomAttribute<TableAttribute>()?.Name ?? type.Name;
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

    public class EntityFeildInfo
    {
        private string _columnName;

        public string ColumnName
        {
            get
            {
                if (_columnName == null) _columnName = Field.GetCustomAttribute<ColumnAttribute>()?.Name ?? Field.Name;
                return _columnName;
            }
        }

        public bool IsKey { get; }

        public bool IsRelationKey { get; }

        public bool IsDatabaseGernerated { get; }

        public PropertyInfo Field { get; set; }

        public object Value { get; set; }

        public EntityFeildInfo(PropertyInfo property)
        {
            Field = property;

            IsKey = Field.GetCustomAttribute<KeyAttribute>() != null;

            IsRelationKey = Field.GetCustomAttribute<ForeginKeyColumnAttribute>() != null;

            IsDatabaseGernerated = Field.GetCustomAttribute<DatabaseGeneratedAttribute>() != null;

            if (ColumnName == "_id" || ColumnName.ToLower() == "id") IsKey = true;

        }
    }
}
