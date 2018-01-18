using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishRecommendQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishRecommendQueryModel : AopObject
    {
        /// <summary>
        /// 【已废弃】用户已点的主菜品ID，传入时作为推荐菜品参考。
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 当dish_list[]不为空的时候，dish_id是必填字段。  若type=QUICK_ORDER or DESIGN_FOR_YOU；则 dish_list内容为空。  若type=ASSOCIATION_RECOMAND；则dish_List为关联推荐的主菜品；  若type=CART_RECOMAND；则dish_list为购物车的已点菜品。
        /// </summary>
        [XmlArray("dish_list")]
        [XmlArrayItem("dishes")]
        public List<Dishes> DishList { get; set; }

        /// <summary>
        /// 点餐门店所属的商家PID
        /// </summary>
        [XmlElement("merchent_pid")]
        public string MerchentPid { get; set; }

        /// <summary>
        /// 用餐人数（当type=QUICK_ORDER时，该字段必填）
        /// </summary>
        [XmlElement("people")]
        public string People { get; set; }

        /// <summary>
        /// 门店客单价（单位分）
        /// </summary>
        [XmlElement("per_price")]
        public string PerPrice { get; set; }

        /// <summary>
        /// 点餐的门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// QUICK_ORDER:一键下单  DESIGN_FOR_YOU:为你定制  ASSOCIATION_RECOMAND:关联推荐  CART_RECOMAND:购物车菜品推荐  type为空默认设置为：DESIGN_FOR_YOU（为你定制）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
