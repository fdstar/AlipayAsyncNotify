using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FengdieSitesListModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSitesListModel : AopObject
    {
        /// <summary>
        /// 站点发生修改的时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 站点 ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 站点是否已经上线，true 表示已经上线
        /// </summary>
        [XmlElement("is_online")]
        public bool IsOnline { get; set; }

        /// <summary>
        /// 站点下线时间
        /// </summary>
        [XmlElement("offline_time")]
        public string OfflineTime { get; set; }

        /// <summary>
        /// 创建者信息
        /// </summary>
        [XmlElement("owner")]
        public FengdieSitesOwner Owner { get; set; }

        /// <summary>
        /// 包含这些状态：OPEN: 可编辑状态；      COMPLETE: 编辑完成预览状态；      PRERELEASED: 活动预发布中，预发布并不会把活动发布到线上；      PRERELEASE_FAIL: 活动预发布失败；      RELEASING: 活动正式发布中，正式发布与预发布的区别在于正式发布成功后活动就上线了；      RELEASE_FAIL: 活动正式发布失败；      RELEASED: 活动已经发布上线；      DISCARDED: 活动已废弃，废弃的活动无法通过 URL 访问
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 站点模板名
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// 当前站点模板包采用的具体版本
        /// </summary>
        [XmlElement("template_version")]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// 站点标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
