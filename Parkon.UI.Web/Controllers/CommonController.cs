//using Prkn.Data.Master;
//using Prkn.Model;
//using Prkn.Bll.Base;
//using Prkn.Bll.Offer;
//using Prkn.Common.Generate;
//using Prkn.UI.Web.Enums;
//using Prkn.UI.Web.Models.ViewModels;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace Prkn.UI.Web.Controllers
//{
//    public class CommonController : Controller
//    {
//        public int ParameterDatatype { get; private set; }

//        // GET: Common
//        [Route("Bases/Form_Parameters")]
//        public ActionResult Index()
//        {
//            //Sayfaua göre değişir
//            OfferTypeBll offerTypeBll = new OfferTypeBll();
//            var getdata = offerTypeBll.GetSingle(x => x.Id == 752, x => x);
//            //****//


//            Prm prm = new Prm();
//            prm.Name = getdata.Name;
//            prm.Code = getdata.Code;
//            prm.Comment = getdata.Comment;
//            prm.Id = getdata.Id;


//            return CallPrmForm(prm);
//        }

//        //public ActionResult CallPrmForm(Prm Prm)
//        //{
//        //    var a = Prm.Code + "#";

//        //    Prm.Code = a;
//        //    return View("~/Views/Common/Bases/Form_Parameters.cshtml", Prm);
//        //}

//        //[HttpPost]
//        //public ActionResult PrmSave(ParametersEdit parametersEdit)
//        //{
//        //    switch (parametersEdit.ParameterDataSelect)
//        //    {
//        //        case ParameterDataSelect.OfferType:
//        //            var getBll                  = new OfferTypeBll();
//        //            var myModel                 = new Offer_Type();
//        //            myModel.Code                = parametersEdit.Prm.Code;
//        //            myModel.Name                = parametersEdit.Prm.Name;
//        //            myModel.Comment             = parametersEdit.Prm.Comment;
//        //            myModel.Id                  = Generator.CreateId(Common.Enums.IslemTuru.Insert, 0);

                    
//        //            parametersEdit.JobStatus  = getBll.Insert(myModel);
//        //            break;
//        //        case ParameterDataSelect.OfferRequestType:
//        //            break;
//        //        default:
//        //            break;
//        //    }

//        //    return View(parametersEdit);
//        //}



//        //public class SaveJob<TBll, TModel> where TBll : DbContext where TModel : class
//        //{


//        //    public void set()
//        //    {
//        //        var bll = ((BaseBll<TModel, PrknDataContext>)TBll).Insert;
//        //    }
//        //}


//    }
//}