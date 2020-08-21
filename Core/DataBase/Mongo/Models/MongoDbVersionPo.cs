using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataBase.Mongo.Models
{
    public class MongoDbVersionPo : MongoDbBasePo
    {
        /// <summary>
        /// 数据版本
        /// </summary>
        public int DataVersion { get; set; }
    }
}
