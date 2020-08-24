using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Wishonlineorder
    {
        public string Id { get; set; }
        public DateTime? Utccreatetime { get; set; }
        public DateTime? Utcmodifytime { get; set; }
        public DateTime? Utccanceltime { get; set; }
        public double? Dataversion { get; set; }
        public string Sname { get; set; }
        public double? Stype { get; set; }
        public bool? IsTest { get; set; }
        public string ApiKey { get; set; }
        public string TrackingId { get; set; }
        public string OrderId { get; set; }
        public DateTime? OrderTime { get; set; }
        public bool? PaidWithWish { get; set; }
        public double? CarrierCode { get; set; }
        public double? CarryType { get; set; }
        public string LogisticsProductAccount { get; set; }
        public string Otype { get; set; }
        public string OperationCenterCode { get; set; }
        public string LogisticsOrderCode { get; set; }
        public string PaymentAccount { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Pickup { get; set; }
        public string Parcel { get; set; }
        public string ReturnInfo { get; set; }
        public bool? Iscreateflytorder { get; set; }
        public string Createflytordererrormsg { get; set; }
        public double? PickupType { get; set; }
        public string Incoterm { get; set; }
        public string PreCarrierName { get; set; }
        public string PreCarrierCode { get; set; }
        public string PreLogisticsOrderCode { get; set; }
        public string PreOperationCenterCode { get; set; }
        public string NextCarrierCode { get; set; }
        public string NextCarrierName { get; set; }
        public string NextOperationCenterCode { get; set; }
        public string NextLogsticsOrderCode { get; set; }
        public string Flytorderid { get; set; }
    }
}
