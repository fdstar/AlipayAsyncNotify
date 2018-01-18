using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpInfoGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpInfoGetModel : AopObject
    {
        /// <summary>
        /// 入参类型。枚举值：1-社会信用代码；2-企业名称；3-企业注册号；4-组织机构代码。
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 入参的数据值。比如data_type=2,则输入企业名称，如阿里巴巴网络技术有限公司。
        /// </summary>
        [XmlElement("data_value")]
        public string DataValue { get; set; }

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
