using AlipayAsyncNotifyWeb.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AlipayAsyncNotifyWeb.Controllers
{
    public class AlipayMvcNotifyController : Controller
    {
        public async Task<ActionResult> Notify(FormCollection collection)
        {
            var right = await NotifyHelper.NotifyAndVerify(collection);
            return Content(right ? "success" : "fail");
        }
    }
}
