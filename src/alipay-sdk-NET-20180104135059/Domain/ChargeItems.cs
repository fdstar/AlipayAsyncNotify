using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChargeItems Data Structure.
    /// </summary>
    [Serializable]
    public class ChargeItems : AopObject
    {
        /// <summary>
        /// 缴费项是否必选  如果缴费项是多选模式，此参数生效。 “Y”表示必填，“N”或空表示非必填。
        /// </summary>
        [XmlElement("item_mandatory")]
        public string ItemMandatory { get; set; }

        /// <summary>
        /// 缴费项最大可选数  如果缴费项是多选模式，此参数生效，范围是1-9
        /// </summary>
        [XmlElement("item_max_num")]
        public long ItemMaxNum { get; set; }

        /// <summary>
        /// 缴费项名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 缴费项金额
        /// </summary>
        [XmlElement("item_price")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 缴费项序号，如果缴费项是多选模式，此项为必填，建议从1开始的连续数字，  用户支付成功后，通过passback_params参数带回已选择的缴费项。例如:orderNo=uoo234234&isvOrderNo=24werwe&items=1-2|2-1|3-5  1-2|2-1|3-5 表示：缴费项序列号-缴费项数|缴费项序列号-缴费项数
        /// </summary>
        [XmlElement("item_serial_number")]
        public long ItemSerialNumber { get; set; }
    }
}
