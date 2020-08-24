using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Enums
{
    /// <summary>
    /// 存款平台支付方式枚举 
    /// </summary>
    public enum DepositPlatform
    {
        [Description("现金")] PayByCash = 0,
        [Description("快钱支付")] QuickBill = 1,
        [Description("支付宝")] AliPay = 2,
        [Description("Paypal")] PayPal = 3,
        [Description("微信支付")] Wechat = 4,
        [Description("银行转账")] BackTransfer = 5,
        [Description("合利宝企业网银支付")] HelibaoBankB2B = 6,
        [Description("合利宝个人网银支付")] HelibaoBankB2C = 7,
        [Description("合利宝微信支付")] HelibaoWeChat = 8,
        [Description("合利宝支付宝")] HelibaoAlipay = 9,
        [Description("连连企业网银支付")] LianLianCommericalBank = 10,
        [Description("连连个人网银支付")] LianLianPersonBank = 11,
        [Description("连连快捷支付")] LianLianQuickPay = 12,
        [Description("老系统数据迁移")] OldSystem = 99,
    }

    /// <summary>
    /// 费用类型
    /// </summary>
    public enum FeesType
    {
        /// <summary>
        /// 充值
        /// </summary>
        [Description("充值")] Recharge = 0,

        /// <summary>
        /// 临时充值
        /// </summary
        [Description("临时充值")] TmpRecharge = 1,

        /// <summary>
        /// 退回（赔偿，丢包索赔用）
        /// </summary>
        [Description("包裹索赔")] Retreat = 2,

        /// <summary>
        /// 返回（退回清单用）
        /// </summary>
        [Description("返回费用")] Remittal = 3,

        /// <summary>
        /// 申请退费(退回清单)
        /// </summary>
        [Description("退回")] ApplyReturn = 4,

        /// <summary>
        /// 兑换
        /// </summary>
        [Description("兑换")] Change = 5,

        /// <summary>
        /// 扣费
        /// </summary>
        [Description("扣费")] Deduct = 6,

        /// <summary>
        /// 实时线上返点
        /// </summary>
        [Description("实时线上返点")] OnlineReturnCost = 7,

        /// <summary>
        /// 实时线上返点退回
        /// </summary>
        [Description("实时线上返点退回")] OnlineReturnCostReturn = 8,

        /// <summary>
        /// 保费费用
        /// </summary>
        [Description("保险费用")] PolicyDeduct = 9,

        /// <summary>
        /// 保险理赔费用
        /// </summary>
        [Description("理赔费")] PolicyClaim = 10,

        /// <summary>
        /// 定时线上返点
        /// </summary>
        [Description("定时线上返点")] WishOnlineReturnCost = 11,

        /// <summary>
        /// 定时线上返点退回
        /// </summary>
        [Description("定时线上返点退回")] WishOnlineReturnCostReturn = 12,
        /// <summary>
        /// 客户余额退回
        /// </summary>
        [Description("余额退回")] LeftMoneyReturn = 13,

        /// <summary>
        /// 线上补扣
        /// </summary>
        [Description("线上补扣")] WishOnlineDeduct = 14,

        /// <summary>
        /// 线上补扣退回
        /// </summary>
        [Description("线上补扣退回")] WishOnlineDeductReturn = 15,

        /// <summary>
        /// 平台客户预扣费用补扣
        /// </summary>
        [Description("平台客户预扣费用补扣")] PlatformDeduct = 16,

        /// <summary>
        /// 平台客户预扣费用补账
        /// </summary>
        [Description("平台客户预扣费用补账")] PlatformRecharge = 17,

    }

    /// <summary>
    /// 充值类型
    /// </summary>
    public enum ReChargeType
    {
        /// <summary>
        /// 现金
        /// </summary>
        [Description("现金")] Cash = 0,

        /// <summary>
        /// 银行到账
        /// </summary>
        [Description("银行到账")] BankTransfer = 1,

        /// <summary>
        /// 快钱
        /// </summary>
        [Description("快钱支付")] KuaiQian = 2,

        /// <summary>
        /// 微信支付
        /// </summary>
        [Description("微信支付")] WebChat = 3,

        /// <summary>
        /// 支付宝
        /// </summary>
        [Description("支付宝")] AliPay = 4,

        /// <summary>
        /// PayPal
        /// </summary>
        [Description("PayPal")] PayPal = 5,

        /// <summary>
        /// 合利宝B2B网银
        /// </summary>
        [Description("合利宝企业网银")] HelibaoBankB2B = 6,

        /// <summary>
        /// 合利宝B2C网银
        /// </summary>
        [Description("合利宝个人网银")] HelibaoBankB2C = 7,

        /// <summary>
        /// 合利宝微信支付
        /// </summary>
        [Description("合利宝微信支付")] HelibaoWeChat = 8,

        /// <summary>
        /// 合利宝支付宝支付
        /// </summary>
        [Description("合利宝支付宝")] HelibaoAlipay = 9,

        /// <summary>
        /// 连连企业网银
        /// </summary>
        [Description("连连企业网银")] LianLianCommericalBank = 10,

        /// <summary>
        /// 连连个人网银
        /// </summary>
        [Description("连连个人网银")] LianLianPersonBank = 11,

        /// <summary>
        /// 连连快捷支付
        /// </summary>
        [Description("连连快捷支付")] LianLianQuickPay = 12,

        /// <summary>
        /// 其他方式
        /// </summary>
        [Description("其它方式")] Other = 99,
    }

    /// <summary>
    /// 费用收支标志
    /// </summary>
    public enum IoFlag
    {
        /// <summary>
        /// 收入
        /// </summary>
        [Description("收入")]
        Income = 0,
        /// <summary>
        /// 支出
        /// </summary>
        [Description("支出")]
        Outlay = 1
    }

    /// <summary>
    /// 结算周期状态
    /// </summary>
    public enum BalanceCycleState
    {
        /// <summary>
        /// 新增
        /// </summary>
        [Description("新增")] Add = 0,

        /// <summary>
        /// 已结算
        /// </summary>
        [Description("已结算")] Balanceed = 1,

        /// <summary>
        /// 结算未通过
        /// </summary>
        [Description("结算未通过")] BalanceNoPass = 2,

        /// <summary>
        /// 结算已通过
        /// </summary>
        [Description("结算已通过")] BalancePass = 3,

        /// <summary>
        /// 结算已通过
        /// </summary>
        [Description("删除")] Delete = 4,
    }

    /// <summary>
    /// 数据消费记录数据类型
    /// </summary>
    public enum HedgingFlagType
    {
        [Description("原数据")]
        OrginalData = 0,

        [Description("对冲数据")]
        HedgingData = 1,

        [Description("新数据")]
        NewData = 2,
    }

    public enum DeDuctType
    {
        /// <summary>
        /// 非订单扣费
        /// </summary>
        [Description("非订单扣费")]
        None = 0,
        /// <summary>
        /// 客户费用
        /// </summary>
        [Description("客户费用")]
        User = 1,
        /// <summary>
        /// 收到点费用
        /// </summary>
        [Description("收到点费用")]
        Point = 2
    }

    /// <summary>
    /// 费用处理类型
    /// </summary>
    public enum ChargebackPlatform : int
    {
        [Description("系统扣费")] RpsPlatform = 0,
        [Description("手工扣费")] OaManual = 1,
    }

    /// <summary>
    /// 费用科目
    /// </summary>
    public enum ChargeClass
    {
        /// <summary>
        /// 运费
        /// </summary>
        [Description("运费")] Yf = 0,

        /// <summary>
        /// 处理费
        /// </summary>
        [Description("处理费")] Clf = 1,

        /// <summary>
        /// 挂号费
        /// </summary>
        [Description("挂号费")] Ghf = 2,

        /// <summary>
        /// 首重费
        /// </summary>
        [Description("首重费")] Szf = 3,

        /// <summary>
        /// 续重费
        /// </summary>
        [Description("续重费")] Xzf = 4,

        /// <summary>
        /// 清关费
        /// </summary>
        [Description("清关费")] Qgf = 5,

        /// <summary>
        /// 打包服务费
        /// </summary>
        [Description("打包服务费")] Dbf = 6,

        /// <summary>
        /// 区域额外费
        /// </summary>
        [Description("区域额外费")] Ewf = 7,

        /// <summary>
        /// 空运费
        /// </summary>
        [Description("空运费")] Kyf = 8,

        /// <summary>
        /// 特殊商品费
        /// </summary>
        [Description("特殊商品费")] Tsspf = 9,

        /// <summary>
        /// 过港费
        /// </summary>
        [Description("过港费")] FlytGGf = 10,

        /// <summary>
        /// 打单服务费
        /// </summary>
        [Description("打单服务费")] PrintService = 11,

        /// <summary>
        /// 报关费
        /// </summary>
        [Description("报关费")] Bgf = 12,

        /// <summary>
        /// 签名费
        /// </summary>
        [Description("签名费")] Qmf = 13,

        /// <summary>
        /// 包装材料费
        /// </summary>
        [Description("包装材料费")] PackageFees = 14,

        /// <summary>
        /// 偏远费
        /// </summary>
        [Description("偏远费")] RemoteFees = 15,

        /// <summary>
        /// 超长超重费
        /// </summary>
        [Description("超长超重费")] OverLengthOverWeight = 16,

        /// <summary>
        /// 保险费
        /// </summary>
        [Description("保险费_特殊费项")] PremiumFees = 17,

        /// <summary>
        /// 增值税
        /// </summary>
        [Description("增值税_特殊费项")] Vat = 18,

        /// <summary>
        /// 清关手续费（有传入参数判断是否要加上）
        /// </summary>
        [Description("清关手续费_RPS选扣")] CustomsClearancePoundage = 19,

        /// <summary>
        /// 大型包裹附加费
        /// </summary>
        [Description("大型包裹附加费")] LagrePackageFees = 20,

        /// <summary>
        /// 预付关税
        /// </summary>
        [Description("预付关税")] DutyForward = 21,

        /// <summary>
        /// 税金
        /// </summary>
        [Description("税金")] Tax = 22,

        /// <summary>
        /// 少重补扣_特殊费项
        /// </summary>
        [Description("少重补扣_特殊费项")] LessWieght = 23,

        /// <summary>
        /// 超体积费
        /// </summary>
        [Description("超体积费")] OverVolumn = 24,

        /// <summary>
        /// 超周长费
        /// </summary>
        [Description("超周长费")] OverGirth = 25,

        /// <summary>
        /// 超长费
        /// </summary>
        [Description("超长费")] OverLen = 26,

        /// <summary>
        /// 超宽费
        /// </summary>
        [Description("超宽费")] OverWid = 27,

        /// <summary>
        /// 住宅费
        /// </summary>
        [Description("住宅费")] HousingFee = 28,

        /// <summary>
        /// 余额退回
        /// </summary>
        [Description("余额退回")] ReturnLeftMoney = 29,

        /// <summary>
        /// 国内中转费
        /// </summary>
        [Description("国内中转费")] DomesticTransferFee = 30,

        /// <summary>
        /// 国外中转费
        /// </summary>
        [Description("国外中转费")] ForeignTransferFee = 31,

        /// <summary>
        /// 操作费
        /// </summary>
        [Description("操作费")] OperationalCost = 32,

        /// <summary>
        /// 入仓费
        /// </summary>
        [Description("入仓费")] AdmissionFee = 33,

        /// <summary>
        /// 磁检费
        /// </summary>
        [Description("磁检费")] MagneticInspectionFee = 34,

        /// <summary>
        /// 航空单费
        /// </summary>
        [Description("航空单费")] AviationSingleFee = 35,

        /// <summary>
        /// 信息费
        /// </summary>
        [Description("信息费")] InformationFee = 36,

        /// <summary>
        /// 提货费
        /// </summary>
        [Description("提货费")] PickUpCharge = 37,

        /// <summary>
        /// 地面费
        /// </summary>
        [Description("地面费")] GroundFee = 38,

        /// <summary>
        /// 反恐信息费
        /// </summary>
        [Description("反恐信息费")] AntiTerroristInformationFee = 39,

        /// <summary>
        /// 标签费
        /// </summary>
        [Description("标签费")] LabelFee = 40,

        /// <summary>
        /// 商检费
        /// </summary>
        [Description("商检费")] CommodityInspectionFee = 41,

        /// <summary>
        /// 传输费
        /// </summary>
        [Description("传输费")] TransferFee = 42,

        /// <summary>
        /// 录入费
        /// </summary>
        [Description("录入费")] ImputFee = 43,

        /// <summary>
        /// 文件费
        /// </summary>
        [Description("文件费")] FileFee = 44,

        /// <summary>
        /// 延期费
        /// </summary>
        [Description("延期费")] PostponementFee = 45,

        /// <summary>
        /// DTI配送费
        /// </summary>
        [Description("DTI配送费")] DTIDistributionFee = 46,

        /// <summary>
        /// 打板费
        /// </summary>
        [Description("打板费")] BoardFee = 47,

        /// <summary>
        /// ULD设备收集费用
        /// </summary>
        [Description("ULD设备收集费用")] ULDEquipmentCollectionCost = 48,

        /// <summary>
        /// 终端费用
        /// </summary>
        [Description("终端费用")] TerminalCost = 49,

        /// <summary>
        /// 仿牌费
        /// </summary>
        [Description("仿牌费")] CounterfeitFee = 50,

        /// <summary>
        /// 单独报关费_OA选扣（有传入参数判断是否要加上）
        /// </summary>
        [Description("单独报关费_OA选扣")] SingleCustoms = 51,

        /// <summary>
        /// 单独报关过港费_OA选扣（有传入参数判断是否要加上）
        /// </summary>
        [Description("单独报关过港费_OA选扣")] SingleCustomsPass = 52,


        /// <summary>
        /// 疫情高峰附加费
        /// </summary>
        [Description("疫情高峰附加费")] EpidemicPeakSurcharge = 53,

        /// <summary>
        /// 其它费用
        /// </summary>
        [Description("其它费用")] OtherFees = 990,

        /// <summary>
        /// 燃油附加费(一定置于所有费项最后,以便公式计算)
        /// </summary>
        [Description("燃油附加费(比例)_特殊费项")] FuelVatScale = 999,

        /// <summary>
        /// 保险理赔费
        /// </summary>
        [Description("理赔费")] PolicyClaimFees = 1000,

        /// <summary>
        /// 派送费
        /// </summary>
        [Description("派送费")] DeliveryFees = 1001,

        /// <summary>
        /// 单证杂费
        /// </summary>
        [Description("单证杂费")] ReceiptingFees = 1002,

        /// <summary>
        /// 运营中心成本
        /// </summary>
        [Description("运营中心成本")] OperationCenterCost = 1003,

        /// <summary>
        /// 总部成本
        /// </summary>
        [Description("总部成本")] HeadquartersCost = 1004,

        /// <summary>
        /// 销售成本
        /// </summary>
        [Description("销售成本")] MarketingCost = 1005,

        /// <summary>
        /// 管理费
        /// </summary>
        [Description("管理费")] AdministrationCost = 1006,

        /// <summary>
        /// 海运费
        /// </summary>
        [Description("海运费")] SeaFreight = 1007,

        /// <summary>
        /// 平台维护费
        /// </summary>
        [Description("平台维护费")] PlatformMaintenanceFee = 1008,

        /// <summary>
        /// 渠道维护费
        /// </summary>
        [Description("渠道维护费")] ChannelMaintenanceFee = 1009,


        /// <summary>
        /// 计抛标识(仅做计抛参数)
        /// </summary>
        [Description("计抛标识-仅做计抛参数")] CountVolumnFlag = 9999,

    }

    public enum PrepareRecordOperateType
    {
        [Description("(补账")]
        Recharge = 0,

        [Description("(补扣")]
        Deduct = 1
    }

    /// <summary>
    /// 客户返点返回类别
    /// </summary>
    public enum UserReturnMoneyReturnType
    {
        [Description("WISH")] Wish = 0,
        [Description("速卖通")] Aliexpress = 1,
        [Description("VOVA")] Vova = 2,
    }
}
