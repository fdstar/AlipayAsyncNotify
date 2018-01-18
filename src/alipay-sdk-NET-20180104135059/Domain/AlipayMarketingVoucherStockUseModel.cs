using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherStockUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherStockUseModel : AopObject
    {
        /// <summary>
        /// 券码，也就是商户在创建外部券码模板时，上传的文件中的内容
        /// </summary>
        [XmlElement("entity_no")]
        public string EntityNo { get; set; }

        /// <summary>
        /// 数字和字母，每一次核销都必须唯一，如果重复，则认为是重复的请求
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
