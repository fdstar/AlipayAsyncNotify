using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCertdocSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertdocSyncModel : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// IDENTITY_CARD:身份证;  DRIVING_LICENSE:驾驶证;  VEHICLE_LICENSE:行驶证;  SOCIAL_SECURITY_CARD:社会保障卡;  PASSPORT:护照;  DEGREE_CERTIFICATE:学位证;  HK_MACAU_LAISSEZ_PASSER:港澳通行证;  PROPRETY_OWNERSHIP_CERTIFICATE:房产证;  REAL_ESTATE_WARRANTS:不动产证;
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 证件其余信息,以json string形式传入。具体每一个k/v规则参照具体证件规则。举例驾驶证extInfo规则：  字段名字(key):drivingLicenseNo,字段含义:证号,字段类型:STRING,是否可空:否;  字段名字(key):sex,字段含义:性别,字段类型:STRING,是否可空:是,值非空时约束:选择,具体约束:男,女,;  字段名字(key):nationality,字段含义:国籍,字段类型:STRING,是否可空:是;  字段名字(key):address,字段含义:住址,字段类型:STRING,是否可空:是;  字段名字(key):dateOfBirth,字段含义:出生日期,字段类型:DATE,是否可空:是;  字段名字(key):dateOfFirstIssue,字段含义:初次领证日期,字段类型:DATE,是否可空:是;  字段名字(key):clazz,字段含义:准驾车型,字段类型:STRING,是否可空:是,值非空时约束:正则表达式,具体约束:^[a-z_A-Z_0-9]*$;  字段名字(key):fileNo,字段含义:档案编号,字段类型:STRING,是否可空:是,值非空时约束:正则表达式,具体约束:^[0-9]{12}$;  字段名字(key):issuingAuthority,字段含义:签发机关,字段类型:STRING,是否可空:是;  字段名字(key):valideDate,字段含义:生效日期,字段类型:DATE,是否可空:是,值非空时约束:正则表达式,具体约束:^\d{4}-\d{2}-\d{2}$;  字段名字(key):expireDate,字段含义:失效日期,字段类型:DATE,是否可空:是,值非空时约束:正则表达式,具体约束:^\d{4}-\d{2}-\d{2}$;
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 证件主体用户姓名。证件类型+证件号+证件姓名需要唯一。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 证件图片集合
        /// </summary>
        [XmlArray("pic_list")]
        [XmlArrayItem("open_cert_pic")]
        public List<OpenCertPic> PicList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
