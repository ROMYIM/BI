using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    /// <summary>
    /// 物流转运单称重
    /// </summary>
    [Table("TransferWeighing")]
    public class TransferWeighing : PgVersionDto
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        public string Pkg { get; set; }

        /// <summary>
        /// 操作员Id
        /// </summary>
        public int OperatorId { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// 子订单数量
        /// </summary>
        public int OrderCount { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        public string FallPoint { get; set; }

        /// <summary>
        /// 邮递方式Id
        /// </summary>
        public string PostTypeId { get; set; }

        /// <summary>
        /// PKG收货明细重量
        /// </summary>
        public double DetailWeight { get; set; }
    }
}
