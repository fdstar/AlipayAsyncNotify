using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SsdataFindataQxLinkQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataFindataQxLinkQueryModel : AopObject
    {
        /// <summary>
        /// 预留扩展
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// C端用户身份证号码
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 商户业务流水号，有商户的系统生成的商户业务唯一标识，如果不传，则有上数系统生成一个32位的商户业务流水号并返回
        /// </summary>
        [XmlElement("org_biz_no")]
        public string OrgBizNo { get; set; }

        /// <summary>
        /// C端用户手机号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 用户在操作上数的H5过程中，如果需要跳转到商户的自定义H5，则传递需要跳转的链接地址
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// C端用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
