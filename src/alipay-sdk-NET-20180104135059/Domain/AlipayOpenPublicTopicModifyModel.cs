using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicTopicModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicTopicModifyModel : AopObject
    {
        /// <summary>
        /// 营销位图片url, 尺寸为996*450，最大不超过5M，支持格式:.jpg、.png ，请先调用<a href="https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload"> 图片上传接口</a>获得图片url。营销位需要展示头图时，必须填写该参数。
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 营销位跳转地址，点击营销位头图跳到的链接url。营销位需要展示头图时，必须填写该参数。
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 营销位描述。营销位需要展示头图时，必须填写该参数
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 营销位名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 营销位id
        /// </summary>
        [XmlElement("topic_id")]
        public string TopicId { get; set; }

        /// <summary>
        /// 营销位内容，数量限制：大于4个，小于8个
        /// </summary>
        [XmlElement("topic_items")]
        public TopicItem TopicItems { get; set; }
    }
}
