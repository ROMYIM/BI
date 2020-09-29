using Core.DataBase.Mongo.Models;
using Infrastructure.Db.Dtoes.Mongo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Transfer
{
    /// <summary>
    /// 物流转运主表(TransferParent)对应旧表(TransitLableList)
    /// </summary>
    /// <remarks>明细表:TransferDetail</remarks>
    [Table("TransferParent")]
    public class TransferParent : MongoDbVersionPo
    {
        /// <summary>
        /// 主键ID 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// PKG编号 
        /// </summary>
        public string Pkg { get; set; }

        /// <summary>
        /// 始发地ID 
        /// </summary>
        public string FromDeliverAddressId { get; set; }

        /// <summary>
        /// 目的地ID 
        /// </summary>
        public string ToDeliverAddressId { get; set; }

        /// <summary>
        /// 邮递方式ID 
        /// </summary>
        public string PostTypeId { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        public string CountryId { get; set; }

        /// <summary>
        /// PKG出库重量（原来：发起重量 ）
        /// </summary>
        public double LaunchWeight { get; set; }

        /// <summary>
        /// 签收重量 
        /// </summary>
        public double DeliveredWeight { get; set; }

        /// <summary>
        /// 转运数量 
        /// </summary>
        public int Quantities { get; set; }

        /// <summary>
        /// 转运状态 (默认0=未识别)
        /// </summary>
        public TransferStatus TransferStatus { get; set; }

        /// <summary>
        /// 渠道商ID 
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// 第三方代码 
        /// </summary>
        public string ThirdCode { get; set; }

        /// <summary>
        /// 司机ID 
        /// </summary>
        public string DriverId { get; set; }

        /// <summary>
        /// 操作人ID 
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 转运路由ID
        /// </summary>
        public string TransferRouteId { get; set; }

        /// <summary>
        /// 操作时间 
        /// </summary>
        public DateTime OperateTime { get; set; }

        /// <summary>
        /// 落地点
        /// </summary>
        public string FallPoint { get; set; }
    }
}
