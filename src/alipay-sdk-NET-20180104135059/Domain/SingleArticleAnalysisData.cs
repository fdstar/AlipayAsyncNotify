using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SingleArticleAnalysisData Data Structure.
    /// </summary>
    [Serializable]
    public class SingleArticleAnalysisData : AopObject
    {
        /// <summary>
        /// 人均阅读时长
        /// </summary>
        [XmlElement("avg_read_time")]
        public long AvgReadTime { get; set; }

        /// <summary>
        /// 文章发布日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 送达人数
        /// </summary>
        [XmlElement("deliver_user_cnt")]
        public long DeliverUserCnt { get; set; }

        /// <summary>
        /// 曝光人数
        /// </summary>
        [XmlElement("expose_user_cnt")]
        public long ExposeUserCnt { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        [XmlElement("praise_user_cnt")]
        public long PraiseUserCnt { get; set; }

        /// <summary>
        /// 阅读人数
        /// </summary>
        [XmlElement("read_user_cnt")]
        public long ReadUserCnt { get; set; }

        /// <summary>
        /// 评论数
        /// </summary>
        [XmlElement("reply_user_cnt")]
        public long ReplyUserCnt { get; set; }

        /// <summary>
        /// 分享人数
        /// </summary>
        [XmlElement("share_user_cnt")]
        public long ShareUserCnt { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
