using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prkn.UI.Web.Controllers
{
    //[Authorize]
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Session["versiyon"] = version;
            return View();
        }

        [Route("GetUpdateInfo")]
        public JsonResult Get_Update_Info()
        {
            StreamReader sr = new StreamReader(Server.MapPath("~/Content/build/config/updateinfo.txt"));

            var getData = sr.ReadToEnd();

            return Json(getData, JsonRequestBehavior.AllowGet);
        }

    }
}