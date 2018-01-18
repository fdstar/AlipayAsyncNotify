using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniExperienceQueryResponse.
    /// </summary>
    public class AlipayOpenMiniExperienceQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序体验版二维码地址
        /// </summary>
        [XmlElement("exp_qr_code_url")]
        public string ExpQrCodeUrl { get; set; }

        /// <summary>
        /// 体验版打包状态，success-打包成功，failed-打包失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
