using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsUserOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsUserOrderQueryModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 扩展参数 , json 格式。  可选还是必选取决于biz_type参数 .   对于 CABINET_FACE_TAKE 自提柜刷脸开柜业务需要传字段 cabinet_no ( 柜子编号 ) .
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 物流体系里合作商户的编码
        /// </summary>
        [XmlElement("merchant_code")]
        public string MerchantCode { get; set; }

        /// <summary>
        /// 当前支持支付宝登录号
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 目前只支持登录号,后续可扩展
        /// </summary>
        [XmlElement("target_id_type")]
        public string TargetIdType { get; set; }
    }
}
