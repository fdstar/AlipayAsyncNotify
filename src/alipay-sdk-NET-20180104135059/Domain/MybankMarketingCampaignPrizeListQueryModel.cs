using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankMarketingCampaignPrizeListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankMarketingCampaignPrizeListQueryModel : AopObject
    {
        /// <summary>
        /// 银行参与者id，是在网商银行创建会员后生成的id，网商银行会员的唯一标识
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 银行参与者角色id，是在网商银行创建会员后生成的角色id，网商银行会员角色的唯一标识
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 分页查询时的页码，从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询时每页返回的列表大小，最大为20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// COUPON_VOUCHER 利息红包  DISCOUNT_VOUCHER 打折券
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
