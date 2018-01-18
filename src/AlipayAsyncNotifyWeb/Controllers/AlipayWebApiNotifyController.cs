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
        public async Task<string> Notify(FormDataCollection collection)
        {
            var right = await NotifyHelper.NotifyAndVerify(collection.ReadAsNameValueCollection());
            return right ? "success" : "fail";
        }
    }
}
