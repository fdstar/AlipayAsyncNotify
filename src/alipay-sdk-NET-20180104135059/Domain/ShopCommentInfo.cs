using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopCommentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopCommentInfo : AopObject
    {
        /// <summary>
        /// 店铺30天平均人气值
        /// </summary>
        [XmlElement("avg_popularity")]
        public string AvgPopularity { get; set; }

        /// <summary>
        /// avg_popularity字段展示文案
        /// </summary>
        [XmlElement("avg_popularity_name")]
        public string AvgPopularityName { get; set; }

        /// <summary>
        /// 门店评分，评分越高，门店质量越高
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 门店星级，0~5,越高，店铺质量越高
        /// </summary>
        [XmlElement("star")]
        public string Star { get; set; }
    }
}
