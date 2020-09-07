using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    [System.ComponentModel.DataAnnotations.Schema.Table("OrderParent")]
    public class OrderParent : OrderParentBase
    {
        /// <summary>
        /// 订单异常状态
        /// </summary>
        public int ExceptionState { get; set; }

        /// <summary>
        /// 订单是否重发交寄
        /// </summary>
        public bool IsResended { get; set; }

        /// <summary>
        /// 中转单号（与第三方平台对应的编号，类似订单编号）
        /// </summary>
        public string TransitNo { get; set; }

        /// <summary>
        /// 是否获取到跟踪号
        /// </summary>
        public bool HasTraceId { get; set; }

        /// <summary>
        /// 海外状态
        /// </summary>
        public int AbroadState { get; set; }

        /// <summary>
        /// 偏远类型
        /// </summary>
        public int RemoteType { get; set; }

        /// <summary>
        /// 配送包装类型
        /// </summary>
        public int ChannelPackType { get; set; }

        /// <summary>
        /// 提交已确认时间（记录最新提交时间）
        /// </summary>
        public DateTime ConfirmedTime { get; set; }

        /// <summary>
        /// 是否线上支付（销售平台上面是否已经结算过了，作为是否返点判断）
        /// </summary>
        public bool IsOnlinePaid { get; set; }

        /// <summary>
        /// 是否单独报关
        /// </summary>
        public bool IsSeparateDeclaration { get; set; }
    }
}
