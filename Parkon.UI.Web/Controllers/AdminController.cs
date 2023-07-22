using Prkn.Model;
using Prkn.Bll.Master.PrknDataBll.General;
using Prkn.Bll.Master.PrknDataBll.User;
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
    
    [RoutePrefix("Admin")]
    public class AdminController : Controller
    {
        // GET: Admin
        #region Kullanıcı İşlemleri
        [Route("Kullanici")]
        public ActionResult User_List()
        {
            var myBll = new UserBll();
            var list = myBll.ListRefresh();
           
            var parameters = new UserList();
            
            var departmentList = new List<DropDownModel>();
            var titleList = new List<DropDownModel>();

            var myPrmList = new List<Users>();
            for (int i = 0; i < list.Count; i++)
            {
                Users prm = new Users();

                prm.Id = list[i].Id;
                prm.Pic = list[i].Pic;
                prm.BirthDate = list[i].BirthDate;
                prm.NameFirst = list[i].NameFirst;
                prm.NameLast = list[i].NameLast;
                prm.TitleId = list[i].TitleId;
                prm.Role = list[i].Role;
                prm.Keyword = list[i].Keyword;
                prm.Phone1 = list[i].Phone1;
                prm.Phone2 = list[i].Phone2;
                prm.Mail1 = list[i].Mail1;
                prm.Mail2 = list[i].Mail2;
                prm.UserName = list[i].UserName;
                prm.Pass = list[i].Pass;
                prm.Comment = list[i].Comment;


                if (list[i].VarStatus == null) //yani kayıt silinmiş değilse ekle
                {
                    myPrmList.Add(prm);

                    if (list[i].TitleId != null)
                    {
                        titleList.Add(ViewFunction.getTitle((long)list[i].TitleId));
                    }

                    if (list[i].DepartmentId != null)
                    {
                        departmentList.Add(ViewFunction.getDepartment((long)list[i].DepartmentId));
                    }
                    
                }

            }

            parameters.Prm = myPrmList;
            parameters.Title = titleList;
            parameters.Department = departmentList;

            //  parameters.IslemTuru = islemTuru;
            parameters.HeaderTitle = "KULLANICILAR";
            parameters.FromController = "Admin";
            parameters.FromRoute = "KullaniciEdit";

            return View(parameters);
        }

        [Authority("Admin")]
        [Route("KullaniciEdit/{IslemTuru}/{Id}")]
        [HttpGet]
        public ActionResult User_Edit(IslemTuru islemTuru, long Id)
        {
            var parametersEdit = new UserEdit();

            TitleBll titleBll = new TitleBll();
            UserDepartmentBll departmentBll = new UserDepartmentBll();

            parametersEdit.Title = ViewFunction.DropDownModelFilling(titleBll);
            parametersEdit.Department = ViewFunction.DropDownModelFilling(departmentBll);

            //Rol DDL için elimizle dolduruyoruz Çünkü Harici bir tablomuz yok
            try
            {              
                var list = new List<DropDownModel>();
                DropDownModel liste = new DropDownModel();
                liste.Id = 0;
                liste.Name = "User";
                list.Add(liste);
                liste = new DropDownModel();
                liste.Id = 1;
                liste.Name = "Admin";
                list.Add(liste);

                parametersEdit.Role = list;
                parametersEdit.RoleId = 0;//User seçili olarak gelsin diyoruz
            }
            catch (Exception)
            {
                throw;
            }
            //Role ./
            parametersEdit.Prm = new Users();

            parametersEdit.Prm.Pic = "~/Content/dist/img/avatar5.png"; //default olarak

            if (islemTuru == IslemTuru.Update || islemTuru == IslemTuru.Delete)
            {
                var getBll = new UserBll();

                var getData = getBll.GetSingle(x => x.Id == Id, x => x);

                if (getData != null)
                {
                    parametersEdit.Prm.Id = getData.Id;
                    parametersEdit.Prm.NameFirst = getData.NameFirst;
                    parametersEdit.Prm.NameLast = getData.NameLast;
                    parametersEdit.Prm.BirthDate = getData.BirthDate;
                    parametersEdit.Prm.UserName = getData.UserName;
                    parametersEdit.Prm.Pass = getData.Pass;
                    parametersEdit.Prm.TitleId = getData.TitleId;
                    parametersEdit.Prm.DepartmentId = getData.DepartmentId;
                    parametersEdit.Prm.Phone1 = getData.Phone1;
                    parametersEdit.Prm.Phone2 = getData.Phone2;
                    parametersEdit.Prm.Mail1 = getData.Mail1;
                    parametersEdit.Prm.Mail2 = getData.Mail2;
                    parametersEdit.Prm.Comment = getData.Comment;

                    if (getData.Pic != null)
                    {
                        parametersEdit.Prm.Pic = getData.Pic;
                    }
                }
            }
            //Modal Başlangıç
            parametersEdit.ModalStatus = ViewFunction.modalstatus;
            ViewFunction.modalstatus = null;
            if (parametersEdit.ModalStatus == "insert")
            {
                parametersEdit.ModalMessage = "Kullanıcı Başarılı Bir Şekilde Oluşturulmuştur...(" + DateTime.Now + ")";
                parametersEdit.ModalTitle = "KAYIT";
            }
            else if (parametersEdit.ModalStatus == "delete")
            {
                parametersEdit.ModalMessage = "Kullanıcı Silinmiştir...(" + DateTime.Now + ")";
                parametersEdit.ModalTitle = "SİLME";
            }
            else if (parametersEdit.ModalStatus == "update")
            {
                parametersEdit.ModalMessage = "Kullanıcı Bilgileri Güncelleştirilmiştir...(" + DateTime.Now + ")";
                parametersEdit.ModalTitle = "GÜNCELLEME";
            }
            //Modal Bitiş

            parametersEdit.IslemTuru = islemTuru;
            parametersEdit.HeaderTitle = "KULLANICI OLUŞTUR";
            parametersEdit.FromController = "Admin";
            parametersEdit.FromRoute = "KullaniciEdit";

            return View(parametersEdit);
        }


        [Route("KullaniciEdit")]
        [HttpPost]
        public ActionResult User_Edit(UserEdit parametersEdit)
        {
            var getBll = new UserBll();
            var myModel = new Users();

            long generateId = Generator.CreateId(parametersEdit.IslemTuru, parametersEdit.Prm.Id);
            myModel.Id = generateId;
            myModel.NameFirst = parametersEdit.Prm.NameFirst;
            myModel.NameLast = parametersEdit.Prm.NameLast;
            myModel.BirthDate = parametersEdit.Prm.BirthDate;
            myModel.TitleId = parametersEdit.Prm.TitleId;
            myModel.DepartmentId = parametersEdit.Prm.DepartmentId; 
            myModel.UserName = parametersEdit.Prm.UserName;
            myModel.Pass = parametersEdit.Prm.Pass;
            myModel.Phone1 = parametersEdit.Prm.Phone1;
            myModel.Phone2 = parametersEdit.Prm.Phone2;
            myModel.Mail1 = parametersEdit.Prm.Mail1;
            myModel.Mail2 = parametersEdit.Prm.Mail2;
            myModel.Comment = parametersEdit.Prm.Comment;
            myModel.UserId = (long)Session["UserId"]; //Burda login işleminde çektiğimiz UserID

            if (parametersEdit.RoleId==0)
            {
                myModel.Role = "User";
            }
            else if (parametersEdit.RoleId ==1)
            {
                myModel.Role = "Admin";
            }         

            //Gender, ekleme işlemini burda yap

            if (parametersEdit.ImageFile != null) //Fotoğraf yüklenmişse
            {
                //İmage işlemi
                string filename = Path.GetFileNameWithoutExtension(parametersEdit.ImageFile.FileName);//dosya adı
                string extension = Path.GetExtension(parametersEdit.ImageFile.FileName); //uzantısı
                filename = generateId.ToString() + extension; // fotoadını customerıd yapıyoruz
                myModel.Pic = "~/Content/dist/img/Users_Image/" + filename; //Veritabanına adres kayıt
                filename = Path.Combine(Server.MapPath("~/Content/dist/img/Users_Image/"), filename); //serverdaki kayıt edilecek dosya dizin adresi
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

            return RedirectToAction(parametersEdit.FromRoute + "/" + parametersEdit.IslemTuru + "/" + generateId, parametersEdit.FromController);

        }
        #endregion


        #region Yetkilendirme Alanı
        [Route("Yetkilendirme")]
        public ActionResult Authorizantion_List()
        {

            var parametersEdit = new Authorization_List();

            //Test Veri Girşi
            var grplist = new List<AuthorizationModel>();
            var grpyetkilist = new List<DropDownModel>();

            AuthorizationModel grpdata = new AuthorizationModel();
            DropDownModel yetkidata = new DropDownModel();

            grpdata.Id = 1;
            grpdata.Name = "Admin";
            grpdata.Comment = "Tüm Alanlara Yetkilidir";

            yetkidata.Id = 11;
            yetkidata.Name="Teklif(OKU)";
            yetkidata.Code = "Y1";
            grpyetkilist.Add(yetkidata);

            yetkidata = new DropDownModel();
            yetkidata.Id = 12;
            yetkidata.Name="Teklif(SİL)";
            yetkidata.Code = "Y3";
            grpyetkilist.Add(yetkidata);

            yetkidata = new DropDownModel();
            yetkidata.Id = 13;
            yetkidata.Name="Teklif(GÜNCELLE)";
            yetkidata.Code = "Y2";
            grpyetkilist.Add(yetkidata);

            yetkidata = new DropDownModel();
            yetkidata.Id = 14;
            yetkidata.Name = "Proje(OKU)";
            yetkidata.Code = "Y1";
            grpyetkilist.Add(yetkidata);

            yetkidata = new DropDownModel();
            yetkidata.Id = 15;
            yetkidata.Name = "Proje(SİL)";
            yetkidata.Code = "Y3";
            grpyetkilist.Add(yetkidata);

            yetkidata = new DropDownModel();
            yetkidata.Id = 16;
            yetkidata.Name = "Proje(GÜNCELLE)";
            yetkidata.Code = "Y2";
            grpyetkilist.Add(yetkidata);

            grpdata.Authorizations = grpyetkilist;
            grplist.Add(grpdata);

            //_________2.Veri
            grpdata = new AuthorizationModel();
            grpyetkilist = new List<DropDownModel>();
            
            grpdata.Id = 2;
            grpdata.Name = "Proje";
            grpdata.Comment = "Proje Alanlarına Yetkilidir";

            yetkidata = new DropDownModel();
            yetkidata.Id = 14;
            yetkidata.Name = "Proje(OKU)";
            yetkidata.Code = "Y1";
            grpyetkilist.Add(yetkidata);

            yetkidata = new DropDownModel();
            yetkidata.Id = 15;
            yetkidata.Name = "Proje(SİL)";
            yetkidata.Code = "Y3";
            grpyetkilist.Add(yetkidata);

            yetkidata = new DropDownModel();
            yetkidata.Id = 16;
            yetkidata.Name = "Proje(GÜNCELLE)";
            yetkidata.Code = "Y2";
            grpyetkilist.Add(yetkidata);

            grpdata.Authorizations = grpyetkilist;

            grplist.Add(grpdata);

            //Test Veri Girişi ./

            parametersEdit.PrmGroup = grplist;

            //Kullanıcı bölümü için
            var userlist = new List<AuthorizationModel>();
            var useryetkilist = new List<DropDownModel>();

            var userdata = new AuthorizationModel();

            userdata.Id = 1;
            userdata.Name = "İsmail DEMİR";
            userdata.Comment = "Tüm Alanlara Yetkilidir";

            yetkidata = new DropDownModel();
            yetkidata.Id = 11;
            yetkidata.Name = "Teklif(OKU)";
            yetkidata.Code = "Y1";
            useryetkilist.Add(yetkidata);

            yetkidata = new DropDownModel();
            yetkidata.Id = 12;
            yetkidata.Name = "Teklif(SİL)";
            yetkidata.Code = "Y3";
            useryetkilist.Add(yetkidata);

            yetkidata = new DropDownModel();
            yetkidata.Id = 13;
            yetkidata.Name = "Teklif(GÜNCELLE)";
            yetkidata.Code = "Y2";
            useryetkilist.Add(yetkidata);

            userdata.Authorizations = useryetkilist;

            userlist.Add(userdata);

            parametersEdit.PrmUsers = userlist;

            parametersEdit.HeaderTitle = "YETKİLENDİRME LİSTELERİ";       //Fonksiyona göre değişir
            parametersEdit.FromController = "Admin";                     //Fonksiyona göre değişir
            parametersEdit.FromRoute = "YetkilendirmeEdit";     //Fonksiyona göre değişir


            return View(parametersEdit);
        }

        [Route("YetkilendirmeEdit")]
        public ActionResult Authorization_Edit()
        {
            var myBll = new UserAccessBll();   //Fonksiyona göre değişir
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
            parameters.HeaderTitle = "YETKİLENDİRME";       //Fonksiyona göre değişir
            parameters.FromController = "Admin";                     //Fonksiyona göre değişir
            parameters.FromRoute = "YetkilendirmeEdit";     //Fonksiyona göre değişir

            return View(parameters);
        }
        #endregion

        #region ADRES BÖLGE

        [Route("AdresBölge")]
        public ActionResult Address_List()
        {
            var myBll = new ZoneBll();   //##### Fonksiyona göre değişir
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
            parameters.HeaderTitle = "ADRES BÖLGE";       //##### Fonksiyona göre değişir
            parameters.FromController = "Admin";                     //##### Fonksiyona göre değişir
            parameters.FromRoute = "AdresBölgeEdit";     //##### Fonksiyona göre değişir

            return View(parameters);
        }

        [Route("AdresBölgeEdit/{islemturu}/{Id}")]
        [HttpGet]
        public ActionResult Address_Edit(IslemTuru islemturu, long Id)
        {
            var getBll = new ZoneBll(); //Fonksiyone göre değiştir

            var parametersEdit = new ParametersEdit();
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            parametersEdit = ViewFunction.ModelToParameterEdit(getData, Id, islemturu); //GET işlemi için

            parametersEdit.HeaderTitle = "ADRES BÖLGE"; //Fonksiyone göre değiştir
            parametersEdit.FromController = "Admin";        //Fonksiyone göre değiştir
            parametersEdit.FromRoute = "AdresBölgeEdit"; //Fonksiyone göre değiştir


            return View(parametersEdit);
        }
        [Route("AdresBölgeEdit")]
        [HttpPost]
        public ActionResult Address_Edit(ParametersEdit parametersEdit)
        {
            var getBll = new ZoneBll(); //Fonksiyone göre değiştir
            var myModel = new Zone();  //Fonksiyone göre değiştir

            ViewFunction.ParametersEditToModel(parametersEdit, myModel, getBll); //Post işlemi için

            return View(parametersEdit);
        }

        #endregion


        #region DEPARTMAN
        [Route("Departman")]
        public ActionResult Department_List()
        {
            var myBll = new UserDepartmentBll();   //##### Fonksiyona göre değişir
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
            parameters.HeaderTitle = "DEPARTMAN";       //##### Fonksiyona göre değişir
            parameters.FromController = "Admin";                     //##### Fonksiyona göre değişir
            parameters.FromRoute = "DepartmanEdit";     //##### Fonksiyona göre değişir

            return View(parameters);
        }

        [Route("DepartmanEdit/{islemturu}/{Id}")]
        [HttpGet]
        public ActionResult Department_Edit(IslemTuru islemturu, long Id)
        {
            var getBll = new UserDepartmentBll(); //Fonksiyone göre değiştir

            var parametersEdit = new ParametersEdit();
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            parametersEdit = ViewFunction.ModelToParameterEdit(getData, Id, islemturu); //GET işlemi için

            parametersEdit.HeaderTitle = "DEPARTMAN"; //Fonksiyone göre değiştir
            parametersEdit.FromController = "Admin";        //Fonksiyone göre değiştir
            parametersEdit.FromRoute = "DepartmanEdit"; //Fonksiyone göre değiştir


            return View(parametersEdit);
        }
        [Route("DepartmanEdit")]
        [HttpPost]
        public ActionResult Department_Edit(ParametersEdit parametersEdit)
        {
            var getBll = new UserDepartmentBll(); //Fonksiyone göre değiştir
            var myModel = new User_Department();  //Fonksiyone göre değiştir

            ViewFunction.ParametersEditToModel(parametersEdit, myModel, getBll); //Post işlemi için

            return View(parametersEdit);
        }

        #endregion

        #region YETKİ SEVİYELERİ

        [Route("YetkiSeviyeleri")]
        public ActionResult Authorizantion_Level_List()
        {
            var myBll = new UserAccessBll();   //##### Fonksiyona göre değişir
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
            parameters.HeaderTitle = "YETKİ SEVİYELERİ";       //##### Fonksiyona göre değişir
            parameters.FromController = "Admin";                     //##### Fonksiyona göre değişir
            parameters.FromRoute = "YetkiSeviyeleriEdit";     //##### Fonksiyona göre değişir

            return View(parameters);
        }

        [Route("YetkiSeviyeleriEdit/{islemturu}/{Id}")]
        [HttpGet]
        public ActionResult Authorizantion_Level_Edit(IslemTuru islemturu ,long Id)
        {
            var getBll = new UserAccessBll(); //Fonksiyone göre değiştir

            var parametersEdit = new ParametersEdit();
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            parametersEdit = ViewFunction.ModelToParameterEdit(getData, Id, islemturu); //GET işlemi için

            parametersEdit.HeaderTitle = "YETKİ SEVİYELERİ"; //Fonksiyone göre değiştir
            parametersEdit.FromController = "Admin";        //Fonksiyone göre değiştir
            parametersEdit.FromRoute = "YetkiSeviyeleriEdit"; //Fonksiyone göre değiştir


            return View(parametersEdit);
        }
        [Route("YetkiSeviyeleriEdit")]
        [HttpPost]
        public ActionResult Authorizantion_Level_Edit(ParametersEdit parametersEdit)
        {
            var getBll = new UserAccessBll(); //Fonksiyone göre değiştir
            var myModel = new User_Access();  //Fonksiyone göre değiştir

            ViewFunction.ParametersEditToModel(parametersEdit, myModel, getBll); //Post işlemi için

            return View(parametersEdit);
        }

        #endregion

        #region KEYWORD

        [Route("Keyword")]
        public ActionResult Keyword_List()
        {
            var myBll = new KeywordBll();   //##### Fonksiyona göre değişir
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
            parameters.HeaderTitle = "ANAHTAR KELİMELER";       //##### Fonksiyona göre değişir
            parameters.FromController = "Admin";                     //##### Fonksiyona göre değişir
            parameters.FromRoute = "KeywordEdit";     //##### Fonksiyona göre değişir

            return View(parameters);
        }

        [Route("KeywordEdit/{islemturu}/{Id}")]
        [HttpGet]
        public ActionResult Keyword_Edit(IslemTuru islemturu, long Id)
        {
            var getBll = new KeywordBll(); //Fonksiyone göre değiştir

            var parametersEdit = new ParametersEdit();
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            parametersEdit = ViewFunction.ModelToParameterEdit(getData, Id, islemturu); //GET işlemi için

            parametersEdit.HeaderTitle = "ANAHTAR KELİMELER"; //Fonksiyone göre değiştir
            parametersEdit.FromController = "Admin";        //Fonksiyone göre değiştir
            parametersEdit.FromRoute = "KeywordEdit"; //Fonksiyone göre değiştir


            return View(parametersEdit);
        }
        [Route("KeywordEdit")]
        [HttpPost]
        public ActionResult Keyword_Edit(ParametersEdit parametersEdit)
        {
            var getBll = new KeywordBll(); //Fonksiyone göre değiştir
            var myModel = new Keyword();  //Fonksiyone göre değiştir

            ViewFunction.ParametersEditToModel(parametersEdit, myModel, getBll); //Post işlemi için

            return View(parametersEdit);
        }

        #endregion

        #region PARA BİRİMİ

        [Route("ParaBirimi")]
        public ActionResult Currency_List()
        {
            var myBll = new CurrencyBll();   //##### Fonksiyona göre değişir
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
            parameters.HeaderTitle = "PARA BİRİMİ";       //##### Fonksiyona göre değişir
            parameters.FromController = "Admin";                     //##### Fonksiyona göre değişir
            parameters.FromRoute = "ParaBirimiEdit";     //##### Fonksiyona göre değişir

            return View(parameters);
        }

        [Route("ParaBirimiEdit/{islemturu}/{Id}")]
        [HttpGet]
        public ActionResult Currency_Edit(IslemTuru islemturu, long Id)
        {
            var getBll = new CurrencyBll(); //Fonksiyone göre değiştir

            var parametersEdit = new ParametersEdit();
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            parametersEdit = ViewFunction.ModelToParameterEdit(getData, Id, islemturu); //GET işlemi için

            parametersEdit.HeaderTitle = "PARA BİRİMİ"; //Fonksiyone göre değiştir
            parametersEdit.FromController = "Admin";        //Fonksiyone göre değiştir
            parametersEdit.FromRoute = "ParaBirimiEdit"; //Fonksiyone göre değiştir

            return View(parametersEdit);
        }
        [Route("ParaBirimiEdit")]
        [HttpPost]
        public ActionResult Currency_Edit(ParametersEdit parametersEdit)
        {
            var getBll = new CurrencyBll(); //Fonksiyone göre değiştir
            var myModel = new Currency();  //Fonksiyone göre değiştir

            ViewFunction.ParametersEditToModel(parametersEdit, myModel, getBll); //Post işlemi için

            return View(parametersEdit);
        }

        #endregion

    }
}