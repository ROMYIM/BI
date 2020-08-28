using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class PostType
    {
        [Key]
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        public bool? CanSetPackType { get; set; }
        public bool? CheckOutFlag { get; set; }
        public double? Extraweight { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAllowMultiPackage { get; set; }
        public bool? IsCheckBgd { get; set; }
        public bool? IsLogisticsTrack { get; set; }
        public bool? IsPrintContactaddress { get; set; }
        public bool? IsReceivebyTrackNum { get; set; }
        public bool? IsReceiveByWeigh { get; set; }
        public bool? IsRequestDetailAddress { get; set; }
        public bool? IsTrace { get; set; }
        public int? LimitCount { get; set; }
        public double? LimitWeight { get; set; }
        [Column(TypeName = "timestamp(6) without time zone")]
        public DateTime? OperateDate { get; set; }
        public bool? PostbackTraceidOrderidFlag { get; set; }
        [StringLength(255)]
        public string PosttypeName { get; set; }
        public int? PrescriptionBegin { get; set; }
        public int? PrescriptionEnd { get; set; }
        [StringLength(255)]
        public string RegexText { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public bool? TraceIdPostbackFlag { get; set; }
        public int? UserId { get; set; }
        public bool? FeesEnabled { get; set; }
        public double? VolConvertWeight { get; set; }
        public bool? CheckTransferNumByOut { get; set; }
        [StringLength(255)]
        public string WorldExpressTypes { get; set; }
        public string PlatformCode { get; set; }
        [Column("OId", TypeName = "character varying")]
        public string Oid { get; set; }
        public bool? IsHideTraceId { get; set; }
        public double? PkgMaxWeight { get; set; }
        public int? MultiGetWeightType { get; set; }
        public string Companys { get; set; }
        public int? PosttypeFeesType { get; set; }
        public int? ChannelType { get; set; }
        public int? ChannelClerk { get; set; }
        [StringLength(255)]
        public string FreightTypes { get; set; }
        [Column(TypeName = "character varying")]
        public string OrId { get; set; }
        public bool? IsCalcVolume { get; set; }
    }
}
