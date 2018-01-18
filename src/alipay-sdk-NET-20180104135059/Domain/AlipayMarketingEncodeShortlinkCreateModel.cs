using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingEncodeShortlinkCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingEncodeShortlinkCreateModel : AopObject
    {
        /// <summary>
        /// biz_identifier通过向mobilecodec系统申请，由mobilecodec系统分配，每个调用者一般指一个商家会有一个唯一值。
        /// </summary>
        [XmlElement("biz_identifier")]
        public string BizIdentifier { get; set; }

        /// <summary>
        /// encode_url 是需要改写成短连接的长连接，需要urlEncode
        /// </summary>
        [XmlElement("encode_url")]
        public string EncodeUrl { get; set; }

        /// <summary>
        /// 单个短连接有效期，不填是配置申请时默认的值，可以小于等于配置申请时的值，但不能大于，否则会返回配置不一致错误
        /// </summary>
        [XmlElement("timeout")]
        public string Timeout { get; set; }
    }
}
