using Infrastructure.Db.Dtoes.Mongo.Enums;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.ChannelProduct
{
    /// <summary> 
    ///邮递方式设置
    /// </summary>
    [ProtoContract]
    [Table("PostType")]
    public class PostTypes
    {
        /// <summary> 
        /// 邮递方式编号
        /// </summary>
        [ProtoMember(1)]
        public string Id { set; get; }

        /// <summary> 
        /// 是否设置包装类型
        /// </summary>
        [ProtoMember(2)]
        public bool CanSetPackType { set; get; }

        /// <summary> 
        /// 拣货检查扣费 0 = 否 1=是
        /// </summary>
        [ProtoMember(3)]
        public bool CheckOutFlag { set; get; }

        /// <summary> 
        /// 额外重量
        /// </summary>
        [ProtoMember(4)]
        public double Extraweight { set; get; }

        /// <summary> 
        /// 是否激活 0 = 否 1= 是（云商系统临时使用）
        /// </summary>
        [ProtoMember(5)]
        public bool IsActive { set; get; }

        /// <summary> 
        /// 是否允许一票多件    0=否  1=是
        /// </summary>
        [ProtoMember(6)]
        public bool IsAllowMultiPackage { set; get; }

        /// <summary> 
        /// 是否计抛   0=否  1=是
        /// </summary>
        [ProtoMember(7)]
        public bool IsCalcVolume { set; get; }

        /// <summary> 
        /// 是否检查报关订单  0=否  1=是
        /// </summary>
        [ProtoMember(8)]
        public bool IsCheckBgd { set; get; }

        /// <summary> 
        /// 是否输入跟踪号  0=否  1=是
        /// </summary>
        [ProtoMember(9)]
        public bool IsLogisticsTrack { set; get; }

        /// <summary> 
        /// 地址标签是否打印回邮地址  0=否  1=是
        /// </summary>
        [ProtoMember(10)]
        public bool IsPrintContactaddress { set; get; }

        /// <summary> 
        /// 是否按跟踪号收货    0=否  1=是
        /// </summary>
        [ProtoMember(11)]
        public bool IsReceivebyTrackNum { set; get; }

        /// <summary> 
        /// 是否按订单号收货    0=否  1=是
        /// </summary>
        [ProtoMember(12)]
        public bool IsReceiveByOrderid { set; get; }

        /// <summary> 
        /// 是否按统一称重    0=否  1=是
        /// </summary>
        [ProtoMember(13)]
        public bool IsReceiveByWeigh { set; get; }

        /// <summary> 
        /// 是否需要拆分地址    0=否  1=是
        /// </summary>
        [ProtoMember(14)]
        public bool IsRequestDetailAddress { set; get; }

        /// <summary> 
        /// 是否可跟踪  0=否  1=是
        /// </summary>
        [ProtoMember(15)]
        public bool IsTrace { set; get; }

        /// <summary> 
        /// 限制订单个数
        /// </summary>
        [ProtoMember(16)]
        public int LimitCount { set; get; }

        /// <summary> 
        /// 发货量上线
        /// </summary>
        [ProtoMember(17)]
        public double LimitWeight { set; get; }

        /// <summary> 
        /// 操作日期
        /// </summary>
        [ProtoMember(18)]
        public DateTime OperateDate { set; get; }

        /// <summary> 
        /// 回传的跟踪号为订单号
        /// </summary>
        [ProtoMember(19)]
        public bool PostbackTraceidOrderidFlag { set; get; }

        /// <summary> 
        /// 邮递方式名称
        /// </summary>
        [ProtoMember(20)]
        public string PosttypeName { set; get; }

        /// <summary> 
        /// 时效起始天数
        /// </summary>
        [ProtoMember(21)]
        public int PrescriptionBegin { set; get; }

        /// <summary> 
        /// 时效结束天数
        /// </summary>
        [ProtoMember(22)]
        public int PrescriptionEnd { set; get; }

        /// <summary> 
        /// 跟踪号正则表达式
        /// </summary>
        [ProtoMember(23)]
        public string RegexText { set; get; }

        /// <summary> 
        /// 备注
        /// </summary>
        [ProtoMember(24)]
        public string Remark { set; get; }

        /// <summary> 
        /// 跟踪号回传
        /// </summary>
        [ProtoMember(25)]
        public bool TraceIdPostbackFlag { set; get; }

        /// <summary> 
        /// 操作人员
        /// </summary>
        [ProtoMember(26)]
        public int UserId { set; get; }

        ///<summary>
        ///计费启用标志 0 = 否 1=是
        ///</summary>
        [ProtoMember(27)]
        public bool FeesEnabled { get; set; }

        /// <summary>
        /// 体积转换重量系数
        /// </summary>
        [ProtoMember(28)]
        public double VolConvertWeight { get; set; }

        /// <summary>
        /// 包装规格
        /// </summary>
        [ProtoMember(29)]
        public string PackRule { get; set; }

        /// <summary>
        /// 特点/须知
        /// </summary>
        [ProtoMember(30)]
        public string CanSendMessage { get; set; }

        /// <summary>
        /// 出库是否校验中转单号
        /// </summary>
        [ProtoMember(31)]
        public bool CheckTransferNumByOut { get; set; }

        /// <summary>
        /// 渠道专员
        /// </summary>
        [ProtoMember(32)]
        public int? ChannelClerk { get; set; }

        /// <summary>
        ///邮递分组
        /// </summary>
        [ProtoMember(33)]
        public List<PostTypeGroup> WorldExpressTypes { get; set; }

        /// <summary>
        /// 平台编码（名称）
        /// </summary>
        [ProtoMember(34)]
        public List<string> PlatformCode { get; set; }

        /// <summary>
        /// 货物种类
        /// </summary>
        [ProtoMember(35)]
        public List<FreightType> FreightTypes { get; set; }

        /// <summary>
        /// 旧系统编号(oracle)
        /// </summary>
        [ProtoMember(36)]
        public string OId { get; set; }

        /// <summary>
        /// 云商系统编号(oracle)
        /// </summary>
        [ProtoMember(37)]
        public string OrId { get; set; }

        /// <summary>
        /// 派送（发货）国家
        /// </summary>
        [ProtoMember(38)]
        public string DispatchCiId { get; set; }

        /// <summary>
        /// 是否隐藏跟踪号
        /// </summary>
        [ProtoMember(39)]
        public bool IsHideTraceId { get; set; }

        /// <summary>
        /// 包裹(PKG)最大重量
        /// </summary>
        [ProtoMember(40)]
        public double PkgMaxWeight { get; set; }

        /// <summary>
        /// 一票多件重量取整方式
        /// </summary>
        [ProtoMember(41)]
        public MultiGetWeightType MultiGetWeightType { get; set; }

        /// <summary>
        /// 邮递方式计费类型
        /// </summary>
        [ProtoMember(42)]
        public PosttypeFeesType PosttypeFeesType { get; set; }

        /// <summary>
        /// 费用权重百分比
        /// </summary>
        [ProtoMember(43)]
        public double FeesWeightPercent { get; set; }

        /// <summary>
        /// 时效权重百分比
        /// </summary>
        [ProtoMember(44)]
        public double PraescriptioWeightPercent { get; set; }

        /// <summary>
        /// 所属公司编号
        /// </summary>
        [ProtoMember(45)]
        public List<string> Companys { get; set; }

        /// <summary>
        /// 空运提单前缀
        /// </summary>
        [ProtoMember(46)]
        public string AirTrackingPrefix { get; set; }

        /// <summary>
        /// 渠道编号
        /// </summary>
        [ProtoMember(47)]
        public string ChannelNumber { get; set; }

        /// <summary>
        /// 渠道类别
        /// </summary>
        [ProtoMember(48)]
        public ChannelType ChannelType { get; set; }

        /// <summary>
        /// 产品客服
        /// </summary>
        [ProtoMember(49)]
        public int? ProductServiceUserId { get; set; }
    }

    /// <summary> 
    ///记录已删除的邮递方式设置
    /// </summary>
    [Table("PostTypeDelete")]
    public class PostTypesDelete
    {
        /// <summary>
        /// 编号
        /// </summary>
        public Guid Id { get; set; }

        /// <summary> 
        /// 邮递方式编号
        /// </summary>
        public string TypeCode { set; get; }

        /// <summary> 
        /// 是否设置包装类型
        /// </summary>
        public bool CanSetPackType { set; get; }

        /// <summary> 
        /// 拣货检查扣费 0 = 否 1=是
        /// </summary>
        public bool CheckOutFlag { set; get; }

        /// <summary> 
        /// 额外重量
        /// </summary>
        public double Extraweight { set; get; }

        /// <summary> 
        /// 是否激活 0 = 否 1= 是（云商系统临时使用）
        /// </summary>
        public bool IsActive { set; get; }

        /// <summary> 
        /// 是否允许一票多件    0=否  1=是
        /// </summary>
        public bool IsAllowMultiPackage { set; get; }

        /// <summary> 
        /// 是否计抛   0=否  1=是
        /// </summary>
        public bool IsCalcVolume { set; get; }

        /// <summary> 
        /// 是否检查报关订单  0=否  1=是
        /// </summary>
        public bool IsCheckBgd { set; get; }

        /// <summary> 
        /// 是否输入跟踪号  0=否  1=是
        /// </summary>
        public bool IsLogisticsTrack { set; get; }

        /// <summary> 
        /// 地址标签是否打印回邮地址  0=否  1=是
        /// </summary>
        public bool IsPrintContactaddress { set; get; }

        /// <summary> 
        /// 是否按跟踪号收货    0=否  1=是
        /// </summary>
        public bool IsReceivebyTrackNum { set; get; }

        /// <summary> 
        /// 是否按订单号收货    0=否  1=是
        /// </summary>
        public bool IsReceiveByOrderid { set; get; }

        /// <summary> 
        /// 是否按统一称重    0=否  1=是
        /// </summary>
        public bool IsReceiveByWeigh { set; get; }

        /// <summary> 
        /// 是否需要拆分地址    0=否  1=是
        /// </summary>
        public bool IsRequestDetailAddress { set; get; }

        /// <summary> 
        /// 是否可跟踪  0=否  1=是
        /// </summary>
        public bool IsTrace { set; get; }

        /// <summary> 
        /// 限制订单个数
        /// </summary>
        public int LimitCount { set; get; }

        /// <summary> 
        /// 发货量上线
        /// </summary>
        public double LimitWeight { set; get; }

        /// <summary> 
        /// 操作日期
        /// </summary>
        public DateTime OperateDate { set; get; }

        /// <summary> 
        /// 回传的跟踪号为订单号
        /// </summary>
        public bool PostbackTraceidOrderidFlag { set; get; }

        /// <summary> 
        /// 邮递方式名称
        /// </summary>
        public string PosttypeName { set; get; }

        /// <summary> 
        /// 时效起始天数
        /// </summary>
        public int PrescriptionBegin { set; get; }

        /// <summary> 
        /// 时效结束天数
        /// </summary>
        [ProtoMember(23)]
        public int PrescriptionEnd { set; get; }

        /// <summary> 
        /// 跟踪号正则表达式
        /// </summary>
        public string RegexText { set; get; }

        /// <summary> 
        /// 备注
        /// </summary>
        public string Remark { set; get; }

        /// <summary> 
        /// 跟踪号回传
        /// </summary>
        public bool TraceIdPostbackFlag { set; get; }

        /// <summary> 
        /// 操作人员
        /// </summary>
        public int UserId { set; get; }

        ///<summary>
        ///计费启用标志 0 = 否 1=是
        ///</summary>
        public bool FeesEnabled { get; set; }

        /// <summary>
        /// 体积转换重量系数
        /// </summary>
        public double VolConvertWeight { get; set; }

        /// <summary>
        /// 包装规格
        /// </summary>
        public string PackRule { get; set; }

        /// <summary>
        /// 特点/须知
        /// </summary>
        public string CanSendMessage { get; set; }

        /// <summary>
        /// 出库是否校验中转单号
        /// </summary>
        public bool CheckTransferNumByOut { get; set; }

        /// <summary>
        /// 渠道专员
        /// </summary>
        public int? ChannelClerk { get; set; }

        /// <summary>
        ///邮递分组
        /// </summary>
        public List<PostTypeGroup> WorldExpressTypes { get; set; }

        /// <summary>
        /// 平台编码（名称）
        /// </summary>
        public List<string> PlatformCode { get; set; }

        /// <summary>
        /// 货物种类
        /// </summary>
        public List<FreightType> FreightTypes { get; set; }

        /// <summary>
        /// 旧系统编号(oracle)
        /// </summary>
        public string OId { get; set; }

        /// <summary>
        /// 云商系统编号(oracle)
        /// </summary>
        public string OrId { get; set; }

        /// <summary>
        /// 派送（发货）国家
        /// </summary>
        public string DispatchCiId { get; set; }

        /// <summary>
        /// 是否隐藏跟踪号
        /// </summary>
        public bool IsHideTraceId { get; set; }

        /// <summary>
        /// 包裹(PKG)最大重量
        /// </summary>
        public double PkgMaxWeight { get; set; }

        /// <summary>
        /// 一票多件重量取整方式
        /// </summary>
        public MultiGetWeightType MultiGetWeightType { get; set; }

        /// <summary>
        /// 邮递方式计费类型
        /// </summary>
        public PosttypeFeesType? PosttypeFeesType { get; set; }

        /// <summary>
        /// 费用权重百分比
        /// </summary>
        public double FeesWeightPercent { get; set; }

        /// <summary>
        /// 时效权重百分比
        /// </summary>
        public double PraescriptioWeightPercent { get; set; }

        /// <summary>
        /// 所属公司编号
        /// </summary>
        public List<string> Companys { get; set; }

        /// <summary>
        /// 空运提单前缀
        /// </summary>
        public string AirTrackingPrefix { get; set; }

        /// <summary>
        /// 渠道编号
        /// </summary>
        public string ChannelNumber { get; set; }

        /// <summary>
        /// 渠道类别
        /// </summary>
        public ChannelType ChannelType { get; set; }

        /// <summary>
        /// 产品客服
        /// </summary>
        public int? ProductServiceUserId { get; set; }
    }
}
