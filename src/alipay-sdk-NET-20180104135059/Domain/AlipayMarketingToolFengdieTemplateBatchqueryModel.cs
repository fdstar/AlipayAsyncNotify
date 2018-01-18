using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolFengdieTemplateBatchqueryModel : AopObject
    {
        /// <summary>
        /// 作为当前操作者的空间成员用户名， 值为 origin_user_id
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 当前页数，默认为1
        /// </summary>
        [XmlElement("page_number")]
        public string PageNumber { get; set; }

        /// <summary>
        /// 每页记录数，不能超过50，默认为10
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 欲查询的空间 ID
        /// </summary>
        [XmlElement("space_id")]
        public string SpaceId { get; set; }
    }
}
