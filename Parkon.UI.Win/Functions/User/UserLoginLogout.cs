using Newtonsoft.Json.Linq;
using Prkn.Common.Variables;
using Prkn.Model;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Timers;
using Prkn.UI.Win.Functions;
using Prkn.Common.Functions;
using Prkn.Common.Enums;
using Prkn.Common;
using Prkn.Bll.Settings;
using Prkn.Bll.Master.PrknDataBll.User;
using System.Windows.Forms;
using Prkn.UI.Win.DBOrganizer;

namespace Prkn.UI.Win
{
    public static class UserLoginLogout
    {
        public static bool Login_FirstStart()
        {
            bool result;

            var RememberMe          = SettingsBll.GetRememberMe();

            if (RememberMe == "True")
            {
                var uName = SettingsBll.GetUname();
                var uPass = SettingsBll.GetUpass();

                CheckUser(uName, uPass, out CLS.UserLoginOK);

                if (CLS.UserLoginOK)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
        public static bool Login(string uName, string uPass, bool rememberMe)
        {
            bool result;

            CheckUser(uName, uPass, out CLS.UserLoginOK);

            if (CLS.UserLoginOK)
            {
                if (rememberMe)
                {
                    SettingsBll.PostRememberMe(rememberMe.ToString());
                    SettingsBll.PostUname(uName);
                    SettingsBll.PostUpass(uPass);
                }
                else
                {
                    ClearRememberMe();
                }

                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
        public static void Logout()
        {
            ClearRememberMe();
            CLS.UserLoginOK = false;
            GetUserDataForScreen(CLS.UserLoginOK);
            LeftMenu_SelectVisible(CLS.UserLoginOK);
        }

        static bool ClearRememberMe()
        {
            bool result = true;

            SettingsBll.PostRememberMe("");
            SettingsBll.PostUname("");
            SettingsBll.PostUpass("");


            return result;
        }
        static Model.Users CheckUser(string u, string p, out bool LoginOK)
        {
            Model.Users result  = null;
            UserBll userBll     = new UserBll();


            var userList = DataSelector.Get_UserList();
            var getData = userList.Where(x => x.UserName == u && x.Pass == p).FirstOrDefault();

            if (getData != null)
            {
                result          = getData;
                CLS.OnlineUser  = getData;

                LoginOK         = true;
                CLS.UserLoginOK = true;

                GetUserDataForScreen(LoginOK);
                LeftMenu_SelectVisible(LoginOK);
            }
            else
            {
                LoginOK = false;
            }

            return result;
        }
        static void LeftMenu_SelectVisible(bool LoginOK)
        {
            CLS.MainForm.GBMenu_Kullanici.Visible           = LoginOK;

            CLS.MainForm.btnProjeSorgula.Visible = LoginOK; //MyAuthorization.GizleGoster(UserScreen.ProjeSorgulama);
            CLS.MainForm.btnProjeOluştur.Visible = LoginOK; //MyAuthorization.GizleGoster(UserScreen.ProjeYeni);
            CLS.MainForm.btnRevOlustur.Visible = LoginOK; // MyAuthorization.GizleGoster(UserScreen.ProjeYeniRev);

            CLS.MainForm.GBMenu_Proje.Visible = LoginOK; //CLS.MainForm.btnProjeSorgula.Visible ||
                                                      //CLS.MainForm.btnProjeOluştur.Visible ||
                                                      //CLS.MainForm.btnRevOlustur.Visible ||
                                                      //CLS.MainForm.btnServisFormu.Visible;



            CLS.MainForm.GBMenu_Yönetici.Visible            = false; // MyAuthorization.GizleGoster(UserScreen.yonetim);
            CLS.MainForm.GBMenu_Otomasyon.Visible           = false; // MyAuthorization.GizleGoster(UserScreen.Otomasyon);
            CLS.MainForm.GBMenu_Ayarlar.Visible             = false; // MyAuthorization.GizleGoster(UserScreen.ProjeSorgulama);
            CLS.MainForm.GBMenu_Toplantilar.Visible         = false; //MyAuthorization.GizleGoster(UserScreen.Toplantilar);

            CLS.MainForm.GBMenu_Gorevler.Visible            = false; //MyAuthorization.GizleGoster(UserScreen.Gorevler);
         

            CLS.MainForm.btnServisFormu.Visible             = false; //MyAuthorization.GizleGoster(UserScreen.FormServis);

            CLS.MainForm.btnEgitimFormu.Visible             = false; //MyAuthorization.GizleGoster(UserScreen.FormEgitim);
            CLS.MainForm.btnProjeAraTeslim.Visible          = false; //MyAuthorization.GizleGoster(UserScreen.FormAraTeslim);
            CLS.MainForm.btnProjeSonTeslim.Visible          = false; //MyAuthorization.GizleGoster(UserScreen.FormSonTeslim);
            CLS.MainForm.GBMenu_Servis.Visible              = false; //CLS.MainForm.btnEgitimFormu.Visible ||
                                                                     //CLS.MainForm.btnProjeAraTeslim.Visible ||
                                                                     //CLS.MainForm.btnProjeSonTeslim.Visible;

            CLS.MainForm.btnSiparisOlustur.Visible          = false; //MyAuthorization.GizleGoster(UserScreen.TedarikYeni);
            CLS.MainForm.btnTedarikAyarlar.Visible          = false; //MyAuthorization.GizleGoster(UserScreen.TedarikAyarlar);
            CLS.MainForm.GBMenu_Tedarik.Visible             = false; //CLS.MainForm.btnTedarikAyarlar.Visible ||
                                                                //CLS.MainForm.btnSiparisOlustur.Visible;

            CLS.MainForm.btnTeklifOlustur.Visible           = false; //MyAuthorization.GizleGoster(UserScreen.TeklifYeni);
            CLS.MainForm.btnTeklifDuzelt.Visible            = false; //MyAuthorization.GizleGoster(UserScreen.TeklifDuzelt);
            CLS.MainForm.btnTeklifler.Visible               = false; //MyAuthorization.GizleGoster(UserScreen.TeklifSorgula);
            CLS.MainForm.btnTeklifAyarlar.Visible           = false; //MyAuthorization.GizleGoster(UserScreen.TeklifAyarlar);
            CLS.MainForm.GBMenu_Teklif.Visible              = false; //CLS.MainForm.btnTeklifler.Visible ||
                                                                    //CLS.MainForm.btnTeklifAyarlar.Visible;

            CLS.MainForm.btnTedarikciDuzenle.Visible        = false; //MyAuthorization.GizleGoster(UserScreen.TedarikciDuzenle);
            CLS.MainForm.btnTedarikciTuru.Visible           = false; //MyAuthorization.GizleGoster(UserScreen.TedarikciDuzenle);
            CLS.MainForm.btnTedarikciBolumDuzenle.Visible   = false; //MyAuthorization.GizleGoster(UserScreen.TedarikciDuzenle);
            CLS.MainForm.GBMenu_Tedarikci.Visible           = false; //CLS.MainForm.GBMenu_Tedarikci.Visible ||
                                                                //CLS.MainForm.btnTedarikciDuzenle.Visible ||
                                                                //CLS.MainForm.btnTedarikciTuru.Visible ||
                                                                //CLS.MainForm.btnTedarikciBolumDuzenle.Visible;


            CLS.MainForm.btnMusteriDuzenle.Visible          = false; //MyAuthorization.GizleGoster(UserScreen.MusteriDuzenle);
            CLS.MainForm.btnMusteriTuru.Visible             = false; //MyAuthorization.GizleGoster(UserScreen.MusteriDuzenle);
            CLS.MainForm.btnMusteriBolumDuzenle.Visible     = false; //MyAuthorization.GizleGoster(UserScreen.MusteriDuzenle);
            CLS.MainForm.GBMenu_Musteri.Visible             = false; //CLS.MainForm.btnMusteriDuzenle.Visible ||
                                                                //CLS.MainForm.btnMusteriTuru.Visible ||
                                                                //CLS.MainForm.btnMusteriBolumDuzenle.Visible;

            CLS.MainForm.btnStokUrunCikis.Visible           = false; //MyAuthorization.GizleGoster(UserScreen.StokCikisSorgula);
            CLS.MainForm.btnStokUrunGiris.Visible           = false; //MyAuthorization.GizleGoster(UserScreen.StokGiris);
            CLS.MainForm.btnStokUrunCikisAksiyon.Visible    = false; //MyAuthorization.GizleGoster(UserScreen.StokAyarlar);
            CLS.MainForm.btnStokVeriDuzenle.Visible         = false; //MyAuthorization.GizleGoster(UserScreen.StokAyarlar);
            CLS.MainForm.btnStokUrunTuru.Visible            = false; //MyAuthorization.GizleGoster(UserScreen.StokAyarlar);
            CLS.MainForm.btnStokUrunMarka.Visible           = false; //MyAuthorization.GizleGoster(UserScreen.StokAyarlar);
            CLS.MainForm.btnStokUrunGrubu.Visible           = false; //MyAuthorization.GizleGoster(UserScreen.StokAyarlar);
            CLS.MainForm.GBMenu_Stok.Visible                = false; //CLS.MainForm.btnStokUrunCikis.Visible ||
                                                                //CLS.MainForm.btnStokUrunGiris.Visible ||
                                                                //CLS.MainForm.btnStokUrunCikisAksiyon.Visible ||
                                                                //CLS.MainForm.btnStokVeriDuzenle.Visible ||
                                                                //CLS.MainForm.btnStokUrunTuru.Visible ||
                                                                //CLS.MainForm.btnStokUrunMarka.Visible ||
                                                                //CLS.MainForm.btnStokUrunGrubu.Visible;
        }
        static void GetUserDataForScreen(bool LoginOK)
        {
            if (LoginOK)
            {
                if ((CLS.OnlineUser != null))
                {
                    CLS.MainForm.GBMenu_Kullanici.Text  = CLS.OnlineUser.NameFirst + " " + CLS.OnlineUser.NameLast;
                    CLS.MainForm.btnUserLogin.Caption   = CLS.MainForm.GBMenu_Kullanici.Text;
                }
                else
                {
                    CLS.MainForm.GBMenu_Kullanici.Text = "User";
                    CLS.MainForm.btnUserLogin.Caption = "Login";
                }

            }
            else
            {
                CLS.MainForm.GBMenu_Kullanici.Text  = "User";
                CLS.MainForm.btnUserLogin.Caption   = "Login";
            }

        }

    }
}
