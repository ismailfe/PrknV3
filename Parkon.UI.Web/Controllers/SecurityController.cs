using Prkn.Bll.Master.PrknDataBll.User;
using Prkn.UI.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using Prkn.UI.Web.Functions;

namespace Prkn.UI.Web.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("Security")]
    public class SecurityController : Controller
    {

        // GET: Security
        [Route("Login")]
        [HttpGet]
        public ActionResult Login()
        {
            var parametersEdit = new Login();

            parametersEdit.LoginError = false;
            parametersEdit.HeaderTitle = "LOGİN";
            parametersEdit.FromController = "Security";
            parametersEdit.FromRoute = "Login";

            return View(parametersEdit);
        }

        [Route("Login")]
        [HttpPost]
        public ActionResult Login(Login parameters)
        {
            var getBll = new UserBll();

            var getData = getBll.ListRefresh();

            parameters.LoginError = true;
            if (getData != null)
            {
                for (int i = 0; i < getData.Count; i++)
                {
                    if (parameters.Username==getData[i].UserName)
                    {
                        if (parameters.Password==getData[i].Pass)
                        {
                            parameters.LoginError = false;
                            //Eğer sisteme giriş yapmışsa kullanıcıya izin veriyoruz. False parametresi beni hatırla seçeneği
                            //False ise beni hatırlama ordaki checkbox ın durumuna göre değiştirelim
                            FormsAuthentication.SetAuthCookie(parameters.Username, false);

                            Session.Add("UserNameFirst", getData[i].NameFirst);
                            Session.Add("UserNameLast", getData[i].NameLast);
                            Session.Add("UserRole", getData[i].Role);
                            Session.Add("UserId", getData[i].Id);
                            Session.Add("UserPic", getData[i].Pic);

                            return RedirectToAction("Index", "Home");

                        }
                    }
                }
                if (parameters.LoginError)
                {
                    parameters.Mesaj = "Kullanıcı veya Parola Hatalı..";
                }
            }
            else
            {
                parameters.Mesaj = "**Kullanıcılar Okunamadı";
            }

            parameters.HeaderTitle = "LOGİN";
            parameters.FromController = "Security";
            parameters.FromRoute = "Login";
            return View(parameters);
        }

        [Route("Logout")]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.RemoveAll();
            return RedirectToAction("Login", "Security");
        }
    }
}