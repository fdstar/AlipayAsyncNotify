using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignIntelligentPromoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 操作员上下文信息
        /// </summary>
        [XmlElement("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 外部业务id，请保持足够的复杂，方便定位数据来源
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 活动拥有者信息
        /// </summary>
        [XmlElement("owner_info")]
        public PromoOperatorInfo OwnerInfo { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [XmlElement("page_info")]
        public PromoPageInfo PageInfo { get; set; }
    }
}
