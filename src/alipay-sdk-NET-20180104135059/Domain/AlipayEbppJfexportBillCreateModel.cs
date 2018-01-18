using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppJfexportBillCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppJfexportBillCreateModel : AopObject
    {
        /// <summary>
        /// 支付金额,单位为：RMB 元。
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        [XmlElement("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 业务类型英文名称 ，固定传JF，表示缴费
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 缓存的账单的key，每次查询机构账单时返回，在创建时需要透传回支付宝这边
        /// </summary>
        [XmlElement("cache_key")]
        public string CacheKey { get; set; }

        /// <summary>
        /// 出账机构英文简称
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 拓展字段，json格式的key-value串，可以放返佣标识等信息
        /// </summary>
        [XmlElement("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 外部商户的业务流水号，需要保证唯一性和幂等性；并且，需要确保同一个外部商户的业务流水号只能使用同一个开放平台账户进行创建。
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 子业务类型英文名称 ，ELECTRIC-电费，WATER-水费，GAS-燃气费
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 选中的机构账单列表中单笔账单的uniq_id，标识创建哪一笔账单
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
