using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAnnotations.Db
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ForeginKeyColumnAttribute : Attribute
    {
    }
}
