using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneHealthActivitySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneHealthActivitySyncModel : AopObject
    {
        /// <summary>
        /// 活动编号参数，比如01
        /// </summary>
        [XmlElement("activity_no")]
        public string ActivityNo { get; set; }

        /// <summary>
        /// 申请编号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 业务数据，比如邮寄信息，结果信息等
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 订单编号唯一幂等校验
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 状态参数，比如0，初始状态，1完成状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
