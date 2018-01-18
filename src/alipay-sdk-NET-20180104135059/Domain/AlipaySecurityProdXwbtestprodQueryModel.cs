using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdXwbtestprodQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdXwbtestprodQueryModel : AopObject
    {
        /// <summary>
        /// wert
        /// </summary>
        [XmlElement("qwe_dfgfd")]
        public string QweDfgfd { get; set; }
    }
}
