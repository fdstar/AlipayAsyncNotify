using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetDeliveryDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AssetDeliveryDetail : AopObject
    {
        /// <summary>
        /// 配送数量
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 配送订单ID
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 物流单信息
        /// </summary>
        [XmlArray("logistics_infos")]
        [XmlArrayItem("logistics_info")]
        public List<LogisticsInfo> LogisticsInfos { get; set; }
    }
}
