using Prkn.Common.Design.Controls;
using Prkn.Common.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.Common.Functions
{
    public class Checks
    {
        public static bool VersionCompare(string LastVersion, string NewVersion)
        {
            string[] last   = LastVersion.Split('.');
            string[] New    = NewVersion.Split('.');

            bool YeniVersiyonBulundu = false;

            try
            {
                int LV0 = int.Parse(last[0]);
                int LV1 = int.Parse(last[1]);
                int LV2 = int.Parse(last[2]);
                int LV3 = int.Parse(last[3]);

                int NV0 = int.Parse(New[0]);
                int NV1 = int.Parse(New[1]);
                int NV2 = int.Parse(New[2]);
                int NV3 = int.Parse(New[3]);

                if (LV0 <= NV0)
                {
                    if (LV0 <= NV0 && LV1 <= NV1)
                    {
                        if (LV1 <= NV1 && LV2 <= NV2)
                        {
                            if (LV2 <= NV2 && LV3 < NV3)
                            {
                                YeniVersiyonBulundu = true;
                            }
                            else
                            {
                                YeniVersiyonBulundu = false;
                            }
                        }
                        else
                        {
                            YeniVersiyonBulundu = false;
                        }
                    }
                    else
                    {
                        YeniVersiyonBulundu = false;
                    }
                }
                else
                {
                    YeniVersiyonBulundu = false;
                }
            }
            catch (Exception HATA)
            {
                YeniVersiyonBulundu = false;
            }


            return YeniVersiyonBulundu;
        }

        #region Layout Control (Nesnelerin Boş/Dolu Durumları kontrol edililir)
        /// <summary>
        /// Layout Control (Nesnelerin Boş/Dolu Durumları kontrol edililir)
        /// Kontrol edilmesi istenmeyen nesne list object içinde belirtilmelidir.
        /// </summary>
        /// <param name="DataLayoutControl"></param>
        /// <param name="notCheckOjb"></param>
        /// <returns></returns>
        public static bool DataLayoutValueFillingOK(MyDataLayoutControl DataLayoutControl, List<Object> notCheckOjb = null)
        {
            bool check = true;
            foreach (var item in DataLayoutControl.Controls)
            {
                bool notcheckObjYok = true;

                if (item.GetType() == typeof(MyTextEdit))
                {
                    if (string.IsNullOrEmpty(((MyTextEdit)item).Text))
                    {
                        string name = ((MyTextEdit)item).Name;


                        //Kontrol edilmeyecek Nesnelerin bulunması
                        if (notCheckOjb != null)
                        {
                            for (int i = 0; i < notCheckOjb.Count(); i++)
                            {
                                if (notCheckOjb[i].GetType() == typeof(MyTextEdit))
                                {
                                    if (name == ((MyTextEdit)notCheckOjb[i]).Name)
                                    {
                                        notcheckObjYok = false;
                                    }
                                }
                            }
                        }
                        //Boş ve eksik kalan mesaj gösterilmesi
                        if (notcheckObjYok)
                        {
                            Messages.UyariMesaji("Esik Veri girişi! Lütfen alanları eksiksiz doldurunuz.");
                            ((MyTextEdit)item).Focus();
                            check = false;
                            break;
                        }
                    }
                }
                if (item.GetType() == typeof(MyMemoEdit))
                {
                    if (string.IsNullOrEmpty(((MyMemoEdit)item).Text))
                    {
                        string name = ((MyMemoEdit)item).Name;


                        //Kontrol edilmeyecek Nesnelerin bulunması
                        if (notCheckOjb != null)
                        {
                            for (int i = 0; i < notCheckOjb.Count(); i++)
                            {
                                if (notCheckOjb[i].GetType() == typeof(MyMemoEdit))
                                {
                                    if (name == ((MyMemoEdit)notCheckOjb[i]).Name)
                                    {
                                        notcheckObjYok = false;
                                    }
                                }
                            }
                        }
                        //Boş ve eksik kalan mesaj gösterilmesi
                        if (notcheckObjYok)
                        {
                            Messages.UyariMesaji("Esik Veri girişi! Lütfen alanları eksiksiz doldurunuz.");
                            ((MyMemoEdit)item).Focus();
                            check = false;
                            break;
                        }
                    }
                }
                if (item.GetType() == typeof(MyComboBoxEdit))
                {
                    if (string.IsNullOrEmpty(((MyComboBoxEdit)item).Text))
                    {
                        string name = ((MyComboBoxEdit)item).Name;

                        //Kontrol edilmeyecek Nesnelerin bulunması
                        if (notCheckOjb != null)
                        {
                            for (int i = 0; i < notCheckOjb.Count(); i++)
                            {
                                if (notCheckOjb[i].GetType() == typeof(MyComboBoxEdit))
                                {
                                    if (name == ((MyComboBoxEdit)notCheckOjb[i]).Name)
                                    {
                                        notcheckObjYok = false;
                                    }
                                }
                            }
                        }
                        //Boş ve eksik kalan mesaj gösterilmesi
                        if (notcheckObjYok)
                        {
                            Messages.UyariMesaji("Esik Veri girişi! Lütfen alanları eksiksiz doldurunuz.");
                            ((MyComboBoxEdit)item).Focus();
                            check = false;
                            break;
                        }
                    }
                }
                if (item.GetType() == typeof(MyPhoneNoEdit))
                {
                    if (string.IsNullOrEmpty(((MyPhoneNoEdit)item).Text))
                    {
                        string name = ((MyPhoneNoEdit)item).Name;

                        //Kontrol edilmeyecek Nesnelerin bulunması
                        if (notCheckOjb != null)
                        {
                            for (int i = 0; i < notCheckOjb.Count(); i++)
                            {
                                if (notCheckOjb[i].GetType() == typeof(MyPhoneNoEdit))
                                {
                                    if (name == ((MyPhoneNoEdit)notCheckOjb[i]).Name)
                                    {
                                        notcheckObjYok = false;
                                    }
                                }
                            }
                        }
                        //Boş ve eksik kalan mesaj gösterilmesi
                        if (notcheckObjYok)
                        {
                            Messages.UyariMesaji("Esik Veri girişi! Lütfen alanları eksiksiz doldurunuz.");
                            ((MyPhoneNoEdit)item).Focus();
                            check = false;
                            break;
                        }
                    }
                }
                if (item.GetType() == typeof(MyDateEdit))
                {
                    if (string.IsNullOrEmpty(((MyDateEdit)item).Text) || ((MyDateEdit)item).DateTime.Year < 1900)
                    {
                        string name = ((MyDateEdit)item).Name;

                        //Kontrol edilmeyecek Nesnelerin bulunması
                        if (notCheckOjb != null)
                        {
                            for (int i = 0; i < notCheckOjb.Count(); i++)
                            {
                                if (notCheckOjb[i].GetType() == typeof(MyDateEdit))
                                {
                                    if (name == ((MyDateEdit)notCheckOjb[i]).Name)
                                    {
                                        notcheckObjYok = false;
                                    }
                                }
                            }
                        }
                        //Boş ve eksik kalan mesaj gösterilmesi
                        if (notcheckObjYok)
                        {
                            Messages.UyariMesaji("Esik Veri girişi! Lütfen alanları eksiksiz doldurunuz.");
                            ((MyDateEdit)item).Focus();
                            check = false;
                            break;
                        }
                    }
                }
            }

            return check;
        }
        private void CheckWork<T>(object item, List<Object> notCheckOjb = null)
        {
            bool notcheckObjYok = true;

            if (item.GetType() == typeof(MyTextEdit))
            {
                if (string.IsNullOrEmpty(((MyTextEdit)item).Text))
                {
                    string name = ((MyTextEdit)item).Name;


                    //Kontrol edilmeyecek Nesnelerin bulunması
                    if (notCheckOjb != null)
                    {
                        for (int i = 0; i < notCheckOjb.Count(); i++)
                        {
                            if (notCheckOjb[i].GetType() == typeof(MyTextEdit))
                            {
                                if (name == ((MyTextEdit)notCheckOjb[i]).Name)
                                {
                                    notcheckObjYok = false;
                                }
                            }
                        }
                    }
                    //Boş ve eksik kalan mesaj gösterilmesi
                    if (notcheckObjYok)
                    {
                        Messages.UyariMesaji("Esik Veri girişi! Lütfen alanları eksiksiz doldurunuz.");
                        ((MyTextEdit)item).Focus();
                        //      check = false;

                    }
                }
            }
        } 
        #endregion


        #region Değer Kontrol (Değer 0 ise geriye NULL döndürür)
        /// <summary>
        /// Değer Kontrol (Değer 0 ise geriye NULL döndürür)
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static long? IdCheckNullOrResult(long Id)
        {
            if (Id == 0)
            {
                return null;
            }
            else
            {
                return Id;
            }
        }
        /// <summary>
        /// Değer Kontrol (Değer 0 ise geriye NULL döndürür)
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime? DateTimeCheckNullOrResult(DateTime dt)
        {
            if (dt.Year < 1900 | dt.Month == 0 | dt.Day == 0)
            {
                return null;
            }
            else
            {
                return dt;
            }
        } 
        #endregion
    }
}
