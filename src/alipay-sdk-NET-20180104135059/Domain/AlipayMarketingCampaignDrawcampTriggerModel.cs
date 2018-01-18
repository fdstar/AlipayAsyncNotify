using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDrawcampTriggerModel : AopObject
    {
        /// <summary>
        /// 用户参与活动的手机号（如果是用户直接输入手机号的活动形式，该项必填，作为识别用户的依据）
        /// </summary>
        [XmlElement("bind_mobile")]
        public string BindMobile { get; set; }

        /// <summary>
        /// 活动id，获取方式：调用方通过活动创建接口alipay.marketing.campaign.drawcamp.create 生成；联系支付宝运营同学获取（适用于支付宝平台活动，由合作伙伴调用触发）
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 请求来源，目前支持：1微信 2 微博 3虾米 4淘宝  5天猫
        /// </summary>
        [XmlElement("camp_source")]
        public long CampSource { get; set; }

        /// <summary>
        /// 渠道来源参数，记录调用方level 1~n级渠道来源信息，用于业务数据统计和分析
        /// </summary>
        [XmlElement("channel_info")]
        public string ChannelInfo { get; set; }

        /// <summary>
        /// 客户端ip
        /// </summary>
        [XmlElement("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// rds嵌入页面的js收集的用户行为数据
        /// </summary>
        [XmlElement("json_ua")]
        public string JsonUa { get; set; }

        /// <summary>
        /// 用户登录账号名：邮箱或手机号。已知支付宝账号的活动触发调用中，user_id与login_id至少有一个非空，都非空时，以user_id为准。
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 支付宝用户uid：支付宝用户唯一标识。该参数用于已知支付宝账号的活动触发。user_id、login_id、bind_mobile三个参数至少有一个非空。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
