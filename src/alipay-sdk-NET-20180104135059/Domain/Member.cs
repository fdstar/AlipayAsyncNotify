using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Member Data Structure.
    /// </summary>
    [Serializable]
    public class Member : AopObject
    {
        /// <summary>
        /// 网商银行参与者会员ID
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 网商银行参与者会员角色ID
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 会员站点：ALIPAY:支付宝，MYBANK:网商银行，TAOBAO：淘宝
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点会员登录ID
        /// </summary>
        [XmlElement("site_login_id")]
        public string SiteLoginId { get; set; }

        /// <summary>
        /// 会员站点ID
        /// </summary>
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }

        /// <summary>
        /// 身份使用类型；SITE:站点类型，MYBK:网商银行客户角色类型，MYBK_SITE:站点网商类型；如果是SITE，那么site为必填字段，site_user_id和site_login_id不能全部为空；如果是MYBK，那么ip_id和ip_role_id不能全部为空；如果是MYBK_SITE，那么ip_id，ip_role_id，site为必填，site_login_id和site_user_id至少填一项
        /// </summary>
        [XmlElement("use_type")]
        public string UseType { get; set; }
    }
}
