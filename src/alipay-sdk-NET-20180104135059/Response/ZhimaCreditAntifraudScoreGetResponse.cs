using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditAntifraudScoreGetResponse.
    /// </summary>
    public class ZhimaCreditAntifraudScoreGetResponse : AopResponse
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
        /// 申请欺诈评分，分数范围是[0,100]的整数,分数越高信息越真实
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }

        /// <summary>
        /// 方案ID，可空，产品定制使用。在线可能会存在多个方案并行，方案ID标识当前请求使用的在线方案
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }
    }
}
