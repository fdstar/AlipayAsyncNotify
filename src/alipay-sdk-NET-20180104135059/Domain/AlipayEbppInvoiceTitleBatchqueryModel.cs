using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTitleBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTitleBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询起始时间，精确到天（按开票日期查询）  start_invoice_date和end_invoice_date传值要求  1.同时为空时，返回最近半年200条数据  2.其中一个值不能为空  3.结束日期不能大于当前日期  4.开始时间和结束时间跨度不能超过6个月
        /// </summary>
        [XmlElement("end_invoice_date")]
        public string EndInvoiceDate { get; set; }

        /// <summary>
        /// 查询票种列表  可选值  PLAIN：增值税电子普通发票  SPECIAL：增值税专用发票  PLAIN_INVOICE:增值税普通发票  PAPER_INVOICE:增值税普通发票（卷式）  SALSE_INVOICE:机动车销售统一发票
        /// </summary>
        [XmlArray("invoice_kind_list")]
        [XmlArrayItem("string")]
        public List<string> InvoiceKindList { get; set; }

        /// <summary>
        /// 查询结果上限笔数；  不设置时默认200笔上限；  上限为500笔
        /// </summary>
        [XmlElement("limit_size")]
        public long LimitSize { get; set; }

        /// <summary>
        /// 为空时默认第一页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 查询起始时间，精确到天（按开票日期查询）  start_invoice_date和end_invoice_date传值要求  1.同时为空时，返回最近半年200条数据  2.其中一个值不能为空  3.结束日期不能大于当前日期  4.开始时间和结束时间跨度不能超过6个月
        /// </summary>
        [XmlElement("start_invoice_date")]
        public string StartInvoiceDate { get; set; }

        /// <summary>
        /// 抬头名称
        /// </summary>
        [XmlElement("title_name")]
        public string TitleName { get; set; }
    }
}
