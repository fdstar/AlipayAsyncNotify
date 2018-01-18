using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsCooperationProductQrcodeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsCooperationProductQrcodeApplyModel : AopObject
    {
        /// <summary>
        /// 保险代理人在保险公司的惟一ID，数据来自保险公司内部管理系统
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 代理人姓名
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 代理人手机号码
        /// </summary>
        [XmlElement("agent_phone")]
        public string AgentPhone { get; set; }

        /// <summary>
        /// 保险公司在蚂蚁保险平台的惟一ID，由蚂蚁保险平台分配。
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 产品编码，蚂蚁保险平台会为每个产品分配一个唯一的产品编码
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }
    }
}
