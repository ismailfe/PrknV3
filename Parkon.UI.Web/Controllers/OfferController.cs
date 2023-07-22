using Prkn.Model;
using Prkn.Bll.Master.PrknDataBll.Customer;
using Prkn.Bll.Master.PrknDataBll.General;
using Prkn.Bll.Master.PrknDataBll.Offer;
using Prkn.Bll.Master.PrknDataBll.User;
using Prkn.Common.Enums;
using Prkn.Common.Functions;
using Prkn.Common.Generate;
using Prkn.UI.Web.Functions;
using Prkn.UI.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace Prkn.UI.Web.Controllers
{
  //  [Authorize]
    [RoutePrefix("Teklif")]
    public class OfferController : Controller
    {
       
        public long Id { get; private set; }

        
        // GET: Teklif
        [Route("TeklifDuzenle/{islemturu}/{id}/{ver?}")]
        [HttpGet]
        public ActionResult Offer_Edit(IslemTuru islemTuru, long Id, int? ver=0)
        {
            var parametersEdit = new OfferEdit();//her view sayfasına göre oluşturacağımız sınıfımız

            if (islemTuru==IslemTuru.Insert || islemTuru == IslemTuru.Update || islemTuru==IslemTuru.Delete)//Burası zamanla bu hale geldi :) if komple kaldırılabilir
            {
                CustomerBll customerBll = new CustomerBll();
                OfferRequestSourceBll offerRequestSourceBll = new OfferRequestSourceBll();
                OfferRequestTypeBll offerRequestTypeBll = new OfferRequestTypeBll();
                OfferTypeBll offerTypeBll = new OfferTypeBll();
                OfferStatusBll offerStatusBll = new OfferStatusBll();
                CurrencyBll currencyBll = new CurrencyBll();

                parametersEdit.Customer = ViewFunction.DropDownModelFilling(customerBll).OrderBy(x=>x.Name).ToList();
                parametersEdit.OfferRequestSource = ViewFunction.DropDownModelFilling(offerRequestSourceBll);
                parametersEdit.OfferRequestType = ViewFunction.DropDownModelFilling(offerRequestTypeBll);
                parametersEdit.OfferType = ViewFunction.DropDownModelFilling(offerTypeBll);
                parametersEdit.OfferStatus = ViewFunction.DropDownModelFilling(offerStatusBll);
                parametersEdit.Currency = ViewFunction.DropDownModelFilling(currencyBll);
                

                parametersEdit.CustomerSection = new List<DropDownModel>();
                parametersEdit.PreparingType = new List<DropDownModel>();
                parametersEdit.CustomerContact = new List<DropDownModel>();

                //Default olarak Seçilsinler
                //     parametersEdit.Prm.OfferStatusId = parametersEdit.OfferStatus[0].Id;
                //   TempData["OfferStatusId"]= parametersEdit.OfferStatus[0].Id;
                //Default son

                //---Hazırlama modu için Yeni veya Versiyon
                //parametersEdit.PreparingType = ViewFunction.PreparingTypeFilling();
                //parametersEdit.PreparingTypeId = 1;
                //Hazırlama modu oluşturma bitiş 

                //Güncel Döviz Verilerini Merkez Banaksından Çekiyoruz
                decimal dolar=0, euro=0;
                try
                {
                    XmlDocument xmlVerisi = new XmlDocument();
                    xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
                    dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                    euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));

                    XmlNode tarih = xmlVerisi.SelectSingleNode("/Tarih_Date/@Date");

                    string exchangeratedate = tarih.InnerText.ToString();
                    DateTime oDate = Convert.ToDateTime(exchangeratedate);
                    //     parametersEdit.Prm.ExchangeRateDate = oDate;

                    //        ViewBag.Exchangeratedate = oDate.Date;

                    //--
                }
                catch (Exception)
                {

                }
                parametersEdit.DolarTL = Convert.ToDouble(dolar);
                parametersEdit.EuroTL = Convert.ToDouble(euro);

            }
            if (islemTuru==IslemTuru.Update || islemTuru==IslemTuru.Delete)
            {
                //Burda gelen ID ye göre verileri çekip ilgili alanları dolduracaz
                //Dropdownlistler için bütün listeyi çekip iligli olanı seçili getirmeliyiz
                //Bu sayede Referans No, Teklif Kodu ve Versiyon bilgilerinide doldurabiliriz

                OfferBll getBll = new OfferBll();
                Offers myModel = new Offers();

                var getData = getBll.GetSingle(x => x.Id == Id, x => x);

                if (getData != null)
                { 
                    parametersEdit.Prm = new Offers();
                    // parametersEdit.PreparingType = ViewFunction.PreparingTypeFilling();
                    parametersEdit.Prm.Id = getData.Id;
                    parametersEdit.Prm.CustomerId = getData.CustomerId;
                    parametersEdit.Prm.CustomerSectionId = getData.CustomerSectionId;
                    parametersEdit.Prm.CustomerContactId = getData.CustomerContactId;
                    parametersEdit.Prm.OfferTypeId = getData.OfferTypeId;
                    parametersEdit.Prm.OfferRequestTypeId = getData.OfferRequestTypeId;
                    parametersEdit.Prm.OfferRequestSourceId = getData.OfferRequestSourceId;
                    parametersEdit.Prm.OfferStatusId = getData.OfferStatusId;
                    parametersEdit.Prm.Comment = getData.Comment;
                  //  parametersEdit.Prm.CreateDate = getData.CreateDate;
                    parametersEdit.Prm.PreparationDate = getData.PreparationDate; ///Bunu neden çekemiyoruz bir bak
                    parametersEdit.Prm.ValidityPeriodWeek = getData.ValidityPeriodWeek;
                    parametersEdit.Prm.Name = getData.Name;
                    parametersEdit.Prm.Price = getData.Price;
                    parametersEdit.Prm.TargetCost = getData.TargetCost;
                    parametersEdit.Prm.RealCost = getData.RealCost;
                    parametersEdit.Prm.Keyword = getData.Keyword;
                    parametersEdit.Prm.CurrencyId = getData.CurrencyId;
                    parametersEdit.Prm.RefNo = getData.RefNo;
                    parametersEdit.Prm.Code = getData.Code;
                    parametersEdit.Prm.VerCode = getData.VerCode;
                   // parametersEdit.PreparingTypeId = 2;
                    parametersEdit.Prm.ExchangeRate = getData.ExchangeRate;
                    parametersEdit.Prm.ExchangeRateDate = getData.ExchangeRateDate;

                    //--script ile doldurulan DropdownListler için
                    CustomerSectionBll customerSectionBll = new CustomerSectionBll();

                    //      parametersEdit.CustomerSection = ViewFunction.DropDownModelFilling(customerSectionBll, "CustomerId", parametersEdit.Prm.CustomerId);
                    parametersEdit.CustomerSection = ViewFunction.DropDownModelFilling(customerSectionBll, "CustomerId", (long)getData.CustomerId);
                    //Customer Contactı doldurmak için bir fonksiyon yazdım gerekirse başka DDL içinde revizyon yaparız
                    parametersEdit.CustomerContact = ViewFunction.CustomerContact_DDLFilling((long)parametersEdit.Prm.CustomerId);

                    //--script ile doldurulan DropdownListler için

                    //Versiyon V ise B yi seçemesin diye koşul
                    if (ver==1 && ViewFunction.GetRequestTypeCode(getData.OfferRequestTypeId)=="V")
                    {
                        parametersEdit.disabled = "true";
                        parametersEdit.OfferRequestType.RemoveAt(0);
                    }
                    else
                    {
                        parametersEdit.disabled = "false";
                    }
                }
            }   
            //---Hangi Modalı ekran göstereceğimizi belirliyoruz
            parametersEdit.ModalStatus = ViewFunction.modalstatus;
            ViewFunction.modalstatus = null;

            if (parametersEdit.ModalStatus == "insert")
            {
                parametersEdit.ModalMessage = "Teklifiniz Başarılı Bir Şekilde Oluşturulmuştur...("+ DateTime.Now+")";
                parametersEdit.ModalTitle = "KAYIT";
            }
            else if (parametersEdit.ModalStatus == "delete")
            {
                parametersEdit.ModalMessage = "Teklifiniz Silinmiştir...(" + DateTime.Now + ")";
                parametersEdit.ModalTitle = "SİLME";
            }
            else if (parametersEdit.ModalStatus == "update" && ver==0)
            {
                parametersEdit.ModalMessage = "Teklifiniz Başarılı Bir Şekilde Güncelleştirilmiştir...(" + DateTime.Now + ")";
                parametersEdit.ModalTitle = "GÜNCELLEME";
            }
            else if (parametersEdit.ModalStatus == "update" && ver == 1) //ver=1 ise yeni versiyon olacak
            {
                parametersEdit.ModalMessage = "Yeni Versiyonunuz Başarılı Bir Şekilde Oluşturulmuştur...(" + DateTime.Now + ")";
                parametersEdit.ModalTitle = "VERSİYON OLUŞTURMA";
            } 

            // Versiyon işleri
            if (ver==1)
            {
                parametersEdit.Versiyon = (int)ver;//bu değer 1 ise yeni versiyon olacak

              //  parametersEdit.IslemTuru = IslemTuru.Insert; //Yeni Versiyon farklı kayıt olarak oluşacak
            }
            else
            {
                parametersEdit.IslemTuru = islemTuru;
            }
            //

            ViewFunction.modalstatus = null;
            //-----   
            switch (islemTuru)
            {
                case IslemTuru.Insert:
                    parametersEdit.HeaderTitle = "TEKLİF OLUŞTUR";
                    break;
                case IslemTuru.Update:
                    parametersEdit.HeaderTitle = "TEKLİF GÜNCELLE";
                    break;
                case IslemTuru.Delete:
                    parametersEdit.HeaderTitle = "TEKLİF SİL";
                    break;
                default:
                    parametersEdit.HeaderTitle = " ";
                    break;
            }

            parametersEdit.FromController = "Teklif";
            parametersEdit.FromRoute = "TeklifDuzenle";

            return View(parametersEdit);
        }
        [Route("TeklifDuzenle")]
        [HttpPost]
        public ActionResult Offer_Edit(OfferEdit parametersEdit)
        {
            //--Model ve Model Tanımlama
            var getBll = new OfferBll();
            var myModel = new Offers();
            //-----
            if (parametersEdit.Versiyon == 1)
            {
                //Fonksiyon Buraya gelecek
                bool sonuc = ViewFunction.SetOfferActive(parametersEdit.Prm.Id, "");
             //   parametersEdit.IslemTuru = IslemTuru.Insert;
            }

            parametersEdit.Prm.VerCode = ViewFunction.CreateVerCode(parametersEdit.IslemTuru, parametersEdit.Versiyon, parametersEdit.Prm.OfferRequestTypeId, parametersEdit.Prm.Code, parametersEdit.Prm.VerCode);       
            parametersEdit.Prm.ResultDate = ViewFunction.GetResultDate(parametersEdit.Prm.OfferStatusId); //Sonuçlanmışsa sonuç tarihi çek yoksa null
            parametersEdit.Prm.Active = ViewFunction.GetActive(parametersEdit.IslemTuru, parametersEdit.Versiyon, parametersEdit.Prm.ResultDate); //Sonuçlandı işlemi yapılıncı da null olacak
            parametersEdit.Prm.Code = ViewFunction.CreateCode(parametersEdit.IslemTuru,parametersEdit.Prm.Code,parametersEdit.Versiyon, parametersEdit.Prm.PreparationDate);
            parametersEdit.Prm.RefNo = Generator.CreateRefNo(parametersEdit.IslemTuru,parametersEdit.Prm.RefNo);

            //---
            IslemTuru IslemTuruForId;
            if (parametersEdit.Versiyon == 1)
            {
                IslemTuruForId = IslemTuru.Insert;
            }
            else
            {
                IslemTuruForId = parametersEdit.IslemTuru;
            }

            long generateId= Generator.CreateId(IslemTuruForId, parametersEdit.Prm.Id);
            myModel.Id = generateId;
            myModel.CustomerId = parametersEdit.Prm.CustomerId;
            myModel.CustomerSectionId = parametersEdit.Prm.CustomerSectionId;
            myModel.CustomerContactId = parametersEdit.Prm.CustomerContactId;
            myModel.OfferTypeId = parametersEdit.Prm.OfferTypeId;
            myModel.OfferRequestTypeId = parametersEdit.Prm.OfferRequestTypeId;
            myModel.OfferRequestSourceId = parametersEdit.Prm.OfferRequestSourceId;
            myModel.OfferStatusId = parametersEdit.Prm.OfferStatusId;
            myModel.Comment = parametersEdit.Prm.Comment;
            myModel.PreparationDate = parametersEdit.Prm.PreparationDate; //bunu okuyamadı
            myModel.ValidityPeriodWeek = parametersEdit.Prm.ValidityPeriodWeek;
            myModel.Name = parametersEdit.Prm.Name;
            myModel.Price = parametersEdit.Prm.Price;
            myModel.TargetCost = parametersEdit.Prm.TargetCost;
            myModel.RealCost = parametersEdit.Prm.RealCost;
            myModel.Keyword = parametersEdit.Prm.Keyword;
            myModel.CurrencyId = parametersEdit.Prm.CurrencyId;
            myModel.ExchangeRateDate = parametersEdit.Prm.ExchangeRateDate;
            myModel.ExchangeRate = parametersEdit.Prm.ExchangeRate;
            myModel.Active = parametersEdit.Prm.Active;
            myModel.VerCode = parametersEdit.Prm.VerCode;
            myModel.ResultDate = parametersEdit.Prm.ResultDate;
            myModel.Code = parametersEdit.Prm.Code;
       //     myModel.CreateDate = parametersEdit.Prm.CreateDate;
            myModel.RefNo = parametersEdit.Prm.RefNo;
            myModel.UserId = (long)Session["UserId"]; //Burda login işleminde çektiğimiz UserID

            //--
            //Burda Sonuçlandı işlemi için resultdate ekleyecez ve aktive sütununa kapalı yazacaz yapacaz
            //--

            //---
            if (parametersEdit.IslemTuru == IslemTuru.Insert || parametersEdit.Versiyon==1)
            {
                parametersEdit.JobStatus = DateTime.Now + " - Teklif Oluşturuldu " + getBll.Insert(myModel);
                parametersEdit.IslemTuru = IslemTuru.Update;
                ViewFunction.modalstatus = "insert"; 
                if (parametersEdit.Versiyon==1)
                {
                    ViewFunction.modalstatus = "update"; //çünkü sayfaya döndüğünde veriyon modalı gelsin
                }
            }
            else if (parametersEdit.IslemTuru == IslemTuru.Update)
            {
                parametersEdit.JobStatus = DateTime.Now + " - Teklif Düzenleme işlemi " + getBll.Update(myModel);
                ViewFunction.modalstatus = "update";
            }

            else if (parametersEdit.IslemTuru == IslemTuru.Delete)
            {
                parametersEdit.JobStatus = DateTime.Now + " - Teklif silme işlemi " + getBll.DeleteSoft(myModel);
                ViewFunction.modalstatus = "delete";
            }
            //----
            //Burda ekleme işlemi yapıldıktan sonra sayfaya eklenen kayıtın ıd si döndürülerek Offeredit GET metodunda düzenleme olarak tekrar açacağız
            //Böylelikle oluşturulan ref no versiyon no teklif kodu verilerini sayfaya göndererek açabileceğiz
           // return View(Url.Action("TeklifDuzenle/"+IslemTuru.Update+"/"+generateId,"Teklif"));
            return RedirectToAction("TeklifDuzenle/" + parametersEdit.IslemTuru + "/" + generateId+"/"+parametersEdit.Versiyon, "Teklif");
        }

            // id si verilen müşterinin bölümlerini Json formatında döndürür
        [Route("CustomerSectionForDdl/{id}")]
        public JsonResult Select_CustomerSection(long id)
        {
            CustomerSectionBll customerSectionBll = new CustomerSectionBll();

            var getData = ViewFunction.DropDownModelFilling(customerSectionBll, "CustomerId", id).OrderBy(x=>x.Name).ToList();

            //Bu method sadece long ıd yi string ıd  yapabilmek için yazıld. Çünkü java eksik yazıyor long değerini
            var DDLJson = ViewFunction.DDLFillingJson(getData);

            return Json(DDLJson, JsonRequestBehavior.AllowGet);
        }

        // id si verilen Şirkete bağlı çalışanların isim ve soyisimlerini Json formatında döndürür
        [Route("CustomerContactForDdl/{id}")]
        public JsonResult Select_CustomerContact(long id)
        {
            //Bu method müşteri kişilerini liste olarak çekip gönderiyor. CustomerId parametre
            var getData = ViewFunction.CustomerContact_DDLFilling(id).OrderBy(x => x.Name).ToList();

            //Bu method sadece long ıd yi string ıd  yapabilmek için yazıld. Çünkü java eksik yazıyor long değerini
            var DDLJson = ViewFunction.DDLFillingJson(getData);

    //       var result=Json(getData, JsonRequestBehavior.AllowGet);

            return Json(DDLJson, JsonRequestBehavior.AllowGet);
        }

        [Route("OfferModalReadData/{id}")]
        public JsonResult Modal_ReadData(long Id)
        {
            var getBll = new OfferBll();

            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            return Json(getData, JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult Upload_File()
        {
            return View();
        }

        [Route("TeklifListele/{list1?}")] 
        //list1=1 ise sonuçlanmış teklifleride getir 
        //list1=2 ise tüm listeyi geti versiyonlar dahil
        public ActionResult Offer_List(int? list1=0)
        {
           
            var myBll = new OfferBll();
            var list = myBll.ListRefresh().OrderByDescending(x => x.PreparationDate).ToList();
            //  var a = list[13].Offer_Status.Name;

            var parameters = new OfferList();

            var offerstatusList = new List<DropDownModel>();
            var offertypeList = new List<DropDownModel>();
            var Veri_analiz_offerstatusList = new List<DropDownModel>();
            var currencyList = new List<DropDownModel>();
            var usersList = new List<DropDownModel>();
            var customersectionList = new List<DropDownModel>();
            var customerList = new List<DropDownModel>();
            int unactive = 0, closed=0; //versiyonu olan ve silinen kayıtları toplam kayıttan çıkarmak için
            

            var myPrmList = new List<Offers>();
            for (int i = 0; i < list.Count; i++)
            {
                Offers prm = new Offers();
                prm.Id = list[i].Id;
                prm.Code = list[i].Code;
                prm.VerCode = list[i].VerCode;
                prm.Name = list[i].Name;
                
                prm.PreparationDate = list[i].PreparationDate;

                
                /*
                if (list[i].CreateDate == null) //Güncelleme yapılınca tabloda createdate null oluyor bu nedenle koşul ekledik
                {
                    prm.CreateDate = list[i].UpdateDate;
                }
                else
                {
                    prm.CreateDate = list[i].CreateDate;
                }
                */
                prm.ResultDate = list[i].ResultDate;
                prm.RealCost = list[i].RealCost;
                prm.TargetCost = list[i].TargetCost;
                prm.Price = list[i].Price;
                prm.Active = list[i].Active;

                //Sadece aktif kayıtları getirmemek için koşul ekledim
                if (list[i].Active == "true" || list1==2) //list1=2 olursa tüm offers listesini çeksin
                {
                    myPrmList.Add(prm);
                    //farklı tablolardaki verileri getiren bölüm
                    offerstatusList.Add(ViewFunction.getOfferStatus((long)list[i].OfferStatusId));
                    offertypeList.Add(ViewFunction.getOfferType((long)list[i].OfferTypeId));
                    currencyList.Add(ViewFunction.getCurrency((long)list[i].CurrencyId));
                    usersList.Add(ViewFunction.getUser((long)list[i].UserId));
                    customersectionList.Add(ViewFunction.getCustomerSection((long)list[i].CustomerSectionId));
                    customerList.Add(ViewFunction.getCustomer((long)list[i].CustomerId));
                    //--
                    Veri_analiz_offerstatusList.Add(ViewFunction.getOfferStatus((long)list[i].OfferStatusId));
                }
                else
                {
                    unactive = unactive + 1;
                }
                //###############----
                //Burda sonuçlanmış teklifleri çekiyoruz
                if (list[i].ResultDate != null)
                {
                    closed = closed + 1;
                    Veri_analiz_offerstatusList.Add(ViewFunction.getOfferStatus((long)list[i].OfferStatusId));
                    //list1=1 yada 3  yada 4 ise burda ekleyelim döndünde çıkınca parametreye atamadan önce ayıklayacam
                    if (list1 == 1 || list1==3 || list1==4)
                    {
                        myPrmList.Add(prm);
                        //farklı tablolardaki verileri getiren bölüm
                        offerstatusList.Add(ViewFunction.getOfferStatus((long)list[i].OfferStatusId));
                        offertypeList.Add(ViewFunction.getOfferType((long)list[i].OfferTypeId));
                        currencyList.Add(ViewFunction.getCurrency((long)list[i].CurrencyId));
                        usersList.Add(ViewFunction.getUser((long)list[i].UserId));
                        customersectionList.Add(ViewFunction.getCustomerSection((long)list[i].CustomerSectionId));
                        customerList.Add(ViewFunction.getCustomer((long)list[i].CustomerId));
                    }
                }
                
            }

            //----- Teklif Durumlarının Bilgilendirme Alanı İçin
            int totaloffer = 0, preparing = 0, waitingreply = 0;
            double success = 0, negative = 0, other=0;
            totaloffer = list.Count- unactive +closed;
            
            for (int i = 0; i < Veri_analiz_offerstatusList.Count; i++)
            {
                switch (Veri_analiz_offerstatusList[i].Name)
                {
                    case "HAZIRLANIYOR":
                        preparing = preparing + 1;
                        break;
                    case "MUSTERIDE":
                        waitingreply = waitingreply + 1;
                        break;
                    case "SONUCLANDI : OLUMLU":
                        success = success + 1;
                        break;
                    case "SONUCLANDI : OLUMSUZ":
                        negative = negative + 1;
                        break;
                    case "SONUCLANDI : IPTAL":
                        negative = negative + 1;
                        break;
                    default:
                        other = other + 1;
                        break;
                }
            }
            parameters.OfferCount = totaloffer;
            parameters.OfferSuccessCount = (int)success;
            parameters.OfferPreparationCount = preparing;
            parameters.OfferWaitingreplyCount = waitingreply;
            parameters.OfferNegativeCount = (int)negative;
            parameters.OfferOtherResultCount = (int)other;
            //buraya özel kod
            if (success==0)
            {
                success = 1; // bölmede hata almamak için
            }
            parameters.OfferAcceptenceRate = Math.Round(((success / (success + negative + other)) * 100),1);
            parameters.OfferNegativeRate = Math.Round(((negative / (success + negative + other)) * 100), 1);
            parameters.OfferOtherResultRate= Math.Round(((other / (success + negative + other)) * 100), 1);
            //----  Üst Bilgilendirme Alanı Son

            //Tablodaki hangi sütunların gösterilmesi gerektiğini belirlemek için
            parameters.TableMode = list1; //0 ise sonuç tarihi gösterilmesin
            //3 ise sadece olumlular gösterilsin
            //4 ise sadece olumsuzlar gösterilsin
            if (list1 == 3 || list1 == 4)
            {
                //Bu aşamaya girilmişse olumlular yada olumsuzlar listelenecek

                int sayac = offerstatusList.Count;
                bool listekaydımı = false;
                for (int i = 0; i < sayac; i++)//Burda herhangi bir listenin adedi işimizi görür
                {
                    //Liste kaydıysa listeyi geri çekiyoruz
                    if (listekaydımı)
                    {
                        sayac = sayac - 1;
                        i = i - 1;
                    }
                    listekaydımı = false;
                    //-

                    if (list1 == 3 && offerstatusList[i].Name != "SONUCLANDI : OLUMLU")//olumlu olanlar
                    {
                        //olumlu olmayanlar listeden çıksın
                        offerstatusList.RemoveAt(i);
                        offertypeList.RemoveAt(i);
                        currencyList.RemoveAt(i);
                        usersList.RemoveAt(i);
                        customersectionList.RemoveAt(i);
                        customerList.RemoveAt(i);
                        myPrmList.RemoveAt(i);
                        listekaydımı = true;
                    }
                    else if (list1 == 4 && (offerstatusList[i].Name == "SONUCLANDI : OLUMLU" || offerstatusList[i].Name == "MUSTERIDE" || offerstatusList[i].Name == "HAZIRLANIYOR"))
                    {
                        //olumsuz olmayanlar listeden çıksın
                        offerstatusList.RemoveAt(i);
                        offertypeList.RemoveAt(i);
                        currencyList.RemoveAt(i);
                        usersList.RemoveAt(i);
                        customersectionList.RemoveAt(i);
                        customerList.RemoveAt(i);
                        myPrmList.RemoveAt(i);
                        listekaydımı = true;
                    }
                }
            }
            parameters.Offer_Status = offerstatusList;
            parameters.Offer_Type = offertypeList;
            parameters.Currency = currencyList;
            parameters.Users = usersList;
            parameters.Customer_Section = customersectionList;
            parameters.Customers = customerList;
            
            parameters.Prm = myPrmList;
            parameters.HeaderTitle = "TEKLİF LİSTELE";       //Fonksiyona göre değişir
            parameters.FromController = "Teklif";                     //Fonksiyona göre değişir
            parameters.FromRoute = "TeklifDuzenle";     //Fonksiyona göre değişir

            return View(parameters);
        }

        [Route("TeklifTurleri")]
        public ActionResult Offer_Type_List()
        {
            var myBll                       = new OfferTypeBll();   //##### Fonksiyona göre değişir
            var list                        = myBll.ListRefresh();

            var myPrmList = new List<Prm>();
            for (int i = 0; i < list.Count; i++)
            {
                Prm prm = new Prm();
                prm.Id          = list[i].Id;
                prm.Name        = list[i].Name;
                prm.Code        = list[i].Code;
                prm.Comment     = list[i].Comment;
                myPrmList.Add(prm);
            }

            var parameters          = new ParametersList();
            parameters.Prm          = myPrmList;
            parameters.HeaderTitle      = "TEKLİF TÜRLERİ";       //##### Fonksiyona göre değişir
            parameters.FromController   = "Teklif";                     //##### Fonksiyona göre değişir
            parameters.FromRoute        = "TeklifTurleriEdit";     //##### Fonksiyona göre değişir

            return View(parameters);
        }

        [Route("TeklifTurleriEdit/{islemturu}/{Id}")]
        [HttpGet]
        public ActionResult Offer_Type_Edit(long Id, IslemTuru islemturu)
        {
            var getBll = new OfferTypeBll();

            var parametersEdit = new ParametersEdit();
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            parametersEdit = ViewFunction.ModelToParameterEdit(getData, Id, islemturu); //GET işlemi için

            parametersEdit.HeaderTitle      = "TEKLİF TÜRLERİ";
            parametersEdit.FromController   = "Teklif";
            parametersEdit.FromRoute        = "TeklifTurleriEdit";

           
            return View(parametersEdit);
        }

        [Route("TeklifTurleriEdit")]
        [HttpPost]
        public ActionResult Offer_Type_Edit(ParametersEdit parametersEdit)
        {
            var getBll              = new OfferTypeBll();
            var myModel             = new Offer_Type();

            ViewFunction.ParametersEditToModel(parametersEdit, myModel, getBll);

            return View(parametersEdit);
        }

        #region TEKLİF TALEP TÜRLERi
        [Route("TeklifTalepTurleri")]
        public ActionResult Offer_Request_Type_List()
        {
            var myBll                       = new OfferRequestTypeBll();   //##### Fonksiyona göre değişir
            var list                        = myBll.ListRefresh();

            var myPrmList = new List<Prm>();
            for (int i = 0; i < list.Count; i++)
            {
                Prm prm = new Prm();
                prm.Id          = list[i].Id;
                prm.Name        = list[i].Name;
                prm.Code        = list[i].Code;
                prm.Comment     = list[i].Comment;
                myPrmList.Add(prm);
            }

            var parameters          = new ParametersList();
            parameters.Prm          = myPrmList;
            parameters.HeaderTitle      = "TEKLİF TALEP TÜRLERİ";       //##### Fonksiyona göre değişir
            parameters.FromController   = "Teklif";                     //##### Fonksiyona göre değişir
            parameters.FromRoute        = "TeklifTalepTurleriEdit";     //##### Fonksiyona göre değişir

            return View(parameters);
        }


        [Route("TeklifTalepTurleriEdit/{islemturu}/{Id}")] //sondaki uzantı sabit bir yerden çekilecek
        [HttpGet]
        public ActionResult Offer_Request_Type_Edit(long Id, IslemTuru islemturu)
        {
            var getBll = new OfferRequestTypeBll(); //##### Fonksiyona göre değişir

            var getData = getBll.GetSingle(x => x.Id == Id, x => x);
            //----
            //ModelToParamterEdit buraya harici fonksiyon gelecek

            var parametersEdit = new ParametersEdit();
            parametersEdit = ViewFunction.ModelToParameterEdit(getData, Id, islemturu); //GET işlemi için


            parametersEdit.HeaderTitle = "TEKLİF TALEP TÜRLERİ";    //##### Fonksiyona göre değişir
            parametersEdit.FromController = "Teklif";               //##### Fonksiyona göre değişir
            parametersEdit.FromRoute = "TeklifTalepTurleriEdit";    //##### Fonksiyona göre değişir

            return View(parametersEdit);
        }

        [Route("TeklifTalepTurleriEdit")]
        [HttpPost]
        public ActionResult Offer_Request_Type_Edit(ParametersEdit parametersEdit)
        {         
            var getBll          = new OfferRequestTypeBll(); //##### Fonksiyona göre değişir
            var myModel         = new Offer_RequestType(); //##### Fonksiyona göre değişir

            //Burada tanımladığımız harici fonksiyon ile sürekli tekrar eden kod bloğundan kurtulmuş olduk
            //artık sadece ParametersEditToModel metodunu çağırarak aynı işi yaptırabiliriz

            ViewFunction.ParametersEditToModel(parametersEdit, myModel, getBll); //Http POST için

            return View(parametersEdit);
        }
        #endregion

        #region TEKLİF TALEP KAYNAKLARI
        [Route("TeklifTalepKaynaklari")]
        public ActionResult Offer_Request_Source_List()
        {
            var myBll = new OfferRequestSourceBll();   //##### Fonksiyona göre değişir
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
            parameters.HeaderTitle = "TEKLİF TALEP KAYNAKLARI";       //##### Fonksiyona göre değişir
            parameters.FromController = "Teklif";                     //##### Fonksiyona göre değişir
            parameters.FromRoute = "TeklifTalepKaynaklariEdit";     //##### Fonksiyona göre değişir

            return View(parameters);
        }

        [Route("TeklifTalepKaynaklariEdit/{islemturu}/{Id}")]
        [HttpGet]
        public ActionResult Offer_Request_Source_Edit(long Id, IslemTuru islemturu)
        {
            var getBll = new OfferRequestSourceBll();
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            var parametersEdit = new ParametersEdit();
            parametersEdit = ViewFunction.ModelToParameterEdit(getData, Id, islemturu); //GET işlemi için

            parametersEdit.HeaderTitle = "TEKLİF TALEP KAYNAKLARI";
            parametersEdit.FromController = "Teklif";
            parametersEdit.FromRoute = "TeklifTalepKaynaklariEdit";

            return View(parametersEdit);
        }
        [Route("TeklifTalepKaynaklariEdit")]
        [HttpPost]
        public ActionResult Offer_Request_Source_Edit(ParametersEdit parametersEdit)
        {
            var getBll = new OfferRequestSourceBll();
            var myModel = new Offer_RequestSource();

            ViewFunction.ParametersEditToModel(parametersEdit, myModel, getBll); //Post işlemi için

            return View(parametersEdit);
        }

        #endregion

        #region TEKLİF DURUMLARI
        [Route("TeklifDurumlari")]
        public ActionResult Offer_Status_List()
        {
            var myBll = new OfferStatusBll();   //##### Fonksiyona göre değişir
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
            parameters.HeaderTitle = "TEKLİF DURUMLARI";       //##### Fonksiyona göre değişir
            parameters.FromController = "Teklif";                     //##### Fonksiyona göre değişir
            parameters.FromRoute = "TeklifDurumlariEdit";     //##### Fonksiyona göre değişir

            return View(parameters);
        }

        [Route("TeklifDurumlariEdit/{islemturu}/{Id}")]
        [HttpGet]
        public ActionResult Offer_Status_Edit(long Id, IslemTuru islemturu)
        {
            var getBll = new OfferStatusBll(); //Fonksiyone göre değiştir
            
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            var parametersEdit = new ParametersEdit();

            parametersEdit = ViewFunction.ModelToParameterEdit(getData, Id, islemturu); //GET işlemi için

            parametersEdit.HeaderTitle = "TEKLİF DURUMLARI"; //Fonksiyone göre değiştir
            parametersEdit.FromController = "Teklif";        //Fonksiyone göre değiştir
            parametersEdit.FromRoute = "TeklifDurumlariEdit"; //Fonksiyone göre değiştir


            return View(parametersEdit);
        }
        [Route("TeklifDurumlariEdit")]
        [HttpPost]
        public ActionResult Offer_Status_Edit(ParametersEdit parametersEdit)
        {
            var getBll = new OfferStatusBll(); //Fonksiyone göre değiştir
            var myModel = new Offer_Status();  //Fonksiyone göre değiştir

            ViewFunction.ParametersEditToModel(parametersEdit, myModel, getBll); //Post işlemi için

            return View(parametersEdit);
        }
        #endregion
    }
}