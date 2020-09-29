using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    /// <summary>
    /// 中转路由节点
    /// </summary>
    [Table("TransferRouteNode")]
    public class TransferRouteNode
    {
        /// <summary>
        /// 转运路由ID
        /// </summary>
        public string TransferRouteId { get; set; }

        /// <summary>
        /// 节点ID
        /// </summary>
        [Key]
        public string Id { get; set; }

        /// <summary>
        /// 每个节点组成一个路由的排序值，从1开始按1递增
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 该节点所在的作业机构ID/渠道商ID
        /// </summary>
        public string NodeStationId { get; set; }

        /// <summary>
        /// 批次类型
        /// </summary>
        public int BatchTransferType { get; set; }

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
