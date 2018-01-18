using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpLawsuitRecordGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpLawsuitRecordGetModel : AopObject
    {
        /// <summary>
        /// 企业名称。入参中的企业组织机构代码和企业名称，至少填入一个。
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 涉诉类型。枚举值：cpws-裁判文书; zxgg-执行公告; sxgg-失信公告; ktgg-开庭公告; fygg-法院公告; ajlc-案件流程信息; bgt-曝光台
        /// </summary>
        [XmlElement("lawsuit_type")]
        public string LawsuitType { get; set; }

        /// <summary>
        /// 企业组织机构代码。入参中的企业组织机构代码和企业名称，至少填入一个。
        /// </summary>
        [XmlElement("org_no")]
        public string OrgNo { get; set; }

        /// <summary>
        /// 产品码，直接使用［示例］给出的值
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，64位长度的字母数字下划线组合。该标识作为对账的关键信息，商户要保证其唯一性，对于用户使用相同transaction_id的查询，芝麻在一天（86400秒）内返回首次查询数据，超过有效期的查询即为无效并返回异常，有效期内的重复查询不重新计费
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
