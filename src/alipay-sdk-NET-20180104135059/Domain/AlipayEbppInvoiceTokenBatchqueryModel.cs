using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTokenBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTokenBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询请求令牌  通过唤起支付宝钱包后用户进入发票管家选择发票列表后创建，并通过isv接收url回传给isv
        /// </summary>
        [XmlElement("invoice_token")]
        public string InvoiceToken { get; set; }

        /// <summary>
        /// 发票要素获取应用场景  固定值  INVOICE_EXPENSE
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
