using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentShopConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignIntelligentShopConsultModel : AopObject
    {
        /// <summary>
        /// 操作上下文
        /// </summary>
        [XmlElement("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 外部业务id，请尽量保持足够的复杂，方便定位数据来源
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 当前页码，默认：“1”
        /// </summary>
        [XmlElement("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 每页项数[1, 500]， 默认500
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表支付宝分配给商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 智能营销方案的方案id（template_code替代该值，无需传递）
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 营销模板的编号，默认GENERAL_EXPERIENCE（不传值）  可选枚举：  GENERAL_EXPERIENCE：全场体验；  GENERAL_NORMAL：全场普通；  GENERAL_20171212：全场2017双12版；  CROWD_EXPERIENCE：千人千券体验；  CROWD_NORMAL：千人千券普通；  CROWD_20171212：千人千券2017双12版；
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
