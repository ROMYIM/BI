using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Schedule.Options
{
    public class DataSynchronizationOptions
    {
        public TableMapping[] TableMappings { get; set; }
    }

    public class TableMapping
    {
        public string Mongo { get; set; }

        public string PgSql { get; set; }
    }
}
