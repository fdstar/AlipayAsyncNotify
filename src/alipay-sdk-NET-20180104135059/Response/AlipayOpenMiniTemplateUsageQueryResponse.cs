using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniTemplateUsageQueryResponse.
    /// </summary>
    public class AlipayOpenMiniTemplateUsageQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序appId列表
        /// </summary>
        [XmlArray("app_ids")]
        [XmlArrayItem("string")]
        public List<string> AppIds { get; set; }
    }
}
