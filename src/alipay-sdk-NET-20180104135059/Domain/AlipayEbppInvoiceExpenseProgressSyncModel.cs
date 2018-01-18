using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenseProgressSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpenseProgressSyncModel : AopObject
    {
        /// <summary>
        /// 同步申请id，每次发起同步时生成，isv每次请求需要保证唯一
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 报销状态变更执行时间
        /// </summary>
        [XmlElement("business_time")]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 报销详情地址，提供用户通过发票管家查看报销进度的地址  如果报销企业入驻发票管家时需要isv传入报销详情地址，则必须提供
        /// </summary>
        [XmlElement("expense_detail_url")]
        public string ExpenseDetailUrl { get; set; }

        /// <summary>
        /// 报销单据号
        /// </summary>
        [XmlElement("expense_order_no")]
        public string ExpenseOrderNo { get; set; }

        /// <summary>
        /// 报销企业税号
        /// </summary>
        [XmlElement("expense_tax_no")]
        public string ExpenseTaxNo { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 报销操作  传值固定：  EXPENSE_APPLY－用户已提交申请  EXPENSE_APPROVAL_PASS －报销审核通过  EXPENSE_FINISHED－报销完结  EXPENSE_CANCEL－报销撤回
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
