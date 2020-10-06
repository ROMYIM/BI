using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    /// <summary>
    /// 资源数据
    /// </summary>
    public class ResourceData
    {
        /// <summary>
        /// 资编号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 资源描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 资源权限
        /// </summary>
        public List<int> Permission { get; set; }

        /// <summary>
        /// 关联的用户表Id
        /// </summary>
        public int UserId { get; set; }
    }
}
