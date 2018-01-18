using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FengdieSitesPageModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSitesPageModel : AopObject
    {
        /// <summary>
        /// 站点页面别名
        /// </summary>
        [XmlElement("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// H5页面预览图
        /// </summary>
        [XmlElement("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// 页面访问地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
