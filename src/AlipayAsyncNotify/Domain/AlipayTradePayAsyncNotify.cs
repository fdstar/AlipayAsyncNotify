using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace AlipayNotify.Domain
{
    /// <summary>
    /// 支付宝wap支付异步回调 https://docs.open.alipay.com/203/105286/
    /// app支付的异步回调 https://docs.open.alipay.com/204/105301/
    /// PC支付异步回调 https://docs.open.alipay.com/270/105902/
    /// 当面付异步回调 https://docs.open.alipay.com/194/103296/
    /// </summary>
    public class AlipayTradePayAsyncNotify
    {
        /// <summary>
        /// notify_time 通知时间 格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string NotifyTime { get; set; }
        /// <summary>
        /// notify_type 通知类型
        /// </summary>
        public string NotifyType { get; set; }
        /// <summary>
        /// notify_id 通知校验ID
        /// </summary>
        public string NotifyId { get; set; }
        /// <summary>
        /// app_id 支付宝分配给开发者的应用Id
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// charset 编码格式，如utf-8、gbk、gb2312等
        /// </summary>
        public string Charset { get; set; }
        /// <summary>
        /// version 调用的接口版本，固定为：1.0
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// sign_type 签名类型,商户生成签名字符串所使用的签名算法类型，目前支持RSA2和RSA，推荐使用RSA2
        /// </summary>
        public AlipaySignType SignType { get; set; }
        /// <summary>
        /// sign 签名
        /// </summary>
        public string Sign { get; set; }
        /// <summary>
        /// auth_app_id 授权方的appid，不支持授权时auth_app_id=app_id
        /// </summary>
        public string AuthAppId { get; set; }
        /// <summary>
        /// trade_no 支付宝交易凭证号
        /// </summary>
        public string TradeNo { get; set; }
        /// <summary>
        /// out_trade_no 原支付请求的商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }
        /// <summary>
        /// out_biz_no 商户业务ID，主要是退款通知中返回退款申请的流水号
        /// </summary>
        public string OutBizNo { get; set; }
        /// <summary>
        /// buyer_id 买家支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字
        /// </summary>
        public string BuyerId { get; set; }
        /// <summary>
        /// buyer_logon_id 买家支付宝账号
        /// </summary>
        public string BuyerLogonId { get; set; }
        /// <summary>
        /// seller_id 卖家支付宝用户号
        /// </summary>
        public string SellerId { get; set; }
        /// <summary>
        /// seller_email 卖家支付宝账号
        /// </summary>
        public string SellerEmail { get; set; }
        /// <summary>
        /// trade_status 交易目前所处的状态
        /// </summary>
        public AlipayTradeStatus? TradeStatus { get; set; }
        /// <summary>
        /// total_amount 本次交易支付的订单金额，单位为人民币（元）
        /// </summary>
        public decimal? TotalAmount { get; set; }
        /// <summary>
        /// receipt_amount 商家在交易中实际收到的款项，单位为元
        /// </summary>
        public decimal? ReceiptAmount { get; set; }
        /// <summary>
        /// invoice_amount 用户在交易中支付的可开发票的金额
        /// </summary>
        public decimal? InvoiceAmount { get; set; }
        /// <summary>
        /// buyer_pay_amount 用户在交易中支付的金额
        /// </summary>
        public decimal? BuyerPayAmount { get; set; }
        /// <summary>
        /// point_amount 使用集分宝支付的金额
        /// </summary>
        public decimal? PointAmount { get; set; }
        /// <summary>
        /// refund_fee 退款通知中，返回总退款金额，单位为元，支持两位小数
        /// </summary>
        public decimal? RefundFee { get; set; }
        /// <summary>
        /// subject 商品的标题/交易标题/订单标题/订单关键字等，是请求时对应的参数，原样通知回来
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// body 该订单的备注、描述、明细等。对应请求时的body参数，原样通知回来
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// gmt_create 该笔交易创建的时间。格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string GmtCreate { get; set; }
        /// <summary>
        /// gmt_payment 该笔交易的买家付款时间。格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string GmtPayment { get; set; }
        /// <summary>
        /// gmt_refund 该笔交易的退款时间。格式为yyyy-MM-dd HH:mm:ss.S
        /// </summary>
        public string GmtRefund { get; set; }
        /// <summary>
        /// gmt_close 该笔交易结束时间。格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string GmtClose { get; set; }
        /// <summary>
        /// fund_bill_list 支付成功的各个渠道金额信息
        /// 例：[{"amount":"15.00","fundChannel":"ALIPAYACCOUNT"}]
        /// </summary>
        public string FundBillList { get; set; }
        /// <summary>
        /// passback_params 公共回传参数，如果请求时传递了该参数，则返回给商户时会在异步通知时将该参数原样返回。本参数必须进行UrlEncode之后才可以发送给支付宝
        /// </summary>
        public string PassbackParams { get; set; }
        /// <summary>
        /// voucher_detail_list 本交易支付时所使用的所有优惠券信息
        /// 例：[{"amount":"0.20","merchantContribute":"0.00","name":"一键创建券模板的券名称","otherContribute":"0.20","type":"ALIPAY_DISCOUNT_VOUCHER","memo":"学生卡8折优惠"]
        /// </summary>
        public string VoucherDetailList { get; set; }
    }
}