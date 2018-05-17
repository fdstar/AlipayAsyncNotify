using AlipayAsyncNotifyWeb.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web.Http;

namespace AlipayAsyncNotifyWeb.Controllers
{
    public class AlipayWebApiNotifyController : ApiController
    {
        [HttpPost]
        public async Task<HttpResponseMessage> Notify(FormDataCollection collection)
        {
            var right = await NotifyHelper.NotifyAndVerify(collection.ReadAsNameValueCollection());
            return new HttpResponseMessage { Content = new StringContent(right ? "success" : "fail", System.Text.Encoding.UTF8, "text/plain") };
        }
    }
}
