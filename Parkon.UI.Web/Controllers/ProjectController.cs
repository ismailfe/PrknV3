using Prkn.Model;
using Prkn.Bll.Master.PrknDataBll.Project;
using Prkn.UI.Web.Functions;
using Prkn.UI.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prkn.UI.Web.Controllers
{
    [RoutePrefix("Proje")]
    //[Authorize]
    public class ProjectController : Controller
    {
        // GET: Proje
        [Route("ProjeListele")]
        public ActionResult Proje_Listele()
        {
            var myBll = new ProjectBll();

            //Listeyi tarihe göre Yeniden Eskiye doğru sıralıyoruz
            //var list = myBll.ListRefresh().OrderBy(x => x.DateStart); // bu kodu çalıştırınca alt tarafta işler yolunda gitmiyor
            
            var list = myBll.ListRefresh().OrderByDescending(x => x.DateStart).ToList();
            //Burdan sırlama yaptıktan sonra datatable ın scriptinide düzelt
            //  var a = list[13].Offer_Status.Name;

            var parameters = new ProjectList();

            var customersectionList = new List<DropDownModel>();
            var customerList = new List<DropDownModel>();

            var myPrmList = new List<Projects>();
            parameters.ProjectCount = list.Count;
            for (int i = 0; i < list.Count; i++)
            {
                Projects prm = new Projects();
                prm.Id = list[i].Id;
                prm.Code = list[i].Code;
                prm.DateStart = list[i].DateStart;

                prm.Name = list[i].Name;
                if (list[i].CreateDate == null) //Güncelleme yapılınca tabloda createdate null oluyor bu nedenle koşul ekledik
                {
                    prm.CreateDate = list[i].UpdateDate;
                }
                else
                {
                    prm.CreateDate = list[i].CreateDate;
                }

                myPrmList.Add(prm);
                customersectionList.Add(ViewFunction.getCustomerSection((long)list[i].CustomerSectionId));
                customerList.Add(ViewFunction.getCustomer((long)list[i].CustomerId));

            }
            parameters.Prm = myPrmList;
            parameters.Customers = customerList;
            parameters.Customer_Section = customersectionList;

            parameters.HeaderTitle = "Proje LİSTELE";       //Fonksiyona göre değişir
            parameters.FromController = "Proje";                     //Fonksiyona göre değişir
            parameters.FromRoute = "ProjeDuzenle";     //Fonksiyona göre değişir

            return View(parameters);
        }
        [Route("ProjeSorgula")]
        public ActionResult Proje_Sorgula()
        {
            //yetkili mi?
            return View();
        }

        [Route("ProjeOlustur")]
        public ActionResult Proje_Olustur()
        {
            return View();
        }

        [Route("ProjeDuzenle")]
        public ActionResult Proje_Duzenle()
        {
            return View();
        }
    }
}