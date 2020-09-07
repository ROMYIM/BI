using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    public class PgVersionDto : PgDtoBase
    {
        /// <summary>
        /// 数据版本
        /// </summary>
        public int DataVersion { get; set; }
    }
}
