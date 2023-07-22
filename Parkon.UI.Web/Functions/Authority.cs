using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prkn.UI.Web.Functions
{
    public class Authority:ActionFilterAttribute
    {
        private string RoleName;
        public Authority(string role) //Burda bize gelen parametreyi içerdeki değişkenimize aktarıyoruz.
        {
            this.RoleName = role;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // filterContext.HttpContext.Session["UserId"]  //Bu şekilde session okunabiliyor
            //Burda manuel yazdığımız admin sessiondan okumalıyız yada tablodan
            if (RoleName != "Admin")
            {
                //Burda eğer ilgili alana yetkili değilse login sayfasına yönlendiriyoruz
                //Yetkili değilsiniz mesajıda verilebilir

                filterContext.HttpContext.Response.Redirect("/Security/Login");
            }
            base.OnActionExecuting(filterContext);
        }
    }
}