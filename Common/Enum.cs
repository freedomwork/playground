using System;
using System.Collections.Generic;
using System.Text;

namespace VipSoft.Common
{
    #region 会员卡状态
    /// <summary>
    /// 会员卡状态
    /// </summary>
    [Serializable]
    public enum CardState
    {
        /// <summary>
        /// 正常状态
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 锁定状态
        /// </summary>
        Locked = 1,
        /// <summary>
        /// 挂失状态
        /// </summary>
        Lossed = 2
    }
    #endregion

    #region 积分变动类型

    /// <summary>
    /// 积分变动类型
    /// </summary>
    [Serializable]
    public enum PointLogType
    {
        /// <summary>
        /// 消费获得积分
        /// </summary>
        OrderPoint = 1,
        /// <summary>
        /// 兑换产品减去积分
        /// </summary>
        ExchangPoint = 2,
        /// <summary>
        /// 退货扣除积分
        /// </summary>
        CancelPoint = 3,
        /// <summary>
        /// 注册初始积分
        /// </summary>
        InitRegisterPoint = 4,
        /// <summary>
        /// 手动修改积分
        /// </summary>
        MasterChangePoint = 5,
        /// <summary>
        /// 推荐会员注册获得积分
        /// </summary>
        RefererRegPoint = 10,
        /// <summary>
        /// 推荐会员消费获得积分
        /// </summary>
        RefererOrderPoint = 11,
        /// <summary>
        /// 设置店铺积分
        /// </summary>
        ShopPoint = 20
    }

    #endregion

    #region 会员消费订单支付类型
    /// <summary>
    /// 会员消费订单支付类型
    /// </summary>
    [Serializable]
    public enum OrderPayType
    {
        /// <summary>
        /// 卡片余额支付
        /// </summary>
        CardPay = 1,
        /// <summary>
        /// 现金支付
        /// </summary>
        CashPay = 2,
        /// <summary>
        /// 银行卡支付
        /// </summary>
        CreditPay = 3,
        /// <summary>
        /// 代金券支付
        /// </summary>
        VoucherPay = 4,
        /// <summary>
        /// 余额和现金联合支付
        /// </summary>
        UnionPay = 5,
        /// <summary>
        /// 挂账（打白条）
        /// </summary>
        LendMoney = 10,
        /// <summary>
        /// 挂单（未付款，只下订单）
        /// </summary>
        EmptyBills = 11,
        /// <summary>
        /// 记次消费
        /// </summary>
        CountPay = 100
    }
    #endregion
}
