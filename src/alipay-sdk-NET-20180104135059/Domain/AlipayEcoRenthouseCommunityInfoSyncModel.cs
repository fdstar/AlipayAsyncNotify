using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseCommunityInfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseCommunityInfoSyncModel : AopObject
    {
        /// <summary>
        /// 小区地址(与经度纬度，POI三者选填其一)
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 城市国标码（与城市名称二者选填一个），参考http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/201703/t20170310_1471429.html
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 经度|纬度（经度）
        /// </summary>
        [XmlElement("community_locations")]
        public string CommunityLocations { get; set; }

        /// <summary>
        /// 小区名称
        /// </summary>
        [XmlElement("community_name")]
        public string CommunityName { get; set; }

        /// <summary>
        /// 坐标系(0:百度,1:高德)
        /// </summary>
        [XmlElement("coordsys")]
        public string Coordsys { get; set; }

        /// <summary>
        /// 行政区县国标码(与行政区县名称选填一个），参考http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/201703/t20170310_1471429.html
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 行政区县名称
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// POI编号
        /// </summary>
        [XmlElement("poi")]
        public string Poi { get; set; }
    }
}
