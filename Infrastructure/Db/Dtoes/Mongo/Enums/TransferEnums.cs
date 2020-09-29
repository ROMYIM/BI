using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Enums
{
    public enum TransferStatus
    {
        /// <summary>
        /// 已发起
        /// </summary>
        [Description("已发起")] Launched = 0,

        /// <summary>
        /// 转运中
        /// </summary>
        [Description("转运中")] Transporting = 1,

        /// <summary>
        /// 已签收
        /// </summary>
        [Description("已签收")] Delivered = 2,

        /// <summary>
        /// 已作废
        /// </summary>
        [Description("已作废")] Invalided = 3,

        /// <summary>
        /// 退件中
        /// </summary>
        [Description("退件中")] Returning = 5,

        /// <summary>
        /// 退件已签收
        /// </summary>
        [Description("退件已签收")] ReturnedDelivered = 6,

        /// <summary>
        /// 中转扫描
        /// </summary>
        [Description("中转扫描")] TransferScan = 8,

        /// <summary>
        /// 移交渠道
        /// </summary>
        [Description("移交渠道")] TransferChannel = 9
    }

    /// <summary>
    /// 批次转运类型
    /// </summary>
    public enum BatchTransferType
    {
        /// <summary>
        /// 未识别
        /// </summary>
        [Description("未识别")] None = 0,

        /// <summary>
        /// 处理中心
        /// </summary>
        [Description("处理中心")] Process = 1,

        /// <summary>
        /// 渠道商
        /// </summary>
        [Description("渠道商")] Channel = 2,

        /// <summary>
        /// 收货点
        /// </summary>
        [Description("收货点")] Delivery = 3
    }
}
