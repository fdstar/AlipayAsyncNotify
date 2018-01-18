using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetDeliveryItem Data Structure.
    /// </summary>
    [Serializable]
    public class AssetDeliveryItem : AopObject
    {
        /// <summary>
        /// 配送数量
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("apply_order_id")]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 配送订单唯一Id
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 支付宝内部的配送流水号, 可供物料商和物流商用于对账.
        /// </summary>
        [XmlElement("assign_out_order_id")]
        public string AssignOutOrderId { get; set; }

        /// <summary>
        /// 物料渠道标识
        /// </summary>
        [XmlElement("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 发送地址
        /// </summary>
        [XmlElement("from_address")]
        public AssetDeliveryAddress FromAddress { get; set; }

        /// <summary>
        /// 配送指令生成日期, 格式:yyyy-MM-dd HH：mm:ss
        /// </summary>
        [XmlElement("gmt_assign")]
        public string GmtAssign { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 物料名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 物流单信息
        /// </summary>
        [XmlElement("logistics_info")]
        public LogisticsInfo LogisticsInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 面单信息
        /// </summary>
        [XmlElement("print_data")]
        public string PrintData { get; set; }

        /// <summary>
        /// 对应供应商pid
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 对应供应商名称
        /// </summary>
        [XmlElement("supplier_name")]
        public string SupplierName { get; set; }

        /// <summary>
        /// 接收地址(目的地址)
        /// </summary>
        [XmlElement("to_address")]
        public AssetDeliveryAddress ToAddress { get; set; }
    }
}
