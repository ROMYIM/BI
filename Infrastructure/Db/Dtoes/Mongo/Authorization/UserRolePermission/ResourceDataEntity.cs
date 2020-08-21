using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Authorization.UserRolePermission
{
    /// <summary>
    /// 资源数据
    /// </summary>
    [ProtoContract]
    public class ResourceDataEntity
    {
        /// <summary>
        /// 资编号
        /// </summary>
        [ProtoMember(1)]
        public string Id { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [ProtoMember(2)]
        public string Name { set; get; }

        /// <summary>
        /// 资源描述
        /// </summary>
        [ProtoMember(3)]
        public string Description { get; set; }

        /// <summary>
        /// 资源权限
        /// </summary>
        [ProtoMember(4)]
        public List<int> Permission { get; set; }
    }
}
