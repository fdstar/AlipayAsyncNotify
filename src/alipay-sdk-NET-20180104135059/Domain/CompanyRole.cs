using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyRole Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyRole : AopObject
    {
        /// <summary>
        /// 自然人担任企业法人的企业信息
        /// </summary>
        [XmlArray("ry_pos_fr_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> RyPosFrList { get; set; }

        /// <summary>
        /// 自然人担任股东的企业信息
        /// </summary>
        [XmlArray("ry_pos_sha_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> RyPosShaList { get; set; }

        /// <summary>
        /// 自然人担任主要管理人员的企业信息
        /// </summary>
        [XmlArray("share_holder_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> ShareHolderList { get; set; }
    }
}
