using Prkn.Model;
using Prkn.Bll.Master.PrknDataBll.Customer;
using Prkn.Bll.Master.PrknDataBll.General;
using Prkn.Common.Enums;
using Prkn.Common.Functions;
using Prkn.Common.Generate;
using Prkn.UI.Web.Functions;
using Prkn.UI.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prkn.UI.Web.Controllers
{
   // [Authorize]
    [RoutePrefix("Musteri")]
    public class CustomerController : Controller
    {
        // GET: Musteriler
        #region MÜŞTERİ REHBERİ

        [Route("MusteriRehberiEdit/{islemturu}/{id}")]
        [HttpGet]
        public ActionResult Customer_Guide_Edit(IslemTuru islemTuru, long Id)
        {
            var parametersEdit = new CustomerEdit();

            CustomerTypeBll customerTypeBll = new CustomerTypeBll();
            ZoneBll zoneBll = new ZoneBll();

            parametersEdit.CustomerType = ViewFunction.DropDownModelFilling(customerTypeBll);
            parametersEdit.Zone = ViewFunction.DropDownModelFilling(zoneBll);
            parametersEdit.CustomerSectionName = "MERKEZ"; // default olarak
            parametersEdit.Prm = new Customers();
            parametersEdit.Prm.Pic = "~/Content/dist/img/Logo_Yok.png"; //default olarak
            parametersEdit.Prm.Score = "5"; //default olarak

            if (islemTuru==IslemTuru.Update ||islemTuru==IslemTuru.Delete)
            {
                var getBll = new CustomerBll();
              //  var myModel = new Customers();

                var getData = getBll.GetSingle(x => x.Id == Id, x => x);

                if (getData!=null)
                {
                  //  parametersEdit.Prm = new Customers();

                    parametersEdit.Prm.Id = getData.Id;
                    parametersEdit.Prm.Name=getData.Name;
                    parametersEdit.Prm.CustomerTypeId= getData.CustomerTypeId;
                    parametersEdit.Prm.Code= getData.Code;
                    parametersEdit.Prm.ZoneId= getData.ZoneId;
                    parametersEdit.Prm.Address= getData.Address;
                    parametersEdit.Prm.Maps= getData.Maps;
                    parametersEdit.Prm.Info= getData.Info;
                    parametersEdit.Prm.Phone1= getData.Phone1;
                    parametersEdit.Prm.Phone2= getData.Phone2;
                    parametersEdit.Prm.Fax= getData.Fax;
                    parametersEdit.Prm.Comment= getData.Comment;
                    parametersEdit.Prm.Keyword= getData.Keyword;
                    parametersEdit.Prm.Score = getData.Score;
                    if (getData.Pic!=null)
                    {
                       parametersEdit.Prm.Pic = getData.Pic;
                    }
             //       parametersEdit.CustomerSectionName = "MERKEZ";
                }
            }

            //Modal Başlangıç
            parametersEdit.ModalStatus = ViewFunction.modalstatus;
            ViewFunction.modalstatus = null;
            if (parametersEdit.ModalStatus == "insert")
            {
                parametersEdit.ModalMessage = "Müşteri Kaydınız Başarılı Bir Şekilde Oluşturulmuştur...(" + DateTime.Now + ")";
                parametersEdit.ModalTitle = "KAYIT";
            }
            else if (parametersEdit.ModalStatus == "delete")
            {
                parametersEdit.ModalMessage = "Müşteri Silinmiştir...(" + DateTime.Now + ")";
                parametersEdit.ModalTitle = "SİLME";
            }
            else if (parametersEdit.ModalStatus == "update")
            {
                parametersEdit.ModalMessage = "Müşteri Bilgileri Güncelleştirilmiştir...(" + DateTime.Now + ")";
                parametersEdit.ModalTitle = "GÜNCELLEME";
            }          
            //Modal Bitiş

            parametersEdit.IslemTuru = islemTuru;
            parametersEdit.HeaderTitle = "MÜŞTERİ OLUŞTUR";
            parametersEdit.FromController = "Musteri";
            parametersEdit.FromRoute = "MusteriRehberiEdit";

            return View(parametersEdit);
        }

        [Route("MusteriRehberiEdit")]
        [HttpPost]
        public ActionResult Customer_Guide_Edit(CustomerEdit parametersEdit)
        {
            //Required deneme
            
            //

            var getBll =new CustomerBll();
            var myModel =new Customers();

            long generateId = Generator.CreateId(parametersEdit.IslemTuru, parametersEdit.Prm.Id);
            myModel.Id = generateId;
            myModel.Name = parametersEdit.Prm.Name;
            myModel.CustomerTypeId = parametersEdit.Prm.CustomerTypeId;
            myModel.Code = parametersEdit.Prm.Code;
            myModel.ZoneId = parametersEdit.Prm.ZoneId;
            myModel.Address = parametersEdit.Prm.Address;
            myModel.Maps = parametersEdit.Prm.Maps;
            myModel.Info = parametersEdit.Prm.Info;
            myModel.Phone1 = parametersEdit.Prm.Phone1;
            myModel.Phone2 = parametersEdit.Prm.Phone2;
            myModel.Fax = parametersEdit.Prm.Fax;
            myModel.Comment = parametersEdit.Prm.Comment;
            myModel.Keyword = parametersEdit.Prm.Keyword;
            myModel.Score = parametersEdit.Prm.Score;
            myModel.UserId = (long)Session["UserId"]; //Burda login işleminde çektiğimiz UserID

            if (parametersEdit.ImageFile != null) //Fotoğraf yüklenmişse
            {
                //İmage işlemi
                string filename = Path.GetFileNameWithoutExtension(parametersEdit.ImageFile.FileName);//dosya adı
                string extension = Path.GetExtension(parametersEdit.ImageFile.FileName); //uzantısı
                filename = generateId.ToString() + extension; // fotoadını customerıd yapıyoruz
                myModel.Pic = "~/Content/dist/img/Customer_Image/" + filename; //Veritabanına adres kayıt
                filename = Path.Combine(Server.MapPath("~/Content/dist/img/Customer_Image/"), filename); //serverdaki kayıt edilecek dosya dizin adresi
                parametersEdit.ImageFile.SaveAs(filename); //Dosya dizinimize dosyayı çekme farklı kaydetme işlemi                                                         
                //image işlemi
            }
            else
            {
                myModel.Pic = parametersEdit.Prm.Pic;
            }
            var customersectionmodel = new Customer_Section();
            var customersectionBll = new CustomerSectionBll();

            //İlk Kayıtta girilen bilgileri merkez olduğu için customersection alanınada ekliyoruz
            long sectiongenerateId = Generator.CreateId(parametersEdit.IslemTuru, customersectionmodel.Id);
            customersectionmodel.Id = sectiongenerateId;
            customersectionmodel.CustomerId = myModel.Id;
            customersectionmodel.Name = parametersEdit.CustomerSectionName;
            customersectionmodel.Code = parametersEdit.CustomerSectionName;
            customersectionmodel.ZoneId = parametersEdit.Prm.ZoneId;
            customersectionmodel.Address = parametersEdit.Prm.Address;
            customersectionmodel.Maps = parametersEdit.Prm.Maps;
            customersectionmodel.Info = parametersEdit.Prm.Info;
            customersectionmodel.Phone1 = parametersEdit.Prm.Phone1;
            customersectionmodel.Phone2 = parametersEdit.Prm.Phone2;
            customersectionmodel.Fax = parametersEdit.Prm.Fax;
            customersectionmodel.Comment = parametersEdit.Prm.Comment;
            customersectionmodel.Keyword = parametersEdit.Prm.Keyword;
            //

            //Gerekli alan Kontrolü
            if (ModelState.IsValid)
            {
                if (parametersEdit.IslemTuru == IslemTuru.Insert)
                {
                    parametersEdit.JobStatus = DateTime.Now + " - Müşteri Oluşturuldu " + getBll.Insert(myModel) + customersectionBll.Insert(customersectionmodel);
                    ViewFunction.modalstatus = "insert";
                    parametersEdit.IslemTuru = IslemTuru.Update;
                }
                else if (parametersEdit.IslemTuru == IslemTuru.Update)
                {
                    parametersEdit.JobStatus = DateTime.Now + " - Müşteri Düzenleme işlemi " + getBll.Update(myModel) + customersectionBll.Update(customersectionmodel);
                    ViewFunction.modalstatus = "update";

                }

                else if (parametersEdit.IslemTuru == IslemTuru.Delete)
                {
                    parametersEdit.JobStatus = DateTime.Now + " - Müşteri silme işlemi " + getBll.DeleteSoft(myModel) + customersectionBll.DeleteSoft(customersectionmodel);
                    ViewFunction.modalstatus = "delete";
                }
            }
            else
            {
                ViewBag.Message = "Doğrulama başarısız..";
            }


            return RedirectToAction("MusteriRehberiEdit/" + parametersEdit.IslemTuru + "/" + generateId , "Musteri");
        }


        [Route("MusteriRehberi")]
        public ActionResult Customer_Guide_List()
        {
            var myBll = new CustomerBll();
            var list = myBll.ListRefresh();

            var parameters = new CustomerList();

            var zoneList = new List<DropDownModel>();
            var customerTypeList = new List<DropDownModel>();

            var myPrmList = new List<Customers>();
            for (int i = 0; i < list.Count; i++)
            {
                Customers prm = new Customers();

                prm.Id = list[i].Id;
                prm.Pic = list[i].Pic;
                prm.Code = list[i].Code;
                prm.Name = list[i].Name;
                prm.Score = list[i].Score;
                prm.Info = list[i].Info;
                prm.Keyword = list[i].Keyword;
                prm.Phone1 = list[i].Phone1;
                prm.Phone2 = list[i].Phone2;
                prm.Fax = list[i].Fax;
                prm.Address = list[i].Address;
                prm.Maps = list[i].Maps;

                //Farklı tablolardakiler
                prm.ZoneId = list[i].ZoneId;
                prm.CustomerTypeId = list[i].CustomerTypeId;

                if (list[i].VarStatus == null) //yani kayıt silinmiş değilse ekle
                {
                    myPrmList.Add(prm);

                    if (list[i].ZoneId != null)
                    {
                        zoneList.Add(ViewFunction.GetZone((long)list[i].ZoneId));
                    }
                    if (list[i].CustomerTypeId != null)
                    {
                        customerTypeList.Add(ViewFunction.GetCustomerType(list[i].CustomerTypeId));
                    }
                    
                }

            }

            parameters.Prm = myPrmList;
            parameters.ZoneList = zoneList;
            parameters.CustomerTypeList = customerTypeList;

            

          //  parameters.IslemTuru = islemTuru;
            parameters.HeaderTitle = "MÜŞTERİ ŞİRKET REHBERİ";
            parameters.FromController = "Musteri";
            parameters.FromRoute = "MusteriRehberiEdit";

            return View(parameters);
        }
        #endregion
        #region MUŞTERİ KİŞİ
        [Route("MusteriKisi")]
        public ActionResult Customer_Personel_List()
        {
            var myBll = new CustomerContactBll();
            var list = myBll.ListRefresh();

            var parameters = new CustomerPersonelList();

            var customerList= new List<DropDownModel>();
            var titleList = new List<DropDownModel>();

            var myPrmList = new List<Customer_Contact>();
            for (int i = 0; i < list.Count; i++)
            {
                Customer_Contact prm = new Customer_Contact();

                prm.Id = list[i].Id;
                prm.Pic = list[i].Pic;
                prm.CustomerId = list[i].CustomerId;
                prm.NameFirst = list[i].NameFirst;
                prm.NameLast = list[i].NameLast;
                prm.TitleId = list[i].TitleId;
                prm.Job = list[i].Job;
                prm.Gender = list[i].Gender;
                prm.Score = list[i].Score;
                prm.Info = list[i].Info;
                prm.Keyword = list[i].Keyword;
                prm.Phone1 = list[i].Phone1;
                prm.Phone2 = list[i].Phone2;
                prm.Mail1 = list[i].Mail1;
                prm.Mail2 = list[i].Mail2;


                if (list[i].VarStatus == null) //yani kayıt silinmiş değilse ekle
                {
                    myPrmList.Add(prm);

                    customerList.Add(ViewFunction.getCustomer((long)list[i].CustomerId));
                    titleList.Add(ViewFunction.getTitle((long)list[i].TitleId));
                }

            }

            parameters.Prm = myPrmList;
            parameters.Customer = customerList;
            parameters.Title = titleList;

            //  parameters.IslemTuru = islemTuru;
            parameters.HeaderTitle = "MÜŞTERİ KİŞİ LİSTESİ";
            parameters.FromController = "Musteri";
            parameters.FromRoute = "MusteriKisiEdit";

            return View(parameters);
        }

        [Route("MusteriKisiEdit/{islemturu}/{id}")]
        [HttpGet]
        public ActionResult Customer_Personel_Edit(IslemTuru islemTuru, long Id)
        {
            var parametersEdit = new CustomerPersonelEdit();

            CustomerBll customerBll = new CustomerBll();
            TitleBll titleBll = new TitleBll();

            parametersEdit.Customer = ViewFunction.DropDownModelFilling(customerBll).OrderBy(x=>x.Name).ToList();
            parametersEdit.Title = ViewFunction.DropDownModelFilling(titleBll);
            parametersEdit.Prm = new Customer_Contact();

            parametersEdit.Prm.Pic = "~/Content/dist/img/avatar5.png"; //default olarak
            parametersEdit.Prm.Score = "5"; //default olarak

            if (islemTuru == IslemTuru.Update || islemTuru == IslemTuru.Delete)
            {
                var getBll = new CustomerContactBll();
                //  var myModel = new Customer_Section();

                var getData = getBll.GetSingle(x => x.Id == Id, x => x);

                if (getData != null)
                {
                    //  parametersEdit.Prm = new Customers();
                    parametersEdit.Prm.Id = getData.Id;
                    parametersEdit.Prm.NameFirst = getData.NameFirst;
                    parametersEdit.Prm.NameLast = getData.NameLast;
                    parametersEdit.Prm.CustomerId = getData.CustomerId;
                    parametersEdit.Prm.TitleId = getData.TitleId;
                    parametersEdit.Prm.Job = getData.Job;
                    parametersEdit.Prm.Info = getData.Info;
                    parametersEdit.Prm.Phone1 = getData.Phone1;
                    parametersEdit.Prm.Phone2 = getData.Phone2;
                    parametersEdit.Prm.Mail1 = getData.Mail1;
                    parametersEdit.Prm.Mail2 = getData.Mail2;
                    parametersEdit.Prm.Comment = getData.Comment;
                    parametersEdit.Prm.Keyword = getData.Keyword;
                    parametersEdit.Prm.Score = getData.Score;
                    if (getData.Pic != null)
                    {
                        parametersEdit.Prm.Pic = getData.Pic;
                    }
                    //       parametersEdit.CustomerSectionName = "MERKEZ";
                }
            }
            //Modal Başlangıç
            parametersEdit.ModalStatus = ViewFunction.modalstatus;
            ViewFunction.modalstatus = null;
            if (parametersEdit.ModalStatus == "insert")
            {
                parametersEdit.ModalMessage = "Kişi Kaydınız Başarılı Bir Şekilde Oluşturulmuştur...(" + DateTime.Now + ")";
                parametersEdit.ModalTitle = "KAYIT";
            }
            else if (parametersEdit.ModalStatus == "delete")
            {
                parametersEdit.ModalMessage = "Kişi Silinmiştir...(" + DateTime.Now + ")";
                parametersEdit.ModalTitle = "SİLME";
            }
            else if (parametersEdit.ModalStatus == "update")
            {
                parametersEdit.ModalMessage = "Kişi Bilgileri Güncelleştirilmiştir...(" + DateTime.Now + ")";
                parametersEdit.ModalTitle = "GÜNCELLEME";
            }
            //Modal Bitiş

            parametersEdit.IslemTuru = islemTuru;
            parametersEdit.HeaderTitle = "MÜŞTERİ KİŞİ OLUŞTUR";
            parametersEdit.FromController = "Musteri";
            parametersEdit.FromRoute = "MusteriKisiEdit";

            return View(parametersEdit);
        }
        [Route("MusteriKisiEdit")]
        [HttpPost]
        public ActionResult Customer_Personel_Edit(CustomerPersonelEdit parametersEdit)
        {
            var getBll = new CustomerContactBll();
            var myModel = new Customer_Contact();

            long generateId = Generator.CreateId(parametersEdit.IslemTuru, parametersEdit.Prm.Id);
            myModel.Id = generateId;
            myModel.NameFirst = parametersEdit.Prm.NameFirst;
            myModel.NameLast = parametersEdit.Prm.NameLast;
            myModel.CustomerId = parametersEdit.Prm.CustomerId;
            myModel.TitleId = parametersEdit.Prm.TitleId;
            myModel.Info = parametersEdit.Prm.Info;
            myModel.Phone1 = parametersEdit.Prm.Phone1;
            myModel.Phone2 = parametersEdit.Prm.Phone2;
            myModel.Job = parametersEdit.Prm.Job;
            myModel.Mail1 = parametersEdit.Prm.Mail1;
            myModel.Mail2 = parametersEdit.Prm.Mail2;
            myModel.Comment = parametersEdit.Prm.Comment;
            myModel.Keyword = parametersEdit.Prm.Keyword;
            myModel.Score = parametersEdit.Prm.Score;
            myModel.UserId = (long)Session["UserId"]; //Burda login işleminde çektiğimiz UserID

            //Gender, ekleme işlemini burda yap

            if (parametersEdit.ImageFile != null) //Fotoğraf yüklenmişse
            {
                //İmage işlemi
                string filename = Path.GetFileNameWithoutExtension(parametersEdit.ImageFile.FileName);//dosya adı
                string extension = Path.GetExtension(parametersEdit.ImageFile.FileName); //uzantısı
                filename = generateId.ToString() + extension; // fotoadını customerıd yapıyoruz
                myModel.Pic = "~/Content/dist/img/Customer_Contact_Image/" + filename; //Veritabanına adres kayıt
                filename = Path.Combine(Server.MapPath("~/Content/dist/img/Customer_Contact_Image/"), filename); //serverdaki kayıt edilecek dosya dizin adresi
                parametersEdit.ImageFile.SaveAs(filename); //Dosya dizinimize dosyayı çekme farklı kaydetme işlemi                                                         
                //image işlemi
            }
            else
            {
                myModel.Pic = parametersEdit.Prm.Pic;
            }

            if (parametersEdit.IslemTuru == IslemTuru.Insert)
            {
                parametersEdit.JobStatus = DateTime.Now + " - Kişi Oluşturuldu " + getBll.Insert(myModel);
                ViewFunction.modalstatus = "insert";
                parametersEdit.IslemTuru = IslemTuru.Update;
            }
            else if (parametersEdit.IslemTuru == IslemTuru.Update)
            {
                parametersEdit.JobStatus = DateTime.Now + " - Kişi Düzenleme işlemi " + getBll.Update(myModel);
                ViewFunction.modalstatus = "update";
            }

            else if (parametersEdit.IslemTuru == IslemTuru.Delete)
            {
                parametersEdit.JobStatus = DateTime.Now + " - Kişi silme işlemi " + getBll.DeleteSoft(myModel);
                ViewFunction.modalstatus = "delete";
            }

            return RedirectToAction(parametersEdit.FromRoute+"/" + parametersEdit.IslemTuru + "/" + generateId, parametersEdit.FromController);
        }
        #endregion

        #region MÜŞTERİ BÖLÜMÜ
        [Route("MusteriBolumu")]
        public ActionResult Customer_Section_List()
        {
            var myBll = new CustomerSectionBll();
            var list = myBll.ListRefresh();

            var parameters = new CustomerSectionList();

            var customerList = new List<DropDownModel>();
            var zoneList = new List<DropDownModel>();

            var myPrmList = new List<Customer_Section>();
            for (int i = 0; i < list.Count; i++)
            {
                Customer_Section prm = new Customer_Section();

                prm.Id = list[i].Id;
                prm.CustomerId = list[i].CustomerId;
                prm.Code = list[i].Code;
                prm.Name = list[i].Name;
                prm.Score = list[i].Score;
                prm.Info = list[i].Info;
                prm.Keyword = list[i].Keyword;
                prm.Phone1 = list[i].Phone1;
                prm.Phone2 = list[i].Phone2;
                prm.Fax = list[i].Fax;
                prm.Address = list[i].Address;
                prm.Maps = list[i].Maps;
                prm.Pic = list[i].Pic;

                //Farklı tablolardakiler
                prm.ZoneId = list[i].ZoneId;

                if (list[i].VarStatus == null) //yani kayıt silinmiş değilse ekle
                {
                    myPrmList.Add(prm);

                 //   zoneList.Add(ViewFunction.GetZone((long)list[i].ZoneId));
                //    customerList.Add(ViewFunction.getCustomer((long)list[i].CustomerId));

                    if (list[i].ZoneId != null)
                    {
                        zoneList.Add(ViewFunction.GetZone((long)list[i].ZoneId));
                    }
                    if (list[i].CustomerId != null)
                    {
                        customerList.Add(ViewFunction.getCustomer((long)list[i].CustomerId));
                    }
                }

            }

            parameters.Prm = myPrmList;
            parameters.ZoneList = zoneList;
            parameters.Customer = customerList;

            //  parameters.IslemTuru = islemTuru;
            parameters.HeaderTitle = "MÜŞTERİ BÖLÜM LİSTESİ";
            parameters.FromController = "Musteri";
            parameters.FromRoute = "MusteriBolumuEdit";

            return View(parameters);
        }

        [Route("MusteriBolumuEdit/{islemturu}/{id}")]
        [HttpGet]
        public ActionResult Customer_Section_Edit(IslemTuru islemTuru, long Id)
        {
            var parametersEdit = new CustomerSectionEdit();

            CustomerBll customerBll = new CustomerBll();
            ZoneBll zoneBll = new ZoneBll();

            parametersEdit.Customer = ViewFunction.DropDownModelFilling(customerBll).OrderBy(x => x.Name).ToList();
            parametersEdit.Zone = ViewFunction.DropDownModelFilling(zoneBll);
            parametersEdit.Prm = new Customer_Section();

            parametersEdit.Prm.Pic = "~/Content/dist/img/Logo_Yok.png"; //default olarak
            parametersEdit.Prm.Score = "5"; //default olarak

            if (islemTuru == IslemTuru.Update || islemTuru == IslemTuru.Delete)
            {
                var getBll = new CustomerSectionBll();
              //  var myModel = new Customer_Section();

                var getData = getBll.GetSingle(x => x.Id == Id, x => x);

                if (getData != null)
                {
                    //  parametersEdit.Prm = new Customers();
                    parametersEdit.Prm.Id = getData.Id;
                    parametersEdit.Prm.Name = getData.Name;
                    parametersEdit.Prm.CustomerId = getData.CustomerId;
                    parametersEdit.Prm.Code = getData.Code;
                    parametersEdit.Prm.ZoneId = getData.ZoneId;
                    parametersEdit.Prm.Address = getData.Address;
                    parametersEdit.Prm.Maps = getData.Maps;
                    parametersEdit.Prm.Info = getData.Info;
                    parametersEdit.Prm.Phone1 = getData.Phone1;
                    parametersEdit.Prm.Phone2 = getData.Phone2;
                    parametersEdit.Prm.Fax = getData.Fax;
                    parametersEdit.Prm.Comment = getData.Comment;
                    parametersEdit.Prm.Keyword = getData.Keyword;
                    parametersEdit.Prm.Score = getData.Score;
                    if (getData.Pic != null)
                    {
                        parametersEdit.Prm.Pic = getData.Pic;
                    }
                    //       parametersEdit.CustomerSectionName = "MERKEZ";
                }
            }
            //Modal Başlangıç
            parametersEdit.ModalStatus = ViewFunction.modalstatus;
            ViewFunction.modalstatus = null;
            if (parametersEdit.ModalStatus == "insert")
            {
                parametersEdit.ModalMessage = "Müşteri Bölüm Kaydınız Başarılı Bir Şekilde Oluşturulmuştur...(" + DateTime.Now + ")";
                parametersEdit.ModalTitle = "KAYIT";
            }
            else if (parametersEdit.ModalStatus == "delete")
            {
                parametersEdit.ModalMessage = "Müşteri Bölüm Silinmiştir...(" + DateTime.Now + ")";
                parametersEdit.ModalTitle = "SİLME";
            }
            else if (parametersEdit.ModalStatus == "update")
            {
                parametersEdit.ModalMessage = "Müşteri Bölüm Bilgileri Güncelleştirilmiştir...(" + DateTime.Now + ")";
                parametersEdit.ModalTitle = "GÜNCELLEME";
            }
            //Modal Bitiş

            parametersEdit.IslemTuru = islemTuru;
            parametersEdit.HeaderTitle = "MÜŞTERİ BÖLÜM OLUŞTUR";
            parametersEdit.FromController = "Musteri";
            parametersEdit.FromRoute = "MusteriBolumuEdit";

            return View(parametersEdit);
        }
        
        [Route("MusteriBolumuEdit")]
        [HttpPost]
        public ActionResult Customer_Section_Edit(CustomerSectionEdit parametersEdit)
        {
            var getBll = new CustomerSectionBll();
            var myModel = new Customer_Section();

            long generateId = Generator.CreateId(parametersEdit.IslemTuru, parametersEdit.Prm.Id);
            myModel.Id = generateId;
            myModel.Name = parametersEdit.Prm.Name;
            myModel.CustomerId = parametersEdit.Prm.CustomerId;
            myModel.Code = parametersEdit.Prm.Code;
            myModel.ZoneId = parametersEdit.Prm.ZoneId;
            myModel.Address = parametersEdit.Prm.Address;
            myModel.Maps = parametersEdit.Prm.Maps;
            myModel.Info = parametersEdit.Prm.Info;
            myModel.Phone1 = parametersEdit.Prm.Phone1;
            myModel.Phone2 = parametersEdit.Prm.Phone2;
            myModel.Fax = parametersEdit.Prm.Fax;
            myModel.Comment = parametersEdit.Prm.Comment;
            myModel.Keyword = parametersEdit.Prm.Keyword;
            myModel.Score = parametersEdit.Prm.Score;
            myModel.UserId = (long)Session["UserId"]; //Burda login işleminde çektiğimiz UserID

            if (parametersEdit.ImageFile != null) //Fotoğraf yüklenmişse
            {
                //İmage işlemi
                string filename = Path.GetFileNameWithoutExtension(parametersEdit.ImageFile.FileName);//dosya adı
                string extension = Path.GetExtension(parametersEdit.ImageFile.FileName); //uzantısı
                filename = generateId.ToString() + extension; // fotoadını customerıd yapıyoruz
                myModel.Pic = "~/Content/dist/img/Customer_Section_Image/" + filename; //Veritabanına adres kayıt
                filename = Path.Combine(Server.MapPath("~/Content/dist/img/Customer_Section_Image/"), filename); //serverdaki kayıt edilecek dosya dizin adresi
                parametersEdit.ImageFile.SaveAs(filename); //Dosya dizinimize dosyayı çekme farklı kaydetme işlemi                                                         
                //image işlemi
            }
            else
            {
                myModel.Pic = parametersEdit.Prm.Pic;
            }

            if (parametersEdit.IslemTuru == IslemTuru.Insert)
            {
                parametersEdit.JobStatus = DateTime.Now + " - Müşteri Bölümü Oluşturuldu " + getBll.Insert(myModel);
                ViewFunction.modalstatus = "insert";
                parametersEdit.IslemTuru = IslemTuru.Update;
            }
            else if (parametersEdit.IslemTuru == IslemTuru.Update)
            {
                parametersEdit.JobStatus = DateTime.Now + " - Müşteri Bölümü Düzenleme işlemi " + getBll.Update(myModel);
                ViewFunction.modalstatus = "update";
            }

            else if (parametersEdit.IslemTuru == IslemTuru.Delete)
            {
                parametersEdit.JobStatus = DateTime.Now + " - Müşteri Bölümü silme işlemi " + getBll.DeleteSoft(myModel);
                ViewFunction.modalstatus = "delete";
            }

            return RedirectToAction("MusteriBolumuEdit/" + parametersEdit.IslemTuru + "/" + generateId, "Musteri");
        }

        #endregion
        #region MÜŞTERİ TÜRÜ
        [Route("MusteriTuru")]
        public ActionResult Customer_Type_List()
        {
            var myBll = new CustomerTypeBll();   //##### Fonksiyona göre değişir
            var list = myBll.ListRefresh();

            var myPrmList = new List<Prm>();
            for (int i = 0; i < list.Count; i++)
            {
                Prm prm = new Prm();
                prm.Id = list[i].Id;
                prm.Name = list[i].Name;
                prm.Code = list[i].Code;
                prm.Comment = list[i].Comment;
                myPrmList.Add(prm);
            }

            var parameters = new ParametersList();
            parameters.Prm = myPrmList;
            parameters.HeaderTitle = "MÜŞTERİ TÜRÜ";       //##### Fonksiyona göre değişir
            parameters.FromController = "Musteri";                     //##### Fonksiyona göre değişir
            parameters.FromRoute = "MusteriTuruEdit";     //##### Fonksiyona göre değişir

            return View(parameters);
        }

        [Route("MusteriTuruEdit/{islemturu}/{Id}")]
        [HttpGet]
        public ActionResult Customer_Type_Edit(long Id, IslemTuru islemturu)
        {
            var getBll = new CustomerTypeBll(); //Fonksiyone göre değiştir
            
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            var parametersEdit = new ParametersEdit();

            parametersEdit = ViewFunction.ModelToParameterEdit(getData, Id, islemturu); //GET işlemi için

            parametersEdit.HeaderTitle = "MÜŞTERİ TÜRÜ"; //Fonksiyone göre değiştir
            parametersEdit.FromController = "Musteri";        //Fonksiyone göre değiştir
            parametersEdit.FromRoute = "MusteriTuruEdit"; //Fonksiyone göre değiştir


            return View(parametersEdit);
        }
        [Route("MusteriTuruEdit")]
        [HttpPost]
        public ActionResult Customer_Type_Edit(ParametersEdit parametersEdit)
        {
            var getBll = new CustomerTypeBll(); //Fonksiyone göre değiştir
            var myModel = new Customer_Type();  //Fonksiyone göre değiştir

            ViewFunction.ParametersEditToModel(parametersEdit, myModel, getBll); //Post işlemi için

            return View(parametersEdit);
        }

        #endregion

        #region UNVAN
        [Route("Unvan")]
        public ActionResult Title_List()
        {
            var myBll = new TitleBll();   //##### Fonksiyona göre değişir
            var list = myBll.ListRefresh();

            var myPrmList = new List<Prm>();
            for (int i = 0; i < list.Count; i++)
            {
                Prm prm = new Prm();
                prm.Id = list[i].Id;
                prm.Name = list[i].Name;
                prm.Code = list[i].Code;
                prm.Comment = list[i].Comment;
                myPrmList.Add(prm);
            }

            var parameters = new ParametersList();
            parameters.Prm = myPrmList;
            parameters.HeaderTitle = "ÜNVAN";       //##### Fonksiyona göre değişir
            parameters.FromController = "Musteri";                     //##### Fonksiyona göre değişir
            parameters.FromRoute = "UnvanEdit";     //##### Fonksiyona göre değişir

            return View(parameters);
        }

        [Route("UnvanEdit/{islemturu}/{Id}")]
        [HttpGet]
        public ActionResult Title_Edit(long Id,IslemTuru islemturu)
        {
            var getBll = new TitleBll(); //Fonksiyone göre değiştir
            
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);
            var parametersEdit = new ParametersEdit();

            parametersEdit = ViewFunction.ModelToParameterEdit(getData, Id, islemturu); //GET işlemi için

            parametersEdit.HeaderTitle = "ÜNVAN"; //Fonksiyone göre değiştir
            parametersEdit.FromController = "Musteri";        //Fonksiyone göre değiştir
            parametersEdit.FromRoute = "UnvanEdit"; //Fonksiyone göre değiştir

            return View(parametersEdit);
        }
        [Route("UnvanEdit")]
        [HttpPost]
        public ActionResult Title_Edit(ParametersEdit parametersEdit)
        {
            var getBll = new TitleBll(); //Fonksiyone göre değiştir
            var myModel = new Title();  //Fonksiyone göre değiştir

            ViewFunction.ParametersEditToModel(parametersEdit, myModel, getBll); //Post işlemi için

            return View(parametersEdit);
        }
        #endregion

    }
}