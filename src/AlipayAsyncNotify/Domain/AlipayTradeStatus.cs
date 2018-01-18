using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlipayNotify.Domain
{
    /// <summary>
    /// 订单支付状态
    /// </summary>
    public enum AlipayTradeStatus
    {
        /// <summary>
        /// 交易创建，等待买家付款
        /// </summary>
        WAIT_BUYER_PAY = 0,
        /// <summary>
        /// 商户签约的产品支持退款功能的前提下，买家付款成功
        /// </summary>
        TRADE_SUCCESS = 1,
        /// <summary>
        /// 交易结束，不可退款
        /// </summary>
        TRADE_FINISHED = 2,
        /// <summary>
        /// 未付款交易超时关闭，或支付完成后全额退款
        /// </summary>
        TRADE_CLOSED = 3,
    }
}