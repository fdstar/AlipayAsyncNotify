using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerEpCertificationInitializeResponse.
    /// </summary>
    public class ZhimaCustomerEpCertificationInitializeResponse : AopResponse
    {
        /// <summary>
        /// 本次认证的唯一标识，商户需要记录，后续的操作都需要用到。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
