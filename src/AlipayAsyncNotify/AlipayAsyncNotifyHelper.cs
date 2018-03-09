using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace AlipayNotify
{
    /// <summary>
    /// 支付宝回调辅助类
    /// </summary>
    public class AlipayAsyncNotifyHelper
    {
        /// <summary>
        /// 对数据进行正确性校验，校验通过的话返回对应回调实体
        /// </summary>
        /// <typeparam name="T">回调实体</typeparam>
        /// <param name="collection">请求数据</param>
        /// <param name="alipayPublicKey">支付宝公钥</param>
        /// <param name="keyFromFile">是否从文件读取 true代表从文件读取</param>
        /// <param name="verifyFromAlipay">是否校验该次请求是否为支付宝发出</param>
        /// <param name="mapiUrl">校验地址</param>
        /// <param name="partnerKey">请求数据中合作伙伴号对应的键值</param>
        /// <param name="notifyIdKey">请求数据中回调id对应的键值</param>
        /// <param name="charsetKey">请求数据中charset对应的键值</param>
        /// <param name="signTypeKey">请求数据中signtype对应的键值</param>
        /// <returns></returns>
        public static async Task<T> VerifyAndGetNotify<T>(NameValueCollection collection, string alipayPublicKey, bool keyFromFile,
            bool verifyFromAlipay = true, string mapiUrl = "https://mapi.alipay.com/gateway.do", string partnerKey = "seller_id", string notifyIdKey = "notify_id", string charsetKey = "charset", string signTypeKey = "sign_type")
            where T : new()
        {
            var right = await VerifyNotify(collection, alipayPublicKey, keyFromFile, verifyFromAlipay, mapiUrl, partnerKey, notifyIdKey, charsetKey, signTypeKey);
            if (right)
            {
                return GetNotify<T>(collection);
            }
            return default(T);
        }
        /// <summary>
        /// 校验请求的数据是否签名正确
        /// </summary>
        /// <param name="collection">请求数据</param>
        /// <param name="alipayPublicKey">支付宝公钥</param>
        /// <param name="keyFromFile">是否从文件读取 true代表从文件读取</param>
        /// <param name="verifyFromAlipay">是否校验该次请求是否为支付宝发出</param>
        /// <param name="mapiUrl">校验地址</param>
        /// <param name="partnerKey">请求数据中合作伙伴号对应的键值</param>
        /// <param name="notifyIdKey">请求数据中回调id对应的键值</param>
        /// <param name="charsetKey">请求数据中charset对应的键值</param>
        /// <param name="signTypeKey">请求数据中signtype对应的键值</param>
        /// <returns></returns>
        public static async Task<bool> VerifyNotify(NameValueCollection collection, string alipayPublicKey, bool keyFromFile,
            bool verifyFromAlipay = true, string mapiUrl = "https://mapi.alipay.com/gateway.do", string partnerKey = "seller_id", string notifyIdKey = "notify_id", string charsetKey = "charset", string signTypeKey = "sign_type")
        {
            var parameters = collection.Cast<string>().ToDictionary(k => k, v => collection[v]);
            return AlipaySignatureFromAopSdk.RSACheckV1(parameters, alipayPublicKey, parameters[charsetKey], parameters[signTypeKey], keyFromFile)
                && await IsNotifiedFromAlipay(verifyFromAlipay, parameters[partnerKey], parameters[notifyIdKey], mapiUrl);
        }
        /// <summary>
        /// 验证指定的notify_id是否是支付宝发出的通知
        /// </summary>
        /// <param name="verifyFromAlipay">是否向支付宝发起校验，true 代表发起</param>
        /// <param name="partner">支付宝合作伙伴号</param>
        /// <param name="notifyId">支付宝的回调标志id</param>
        /// <param name="mapiUrl">验证网关地址，默认为 https://mapi.alipay.com/gateway.do </param>
        /// <returns></returns>
        public static async Task<bool> IsNotifiedFromAlipay(bool verifyFromAlipay, string partner, string notifyId, string mapiUrl = "https://mapi.alipay.com/gateway.do")
        {
            if (!verifyFromAlipay) return true;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format("{0}?service=notify_verify&partner={1}&notify_id={2}", mapiUrl, partner, notifyId));
            var response = await request.GetResponseAsync();
            using (var stream = response.GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    return sr.ReadToEnd().Equals("true", StringComparison.OrdinalIgnoreCase);
                }
            }
        }
        /// <summary>
        /// 根据请求数据获取对应的回调实体
        /// </summary>
        /// <typeparam name="T">回调实体</typeparam>
        /// <param name="collection">请求数据</param>
        /// <returns></returns>
        public static T GetNotify<T>(NameValueCollection collection)
            where T : new()
        {
            T entity = new T();
            var props = typeof(T).GetProperties();
            foreach (var key in collection.AllKeys)
            {
                var pName = Regex.Replace(key, @"(?:^|_)([a-zA-Z])", m => m.Groups[1].Value.ToUpper());
                var p = props.FirstOrDefault(t => t.Name == pName);
                if (p != null)
                {
                    Type pType = null;
                    if (!p.PropertyType.IsGenericType)
                    {
                        pType = p.PropertyType;
                    }
                    else if (p.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        pType = Nullable.GetUnderlyingType(p.PropertyType);
                    }
                    if (pType != null)
                    {
                        p.SetValue(entity, ConvertTo(collection[key], pType), null);
                    }
                }
            }
            return entity;
        }
        private static object ConvertTo(string value, Type type)
        {
            if (type.IsEnum)
            {
                return Enum.Parse(type, value);
            }
            else
            {
                return Convert.ChangeType(value, type);
            }
        }
        /// <summary>
        /// 获取实体对应的签名用字典
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GetSignDictionary<T>(T entity)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            var props = typeof(T).GetProperties();
            foreach (var p in props)
            {
                var pValue = p.GetValue(entity);
                if (pValue != null)
                {
                    var pKey = Regex.Replace(p.Name, @"[A-Z]", m => string.Format("{0}{1}", m.Index == 0 ? "" : "_", m.Value.ToLower()));
                    dic.Add(pKey, pValue.ToString());
                }
            }
            return dic;
        }
    }
}