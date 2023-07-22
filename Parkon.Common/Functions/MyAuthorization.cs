using Prkn.Common.Enums;
using Prkn.Common.Variables;
using Prkn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.Common.Functions
{
    public static class MyAuthorization
    {
        private static User_Authorization _userAuthorization;
        private static List<User_Access>         _userAccess;

        public static UserAccess Control(UserScreen userScreen)
        {
            UserAccess result = new UserAccess();

            switch (userScreen)
            {
                case UserScreen.yonetim:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C0.ToString(), out result);
                    break;
                case UserScreen.Toplantilar:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C1.ToString(), out result);
                    break;
                case UserScreen.Gorevler:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C2.ToString(), out result);
                    break;
                case UserScreen.ProjeSorgulama:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C3.ToString(), out result);
                    break;
                case UserScreen.ProjeYeni:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C4.ToString(), out result);
                    break;
                case UserScreen.ProjeYeniRev:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C5.ToString(), out result);
                    break;
                case UserScreen.FormServis:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C6.ToString(), out result);
                    break;
                case UserScreen.FormEgitim:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C7.ToString(), out result);
                    break;
                case UserScreen.FormAraTeslim:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C8.ToString(), out result);
                    break;
                case UserScreen.FormSonTeslim:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C9.ToString(), out result);
                    break;
                case UserScreen.TeklifSorgula:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C10.ToString(), out result);
                    break;
                case UserScreen.TeklifYeni:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C11.ToString(), out result);
                    break;
                case UserScreen.TeklifAyarlar:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C12.ToString(), out result);
                    break;
                case UserScreen.TedarikSorgula:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C13.ToString(), out result);
                    break;
                case UserScreen.TedarikYeni:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C14.ToString(), out result);
                    break;
                case UserScreen.TedarikAyarlar:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C15.ToString(), out result);
                    break;
                case UserScreen.StokSorgula:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C16.ToString(), out result);
                    break;
                case UserScreen.StokGiris:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C17.ToString(), out result);
                    break;
                case UserScreen.StokCikis:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C18.ToString(), out result);
                    break;
                case UserScreen.StokCikisSorgula:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C19.ToString(), out result);
                    break;
                case UserScreen.StokAyarlar:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C20.ToString(), out result);
                    break;
                case UserScreen.MusteriSorgula:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C21.ToString(), out result);
                    break;
                case UserScreen.MusteriDuzenle:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C22.ToString(), out result);
                    break;
                case UserScreen.TedarikciSorgula:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C23.ToString(), out result);
                    break;
                case UserScreen.TedarikciDuzenle:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C24.ToString(), out result);
                    break;
                case UserScreen.Otomasyon:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C25.ToString(), out result);
                    break;
                case UserScreen.TeklifDuzelt:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C26.ToString(), out result);
                    break;
                case UserScreen.ProjeDuzelt:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C27.ToString(), out result);
                    break;
                case UserScreen.ProjeAyarlar:
                    Enum.TryParse(Dynamic.OnlineUser_Authorization.C28.ToString(), out result);
                    break;
                default:
                    break;
            }

            return result;
        }


        public static bool GizleGoster(UserScreen screen)
        {
            if (MyAuthorization.Control(screen) == UserAccess.Gizle)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //static bool GizleGoster(UserScreen screen)
        //{
        //    if (MyAuthorization.Control(screen) == UserAccess.)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    }
}
