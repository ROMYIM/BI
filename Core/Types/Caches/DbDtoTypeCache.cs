using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Core.Types.Caches
{
    public class DbDtoTypeCache
    {
        #region 属性

        public string Table { get; private set; }

        public EntityPropertyInfo[] Fields { get; private set; }
        public EntityPropertyInfo[] KeyFields { get; private set; }
        public EntityPropertyInfo[] NoIncFields { get; private set; }

        public PropertyInfo AutoIncrement { get; private set; }

        #endregion

        public DbDtoTypeCache(System.Type type)
        {
            InitFields(type);
        }

        #region 初始化字段属性

        private void InitFields(System.Type type)
        {
            Table = type.GetCustomAttribute<TableAttribute>()?.Name ?? type.Name;
            Fields = type.GetProperties()
                .Where(f => f.CustomAttributes.All(a => a.AttributeType != typeof(NotMappedAttribute)))
                .Select(f => new EntityPropertyInfo(f))
                .ToArray();
            KeyFields = Fields.Where(f => f.IsKey).ToArray();
            //AutoIncrement = Fields.SingleOrDefault(f => Attribute.IsDefined(f, typeof(DatabaseGeneratedAttribute)));
            //NoIncFields = AutoIncrement != null ? Fields.Where(f => f.Name != AutoIncrement.Name).ToArray() : Fields;
        }

        #endregion
    }
}
