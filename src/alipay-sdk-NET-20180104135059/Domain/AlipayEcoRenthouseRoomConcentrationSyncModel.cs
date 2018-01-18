using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseRoomConcentrationSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseRoomConcentrationSyncModel : AopObject
    {
        /// <summary>
        /// 阿里短号
        /// </summary>
        [XmlElement("ali_short_num")]
        public string AliShortNum { get; set; }

        /// <summary>
        /// 户型-房  数值范围：1-26
        /// </summary>
        [XmlElement("bedroom_count")]
        public long BedroomCount { get; set; }

        /// <summary>
        /// 可入住时间 YYYY-MM-DD
        /// </summary>
        [XmlElement("checkin_time")]
        public string CheckinTime { get; set; }

        /// <summary>
        /// 小区同步请求号
        /// </summary>
        [XmlElement("comm_req_id")]
        public string CommReqId { get; set; }

        /// <summary>
        /// 小区Code和小区请求号必输入其一  小区Code，详见文档  http://ecopublic.oss-cn-hangzhou.aliyuncs.com/eco/tpmogo/CommunityInfos/CommunityInfos.xls
        /// </summary>
        [XmlElement("community_code")]
        public string CommunityCode { get; set; }

        /// <summary>
        /// 所在楼层  数值范围：1-99，不能大于房屋总楼层
        /// </summary>
        [XmlElement("floor_count")]
        public long FloorCount { get; set; }

        /// <summary>
        /// 押金   数值范围：0-￥420000.00
        /// </summary>
        [XmlElement("foregift_amount")]
        public string ForegiftAmount { get; set; }

        /// <summary>
        /// 免押金开始时间 YYYY-MM-dd
        /// </summary>
        [XmlElement("free_begin_date")]
        public string FreeBeginDate { get; set; }

        /// <summary>
        /// 免押金结束时间 YYYY-MM-dd
        /// </summary>
        [XmlElement("free_end_date")]
        public string FreeEndDate { get; set; }

        /// <summary>
        /// 通过"文件上传"接口返回的房源图片url路径。房间照片可录入0~10张,目前仅支持jpg、png、jpeg格式
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 房源描述  字符串，最大字符长度400
        /// </summary>
        [XmlElement("intro")]
        public string Intro { get; set; }

        /// <summary>
        /// 集中式最高价格，支持小数点后面2位。  新增时必输字段，修改时如果不转值则以上次接口调用值为准。
        /// </summary>
        [XmlElement("max_amount")]
        public string MaxAmount { get; set; }

        /// <summary>
        /// 集中式房源最大押金
        /// </summary>
        [XmlElement("max_deposit_amount")]
        public string MaxDepositAmount { get; set; }

        /// <summary>
        /// 公寓别名  是否必须:（新增）是/（修改）否
        /// </summary>
        [XmlElement("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// 其它费用
        /// </summary>
        [XmlArray("other_amount")]
        [XmlArrayItem("eco_renthouse_other_amount")]
        public List<EcoRenthouseOtherAmount> OtherAmount { get; set; }

        /// <summary>
        /// 管家姓名
        /// </summary>
        [XmlElement("owners_name")]
        public string OwnersName { get; set; }

        /// <summary>
        /// 管家电话  手机号码，必须为400开头
        /// </summary>
        [XmlElement("owners_tel")]
        public string OwnersTel { get; set; }

        /// <summary>
        /// 户型-厅  数值范围：0-10
        /// </summary>
        [XmlElement("parlor_count")]
        public long ParlorCount { get; set; }

        /// <summary>
        /// 付款方式（1：付一，2：付二）
        /// </summary>
        [XmlElement("pay_type")]
        public long PayType { get; set; }

        /// <summary>
        /// 出租状态   数值范围：1未租、2已租
        /// </summary>
        [XmlElement("rent_status")]
        public long RentStatus { get; set; }

        /// <summary>
        /// 出租类型 1：整租，2：合租
        /// </summary>
        [XmlElement("rent_type")]
        public long RentType { get; set; }

        /// <summary>
        /// 租金   数值范围：￥100.00 - ￥35000.00 ，支持小数点后面2位
        /// </summary>
        [XmlElement("room_amount")]
        public string RoomAmount { get; set; }

        /// <summary>
        /// 房间面积  数值范围：5.00㎡-300.00㎡，支持小数点后面2位
        /// </summary>
        [XmlElement("room_area")]
        public string RoomArea { get; set; }

        /// <summary>
        /// KA内部存储的房源编号
        /// </summary>
        [XmlElement("room_code")]
        public string RoomCode { get; set; }

        /// <summary>
        /// 物品配置(房间)  2:空调;3:热水器;4:洗衣机;5:冰箱;6:电视;7:微波炉;8:燃气灶;9:抽油烟机;10:电磁炉;11:床;11:WIFI;12:书桌;13:衣柜;14:沙发;15:阳台;
        /// </summary>
        [XmlArray("room_configs")]
        [XmlArrayItem("string")]
        public List<string> RoomConfigs { get; set; }

        /// <summary>
        /// 集中式房间列表
        /// </summary>
        [XmlArray("room_info_list")]
        [XmlArrayItem("eco_renthouse_room_info_list")]
        public List<EcoRenthouseRoomInfoList> RoomInfoList { get; set; }

        /// <summary>
        /// 房源初始上下架状态  上架状态租房平台会展示该房间信息，下架状态反之
        /// </summary>
        [XmlElement("room_status")]
        public long RoomStatus { get; set; }

        /// <summary>
        /// 户型-卫  数值范围：0-10
        /// </summary>
        [XmlElement("toilet_count")]
        public long ToiletCount { get; set; }

        /// <summary>
        /// 房屋总楼层  数值范围：1-99，不能小于所在楼层
        /// </summary>
        [XmlElement("total_floor_count")]
        public long TotalFloorCount { get; set; }
    }
}
