using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyInfo : AopObject
    {
        /// <summary>
        /// 企业历史变更信息
        /// </summary>
        [XmlArray("alter_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> AlterList { get; set; }

        /// <summary>
        /// 企业工商照面信息
        /// </summary>
        [XmlElement("basic_info")]
        public EpInfo BasicInfo { get; set; }

        /// <summary>
        /// 企业行政处罚信息
        /// </summary>
        [XmlArray("case_info_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> CaseInfoList { get; set; }

        /// <summary>
        /// 企业对外投资信息
        /// </summary>
        [XmlArray("entinv_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> EntinvList { get; set; }

        /// <summary>
        /// 企业法定代表人在其他公司任职信息
        /// </summary>
        [XmlArray("fr_position_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> FrPositionList { get; set; }

        /// <summary>
        /// 企业法定代表人对外投资信息
        /// </summary>
        [XmlArray("frinv_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> FrinvList { get; set; }

        /// <summary>
        /// 企业主要管理人员信息
        /// </summary>
        [XmlArray("person_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> PersonList { get; set; }

        /// <summary>
        /// 企业股东及出资信息
        /// </summary>
        [XmlArray("share_holder_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> ShareHolderList { get; set; }
    }
}
