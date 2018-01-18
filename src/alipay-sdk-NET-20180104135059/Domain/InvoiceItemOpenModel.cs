using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceItemOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceItemOpenModel : AopObject
    {
        /// <summary>
        /// 明细行不含税金额，保留两位小数
        /// </summary>
        [XmlElement("item_ex_tax_amount")]
        public string ItemExTaxAmount { get; set; }

        /// <summary>
        /// 开票项目：货物或应税劳务、服务名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 国税局制定的商品税收编码，必须是最末级
        /// </summary>
        [XmlElement("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 数量，可精确到两位小数
        /// </summary>
        [XmlElement("item_quantity")]
        public long ItemQuantity { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [XmlElement("item_spec")]
        public string ItemSpec { get; set; }

        /// <summary>
        /// 明细行价税合计，必须保证item_sum_amount=item_ex_tax_amount+item_tax_amount。
        /// </summary>
        [XmlElement("item_sum_amount")]
        public string ItemSumAmount { get; set; }

        /// <summary>
        /// 明细行税额，保留两位小数，无税或者免税情况下输入：0.00。
        /// </summary>
        [XmlElement("item_tax_amount")]
        public string ItemTaxAmount { get; set; }

        /// <summary>
        /// 明细行税率，无税或者免税情况下输入：0.00。
        /// </summary>
        [XmlElement("item_tax_rate")]
        public string ItemTaxRate { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("item_unit")]
        public string ItemUnit { get; set; }

        /// <summary>
        /// 不含税单价，可精确到8位小数
        /// </summary>
        [XmlElement("item_unit_price")]
        public string ItemUnitPrice { get; set; }

        /// <summary>
        /// 发票行性质：0表示正常行，1表示折扣行，2表示被折扣行。
        /// </summary>
        [XmlElement("row_type")]
        public string RowType { get; set; }
    }
}
