using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RetailKbcodeCreateVo Data Structure.
    /// </summary>
    [Serializable]
    public class RetailKbcodeCreateVo : AopObject
    {
        /// <summary>
        /// 指定码图片上显示的名称，建议使用商户名称
        /// </summary>
        [XmlElement("code_tip")]
        public string CodeTip { get; set; }

        /// <summary>
        /// 销售员信息（只允许数字和字母），建议使用促销员手机号
        /// </summary>
        [XmlElement("salesman")]
        public string Salesman { get; set; }
    }
}
