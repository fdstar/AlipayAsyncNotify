using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOffilneProduct Data Structure.
    /// </summary>
    [Serializable]
    public class InsOffilneProduct : AopObject
    {
        /// <summary>
        /// 需要透传给机构的个性化数据，比如机构的内部产品编码，以json格式返回，key需要和蚂蚁的技术进行确认
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 产品编码，蚂蚁保险平台会为每个产品分配一个唯一的产品编码
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 产品名称，机构在蚂蚁保险后台进行配置的
        /// </summary>
        [XmlElement("prod_name")]
        public string ProdName { get; set; }
    }
}
