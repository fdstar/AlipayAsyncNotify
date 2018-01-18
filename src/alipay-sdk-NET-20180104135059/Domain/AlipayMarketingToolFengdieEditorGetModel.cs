using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieEditorGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolFengdieEditorGetModel : AopObject
    {
        /// <summary>
        /// 欲唤起的站点 ID
        /// </summary>
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 作为当前操作者的空间成员用户名， 值为 origin_user_id（即创建空间成员接口的入参），应确保 operator 是参数 space_id 对应的空间成员
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 在云凤蝶编辑器中点击“发布”按钮后，如果发布成功则跳转到该地址
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 欲唤起的站点所归属的空间 ID
        /// </summary>
        [XmlElement("space_id")]
        public string SpaceId { get; set; }
    }
}
