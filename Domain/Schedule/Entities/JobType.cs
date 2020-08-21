using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Domain.Schedule.Entities
{
    public class JobType
    {
        public string TypeName { get; set; }

        public Type Type { get; set; }

        public Type GetJobType()
        {
            if (Type == null)
            {
                var assembly = Assembly.GetExecutingAssembly();
                Type = assembly.DefinedTypes.Where(t => t.FullName == TypeName).FirstOrDefault().AsType();
            }

            return Type;
        }
    }
}
