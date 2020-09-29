using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    /// <summary>
    /// 订单操作节点时间实体
    /// </summary>
    [Table("OrderOperationNodeTime")]
    public class OrderOperationNodeTime : PgVersionDto
    {
        /// <summary>
        /// 订单号（主键）
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 邮递方式
        /// </summary>
        public string PostTypeId { get; set; }
        /// <summary>
        /// 配送渠道
        /// </summary>
        public string ChannelId { get; set; }
        /// <summary>
        /// 处理中心ID
        /// </summary>
        public string ProcessingCenterId { get; set; }
        /// <summary>
        /// 处理中心名称
        /// </summary>
        public string ProcessingCenterName { get; set; }
        /// <summary>
        /// 国家
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// 客户id
        /// </summary>
        public string Uaccount { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime CreateOrderTime { get; set; }

        /// <summary>
        /// 收货时间
        /// </summary>
        public DateTime ReceiveTime { get; set; }

        /// <summary>
        /// 拣货时间
        /// </summary>
        public DateTime PickingTime { get; set; }

        /// <summary>
        /// 中转出库时间
        /// </summary>
        public DateTime TransitOutboundTime { get; set; }

        /// <summary>
        /// 中转签收时间
        /// </summary>
        public DateTime TransitSignTime { get; set; }

        /// <summary>
        /// 移交渠道时间
        /// </summary>
        public DateTime HandoverChannelTime { get; set; }

        /// <summary>
        /// 到港时间
        /// </summary>
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// 出口报关时间
        /// </summary>
        public DateTime ExportCustomsClearanceTime { get; set; }

        /// <summary>
        /// 航班起飞时间
        /// </summary>
        public DateTime FlightDepartureTime { get; set; }

        /// <summary>
        /// 航班落地时间
        /// </summary>
        public DateTime FlightLandingTime { get; set; }

        /// <summary>
        /// 进口报关时间
        /// </summary>
        public DateTime ImportCustomsClearanceTime { get; set; }

        /// <summary>
        /// 移交尾程时间
        /// </summary>
        public DateTime EndOfHandoverTime { get; set; }

        /// <summary>
        /// 上网时间
        /// </summary>
        public DateTime InternetTime { get; set; }

        /// <summary>
        /// 签收时间
        /// </summary>
        public DateTime SignTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyTime { get; set; }

        /// <summary>
        /// 修改的操作节点
        /// </summary>
        public int ModifyOperationNode { get; set; }

        /// <summary>
        /// 预上网时间
        /// </summary>
        public DateTime PrepareInternetTime { get; set; }

        /// <summary>
        /// 移交渠道PKG
        /// </summary>
        public string EndOfHandoverPkg { get; set; }

        /// <summary>
        /// 提单号
        /// </summary>
        public string LadingBillNumber { get; set; }

        /// <summary>
        /// 移交渠道批次号
        /// </summary>
        public string EndOfHandoverBatchId { get; set; }
    }
}
