using AlipayNotify;
using AlipayNotify.Domain;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AlipayAsyncNotifyWeb.Utils
{
    public class NotifyHelper
    {
        public static string AppId = "你的AppId";
        public static string AlipayPublicKey = "你的支付宝公钥";
        public static string MapiUrl = "https://mapi.alipay.com/gateway.do";
        /// <summary>
        /// 简单的调用示例
        /// </summary>
        /// <param name="collection">支付宝传过来的数据集合</param>
        /// <param name="func">如果验证通过，则如何对数据进行业务处理，数据无误且处理完成后返回true，其它情况返回false</param>
        /// <returns></returns>
        public static async Task<bool> NotifyAndVerify(NameValueCollection collection, Func<AlipayTradePayAsyncNotify, Task<bool>> func = null)
        {
            var notifyResult = await AlipayAsyncNotifyHelper.VerifyAndGetNotify<AlipayTradePayAsyncNotify>(collection, AlipayPublicKey, false, true, MapiUrl);
            var right = notifyResult != null && notifyResult.AppId == AppId;
            return right && (func == null || await func(notifyResult));
        }
    }
}