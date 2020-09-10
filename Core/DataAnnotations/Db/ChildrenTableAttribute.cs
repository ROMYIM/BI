using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAnnotations.Db
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ChildrenTableAttribute : Attribute
    {
        public string ParentTable { get; set; }

        public bool PrimaryKeyAutoCreate { get; set; }

        public ChildrenTableAttribute()
        {

        }

        public ChildrenTableAttribute(string parentTable)
        {
            ParentTable = parentTable;
        }
    }
}
