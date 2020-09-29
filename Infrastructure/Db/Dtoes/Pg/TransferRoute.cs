using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    /// <summary>
    /// 中转路由
    /// </summary>
    [Table("TransferRoute")]
    public class TransferRoute
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 路由名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 出货口标识(渠道二[三]字码)
        /// </summary>
        public string RouteCode { get; set; }

        /// <summary>
        /// 作业机构
        /// </summary>
        public string ReceivingStationId { get; set; }

        /// <summary>
        /// 是否包含客户 （或排除）
        /// </summary>
        public bool ContainCustomer { get; set; }


        /// <summary>
        /// 地区
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }
    }
}
