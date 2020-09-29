using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Enums
{
    /// <summary>
    /// 计费单位（重量/立方米）
    /// </summary>
    public enum WeightUnit
    {
        /// <summary>
        /// 公斤
        /// </summary>
        [Description("公斤")]
        Kg = 0,

        /// <summary>
        /// 磅
        /// </summary>
        [Description("磅")]
        Lb = 1,

        /// <summary>
        /// 盎司
        /// </summary>
        [Description("盎司")]
        Oz = 2,
        /// <summary>
        /// 立方米
        /// </summary>
        [Description("立方米")]
        CBM = 3,

    }

    /// <summary>
    /// 运单类型
    /// </summary>
    public enum OrderType
    {
        /// <summary>
        /// 普通订单
        /// </summary>
        [Description("普通订单")] Common = 0,

        /// <summary>
        /// 调拨单
        /// </summary>
        [Description("调拨单")] Allocate = 1,

        /// <summary>
        /// 调拨分箱单
        /// </summary>
        [Description("调拨分箱单")] AllocateSeparate = 2,

        /// <summary>
        /// 一票多件单(订单)
        /// </summary>
        [Description("一票多件单")] CommonExcessive = 3,

        /// <summary>
        /// 跟踪号
        /// </summary>
        [Description("订单跟踪号")] Trace = 4,

        /// <summary>
        /// 跟踪号
        /// </summary>
        [Description("调拨单跟踪号")] AllocateTrace = 5,

        /// <summary>
        /// 中转单号
        /// </summary>
        [Description("中转单号")] TransNumber = 6,

        /// <summary>
        /// 一票多件跟踪号
        /// </summary>

        [Description("一票多件单跟踪号")] CommonExcessiveTrace = 7,

        /// <summary>
        /// 调拨分箱跟踪号
        /// </summary>

        [Description("调拨分箱单跟踪号")] AllocateSeparateTrace = 8,

        /// <summary>
        /// PKG号
        /// </summary>
        [Description("PKG包裹号")] PkgNumber = 9,

        /// <summary>
        /// 批次号
        /// </summary>
        [Description("批次号")] BatchNumber = 10,

        /// <summary>
        /// 自定义单号
        /// </summary>
        [Description("自定义单号")] SelfDefined = 97,

        /// <summary>
        /// 其他单号
        /// </summary>
        [Description("其它单号")] Other = 98,

        /// <summary>
        /// 其他单号
        /// </summary>
        [Description("未确定单号")] UnDefine = 99
    }

    /// <summary>
    /// 订单状态
    /// </summary>
    public enum OrderState
    {
        /// <summary>
        /// 未识别	
        /// </summary>
        [Description("未识别")] NotIdenty = 0,

        /// <summary>
        /// 待检测
        /// </summary>
        [Description("待检查")] WaitCheck = 1,

        /// <summary>
        /// 未确认
        /// </summary>
        [Description("未确认")] NotConfirm = 2,

        /// <summary>
        /// 已确认
        /// </summary>
        [Description("已确认")] Confirmed = 3,

        /// <summary>
        /// 已交寄
        /// </summary>
        [Description("已交寄")] Posted = 4,

        /// <summary>
        /// 已收货
        /// </summary>
        [Description("已收货")] Received = 5,

        /// <summary>
        /// 已发货
        /// </summary>
        [Description("已发货")] Sent = 6,

        /// <summary>
        /// 已拣货
        /// </summary>
        [Description("已拣货")] Picked = 7,

        /// <summary>
        /// 上网
        /// </summary>
        [Description("上网")] Online = 14,

        /// <summary>
        /// 退回中
        /// </summary>
        [Description("退回中")] Returning = 8,

        /// <summary>
        /// 已退回
        /// </summary>
        [Description("已退回")] Returned = 9,

        /// <summary>
        /// 出口
        /// </summary>
        [Description("出口")] Export = 10,

        /// <summary>
        /// 妥投
        /// </summary>
        [Description("妥投")] Delivered = 11,

        /// <summary>
        /// 已删除
        /// </summary>
        [Description("已删除")] Deleted = 13,

        /// <summary>
        /// 云商统计订单数量时用到
        /// </summary>
        [Description("所有状态")] AllStatus = 15,

    }

    /// <summary>
    /// 包装类型
    /// </summary>
    public enum PackType
    {
        /// <summary>
        /// 无 仅做查询用
        /// </summary>
        [Description("无")]
        None = 0,
        /// <summary>
        /// 信封
        /// </summary>
        [Description("信封")]
        Letter = 1,
        /// <summary>
        /// 文件
        /// </summary>
        [Description("文件")]
        File = 2,
        /// <summary>
        /// 包裹
        /// </summary>
        [Description("包裹")]
        Package = 3
    }

    /// <summary>
    /// 订单拦截状态
    /// </summary>
    public enum ExceptionState
    {
        [Description("正常订单")] Normal = 0,

        /// <summary>
        /// 申请拦截
        /// </summary>
        [Description("申请拦截")] ApplyIntercept = 1,

        ///// <summary>
        ///// 允许拦截(不允许出库)
        ///// </summary>
        //[Description("允许拦截")] AgreeIntercepted = 2,

        ///// <summary>
        ///// 不许拦截
        ///// </summary>
        //[Description("不许拦截")] ForbidIntercepted = 3,

        ///// <summary>
        ///// 已拦截
        ///// </summary>
        //[Description("已拦截")] Intercepted = 4,

        /// <summary>
        /// 问题件(不允许出库)
        /// </summary>
        [Description("问题件")] Problematic = 5,

        ///// <summary>
        ///// 联系客户
        ///// </summary>
        //[Description("联系客户")] ContactCustom = 6,
    }

    /// <summary>
    /// 海外状态
    /// </summary>
    public enum AbroadState
    {
        /// <summary>
        /// 未处理	
        /// </summary>
        [Description("未处理")] Untreated = 0,
        /// <summary>
        /// 同步到海外
        /// </summary>
        [Description("同步到海外")] SynAbroadDataBase = 1,

        /// <summary>
        /// 海外仓库部分签收
        /// </summary>
        [Description("海外仓库部分签收")] AbroadPartSignIn = 2,

        /// <summary>
        /// 海外仓库签收
        /// </summary>
        [Description("海外仓库签收")] AbroadSignIn = 3,

        /// <summary>
        /// 海外本土派送
        /// </summary>
        [Description("海外本土派送")] AbroadLocalPost = 4,
    }

    /// <summary>
    /// 偏远地区枚举
    /// </summary>
    public enum RemoteAreaType
    {
        /// <summary>
        /// 未识别
        /// </summary>
        [Description("未识别")] NonIdentity = 0,
        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")] Normal = 1,
        /// <summary>
        /// 偏远
        /// </summary>
        [Description("偏远")] Remote = 2,
        /// <summary>
        /// 超偏远
        /// </summary>
        [Description("超偏远")] ExRemote = 3
    }

    public enum OperationNode
    {
        /// <summary>
        /// 下单
        /// </summary>
        CreateOrder = 1,

        /// <summary>
        /// 收货
        /// </summary>
        Receive = 2,

        /// <summary>
        /// 拣货
        /// </summary>
        Picking = 3,

        /// <summary>
        /// 中转出库
        /// </summary>
        TransitOutbound = 4,

        /// <summary>
        /// 中转签收
        /// </summary>
        TransitSign = 5,

        /// <summary>
        /// 移交渠道
        /// </summary>
        HandoverChannel = 6,

        /// <summary>
        /// 到港
        /// </summary>
        Arrival = 7,

        /// <summary>
        /// 出口报关
        /// </summary>
        ExportCustomsClearance = 8,

        /// <summary>
        /// 航班起飞
        /// </summary>
        FlightDeparture = 9,

        /// <summary>
        /// 航班落地
        /// </summary>
        FlightLanding = 10,

        /// <summary>
        /// 进口报关
        /// </summary>
        ImportCustomsClearance = 11,

        /// <summary>
        /// 移交尾程
        /// </summary>
        EndOfHandover = 12,

        /// <summary>
        /// 上网
        /// </summary>
        Internet = 13,

        /// <summary>
        /// 签收
        /// </summary>
        Sign = 14,

        /// <summary>
        /// 预上网
        /// </summary>
        PrepareInternet = 15,
    }
}
