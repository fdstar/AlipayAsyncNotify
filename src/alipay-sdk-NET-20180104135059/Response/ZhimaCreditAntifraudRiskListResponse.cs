using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditAntifraudRiskListResponse.
    /// </summary>
    public class ZhimaCreditAntifraudRiskListResponse : AopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 决策结果，可空，取值当前为REJECT\REVIEW\PASS，产品定制使用。根据产品定制配置，对结果进行决策返回
        /// </summary>
        [XmlElement("decision_result")]
        public string DecisionResult { get; set; }

        /// <summary>
        /// 是否命中风险编码，yes标识命中，no标识未命中
        /// </summary>
        [XmlElement("hit_risk")]
        public string HitRisk { get; set; }

        /// <summary>
        /// 命中风险项的RiskCode列表，对应的描述见产品文档
        /// </summary>
        [XmlArray("risk_code")]
        [XmlArrayItem("string")]
        public List<string> RiskCode { get; set; }

        /// <summary>
        /// 方案ID，可空，产品定制使用。在线可能会存在多个方案并行，方案ID标识当前请求使用的在线方案
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }
    }
}
