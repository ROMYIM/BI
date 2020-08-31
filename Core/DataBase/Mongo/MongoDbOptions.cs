using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataBase.Mongo
{
    public class MongoDbOptions
    {
        public string ConnectionString { get; set; }

        public string Database { get; set; }

        public bool Master { get; set; }
    }
}
