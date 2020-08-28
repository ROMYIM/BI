using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("wishonlineorder")]
    public partial class Wishonlineorder
    {
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("utccreatetime")]
        public DateTime? Utccreatetime { get; set; }
        [Column("utcmodifytime")]
        public DateTime? Utcmodifytime { get; set; }
        [Column("utccanceltime")]
        public DateTime? Utccanceltime { get; set; }
        [Column("dataversion")]
        public double? Dataversion { get; set; }
        [Column("sname")]
        [StringLength(255)]
        public string Sname { get; set; }
        [Column("stype")]
        public double? Stype { get; set; }
        [Column("is_test")]
        public bool? IsTest { get; set; }
        [Column("api_key")]
        [StringLength(255)]
        public string ApiKey { get; set; }
        [Column("tracking_id")]
        [StringLength(255)]
        public string TrackingId { get; set; }
        [Column("order_id")]
        [StringLength(255)]
        public string OrderId { get; set; }
        [Column("order_time")]
        public DateTime? OrderTime { get; set; }
        [Column("paid_with_wish")]
        public bool? PaidWithWish { get; set; }
        [Column("carrier_code")]
        public double? CarrierCode { get; set; }
        [Column("carry_type")]
        public double? CarryType { get; set; }
        [Column("logistics_product_account")]
        [StringLength(255)]
        public string LogisticsProductAccount { get; set; }
        [Column("otype")]
        [StringLength(255)]
        public string Otype { get; set; }
        [Column("operation_center_code")]
        [StringLength(255)]
        public string OperationCenterCode { get; set; }
        [Column("logistics_order_code")]
        [StringLength(255)]
        public string LogisticsOrderCode { get; set; }
        [Column("payment_account", TypeName = "json")]
        public string PaymentAccount { get; set; }
        [Column("sender", TypeName = "json")]
        public string Sender { get; set; }
        [Column("receiver", TypeName = "json")]
        public string Receiver { get; set; }
        [Column("pickup", TypeName = "json")]
        public string Pickup { get; set; }
        [Column("parcel", TypeName = "json")]
        public string Parcel { get; set; }
        [Column("return_info", TypeName = "json")]
        public string ReturnInfo { get; set; }
        [Column("iscreateflytorder")]
        public bool? Iscreateflytorder { get; set; }
        [Column("createflytordererrormsg")]
        [StringLength(255)]
        public string Createflytordererrormsg { get; set; }
        [Column("pickup_type")]
        public double? PickupType { get; set; }
        [Column("incoterm")]
        [StringLength(255)]
        public string Incoterm { get; set; }
        [Column("pre_carrier_name")]
        [StringLength(255)]
        public string PreCarrierName { get; set; }
        [Column("pre_carrier_code")]
        [StringLength(255)]
        public string PreCarrierCode { get; set; }
        [Column("pre_logistics_order_code")]
        [StringLength(255)]
        public string PreLogisticsOrderCode { get; set; }
        [Column("pre_operation_center_code")]
        [StringLength(255)]
        public string PreOperationCenterCode { get; set; }
        [Column("next_carrier_code")]
        [StringLength(255)]
        public string NextCarrierCode { get; set; }
        [Column("next_carrier_name")]
        [StringLength(255)]
        public string NextCarrierName { get; set; }
        [Column("next_operation_center_code")]
        [StringLength(255)]
        public string NextOperationCenterCode { get; set; }
        [Column("next_logstics_order_code")]
        [StringLength(255)]
        public string NextLogsticsOrderCode { get; set; }
        [Column("flytorderid")]
        [StringLength(255)]
        public string Flytorderid { get; set; }
    }
}
