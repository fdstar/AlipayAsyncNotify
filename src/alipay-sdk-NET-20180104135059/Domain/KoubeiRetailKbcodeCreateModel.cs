using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiRetailKbcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailKbcodeCreateModel : AopObject
    {
        /// <summary>
        /// 口碑码绑定的附加信息列表，最大数量150
        /// </summary>
        [XmlArray("code_info_list")]
        [XmlArrayItem("retail_kbcode_create_vo")]
        public List<RetailKbcodeCreateVo> CodeInfoList { get; set; }

        /// <summary>
        /// 物料模板（口碑码的背景图，目前仅支持：RETAIL_PASTER_296_320）
        /// </summary>
        [XmlElement("code_template")]
        public string CodeTemplate { get; set; }

        /// <summary>
        /// 生成码的类型（当前仅支持品牌商促销员码：KOUBEI_SALESMAN_CODEC）
        /// </summary>
        [XmlElement("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 请求流水ID，可用于幂等控制，建议使用UUID做幂等控制
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
