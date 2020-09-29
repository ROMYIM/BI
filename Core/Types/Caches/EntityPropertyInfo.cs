using Core.DataAnnotations.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Text;

namespace Core.Types.Caches
{
    public class EntityPropertyInfo
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

        public EntityPropertyInfo(PropertyInfo property)
        {
            Field = property;

            IsKey = Field.GetCustomAttribute<KeyAttribute>() != null;

            IsRelationKey = Field.GetCustomAttribute<ForeginKeyColumnAttribute>() != null;

            IsDatabaseGernerated = Field.GetCustomAttribute<DatabaseGeneratedAttribute>() != null;

            if (ColumnName == "_id" || ColumnName.ToLower() == "id") IsKey = true;

        }
    }
}

