using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiServindustryPortfolioDataCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryPortfolioDataCreateModel : AopObject
    {
        /// <summary>
        /// ISV插件ID
        /// </summary>
        [XmlElement("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 头图素材id
        /// </summary>
        [XmlElement("cover_media_id")]
        public string CoverMediaId { get; set; }

        /// <summary>
        /// 头图素材type;  枚举（PICTURE/VIDEO）
        /// </summary>
        [XmlElement("cover_media_type")]
        public string CoverMediaType { get; set; }

        /// <summary>
        /// 外部作品集ID
        /// </summary>
        [XmlElement("external_portfolio_id")]
        public string ExternalPortfolioId { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [XmlElement("portfolio_operator_info")]
        public PortfolioOperatorInfo PortfolioOperatorInfo { get; set; }

        /// <summary>
        /// 作品集与门店的关系、作品集在门店的展示权重
        /// </summary>
        [XmlArray("portfolio_shops")]
        [XmlArrayItem("portfolio_shop")]
        public List<PortfolioShop> PortfolioShops { get; set; }

        /// <summary>
        /// 作品集标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
