using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prkn.UI.Win.Functions
{
    public class ProjeSorgu
    {
        public static FlowLayoutPanel Panel;
        public static CheckEdit SadeceDoluKlasor;
        public static string AnaProjeDizini;
        public static string MusteriAdi;
        public static string ProjeRefNo;
        public static string ProjeRevNo;

        public ProjeSorgu()
        {
            AdresTanimlamalari();
        }

        public static string Sorgu(CheckEdit Check)
        {
            string status = "";
            AdresTanimlamalari();

            if (Check.Checked)
            {
                status = Sorgulama_On_Kontrol();
                if (status == "OK!")
                {
                    var getfolder = GetFolderPathandHeaders(Check.Name);
                    bool KlasorDolu = KlasorDolulukKontrol(getfolder[0]);
                    UC_FolderBrowser ucFolderBrowser = new UC_FolderBrowser();

                    if (KlasorDolu)
                    {
                        ucFolderBrowser.XID_LB_Baslik.Text = getfolder[1];
                    }
                    else
                    {
                        ucFolderBrowser.XID_LB_Baslik.Text = getfolder[1] + " - DOSYA YOK!";
                    }
                    ucFolderBrowser.Name = "name" + Check.Name;
                    ucFolderBrowser.BrowserYol = getfolder[0];
                    ucFolderBrowser.XID_WBrowser.Url = new Uri(getfolder[0]);
                    //ucFolderBrowser.XID_Picture = Properties.Resources.i103;

                    if (!SadeceDoluKlasor.Checked || (KlasorDolu && SadeceDoluKlasor.Checked))
                    {
                        Panel.Controls.Add(ucFolderBrowser);
                    }
                }
 
            }


            return status;
        }

        public static string Sorgulama_On_Kontrol()
        {
            //if (CLS.Form_Main.CHB_Sorgu_CihazDokumanlari.Checked || CLS.Form_Main.CHB_Sorgu_Cizimler.Checked || CLS.Form_Main.CHB_Sorgu_DigerDokumanlar.Checked ||
            //        CLS.Form_Main.CHB_Sorgu_Dokumanlar.Checked || CLS.Form_Main.CHB_Sorgu_ElektrikPrj.Checked || CLS.Form_Main.CHB_Sorgu_Formlar.Checked ||
            //        CLS.Form_Main.CHB_Sorgu_FotografVideo.Checked || CLS.Form_Main.CHB_Sorgu_PrgHMI.Checked || CLS.Form_Main.CHB_Sorgu_MalzemeListesi.Checked ||
            //        CLS.Form_Main.CHB_Sorgu_MusteriIliskileri.Checked || CLS.Form_Main.CHB_Sorgu_PrgPLC.Checked || CLS.Form_Main.CHB_Sorgu_Programlar.Checked ||
            //        CLS.Form_Main.CHB_Sorgu_PrgPC.Checked || CLS.Form_Main.CHB_Sorgu_PrgDiger.Checked || CLS.Form_Main.CHB_Sorgu_IsZamanPlani.Checked)
            //{
             //   CLS.Form_Main.LB_Dosya_NitelikSecilmedi.Visible = false;

                if (Directory.Exists(Paths.KlasorYolu_MusteriKlasoru))
                {
                    if (Directory.Exists(Paths.KlasorYolu_ProjeKlasoru))
                    {
                        if (Directory.Exists(Paths.KlasorYolu_HedefProjeKlasoru))
                        {
                            if (Directory.Exists(Paths.KlasorYolu_HedefProjeKlasoru + "\\D1") && Directory.Exists(Paths.KlasorYolu_HedefProjeKlasoru + "\\D2") &&
                                Directory.Exists(Paths.KlasorYolu_HedefProjeKlasoru + "\\D3") && Directory.Exists(Paths.KlasorYolu_HedefProjeKlasoru + "\\D4") &&
                                Directory.Exists(Paths.KlasorYolu_HedefProjeKlasoru + "\\D5") && Directory.Exists(Paths.KlasorYolu_HedefProjeKlasoru + "\\D6") &&
                                Directory.Exists(Paths.KlasorYolu_HedefProjeKlasoru + "\\D7"))
                            {
                                //CLS.Form_Main.TB_Sorgu_ProjeYolu.Text = Paths.KlasorYolu_HedefProjeKlasoru;
                                return "OK!";
                            }
                            else
                            {
                                if (File.Exists(Paths.KlasorYolu_HedefProjeKlasoru + "\\" + ProjeRevNo + ".zip"))
                                {
                                MessageBox.Show("Seçilen Revizyon dosyaları arşivlenmiş gözüküyor! Dosya ve klasörleri manuel olarak kontrol edin. \nDosya Yolu:\n" + Paths.KlasorYolu_HedefProjeKlasoru, "Sorgulama Hatası!");
                                    //CLS.Form_Main.TB_Sorgu_ProjeYolu.Text = KlasorYolu_HedefProjeKlasoru;
                                    return "Seçilen Revizyon dosyaları arşivlenmiş gözüküyor! Dosya ve klasörleri manuel olarak kontrol edin. \nDosya Yolu:\n" + Paths.KlasorYolu_HedefProjeKlasoru;
                                }
                                else
                                {
                                MessageBox.Show("Seçilen Revizyon dosyaları ya da klasör yapısı değiştirilmiş! Dosya ve klasörleri manuel olarak kontrol edin. \nDosya Yolu:\n" + Paths.KlasorYolu_HedefProjeKlasoru, "Sorgulama Hatası!");
                                //CLS.Form_Main.TB_Sorgu_ProjeYolu.Text = KlasorYolu_HedefProjeKlasoru;
                                return "Seçilen Revizyon dosyaları ya da klasör yapısı değiştirilmiş! Dosya ve klasörleri manuel olarak kontrol edin. \nDosya Yolu:\n" + Paths.KlasorYolu_HedefProjeKlasoru;
                                }

                            }

                        }
                        else { return "Projeler dizini içinde seçilen revizyon klasörü bulunamadı."; }
                    }
                    else { return "Projeler dizini içinde seçilen proje klasörü bulunamadı."; }
                }
                else { return "Projeler dizini içinde seçilen müşteri klasörü bulunamadı."; }
            //}
            //else
            //{
            //    return "Arama Kriteri Seçilmedi. Dosyalar neye göre getirilecek? Lütfen 'Dosya Niteliği' bölümünden bir seçim yapınız.";
            //}





        }
        static string[] GetFolderPathandHeaders(string CheckBoxName)
        {
            string[] result = new string[2];

            switch (CheckBoxName)
            {
                case "checkProgramlar":
                    result[0] = Paths.KlasorYolu_Programlar;
                    result[1] = "Programlar Klasörü";
                    break;
                case "checkProgramlarPLC":
                    result[0] = Paths.KlasorYolu_PLC;
                    result[1] = "Programlar - PLC";
                    break;
                case "checkProgramlarHMI":
                    result[0] = Paths.KlasorYolu_HMI;
                    result[1] = "Programlar - HMI";
                    break;
                case "checkProgramlarPC":
                    result[0] = Paths.KlasorYolu_PC;
                    result[1] = "Programlar - PC";
                    break;
                case "checkProgramlarDiger":
                    result[0] = Paths.KlasorYolu_PrgDiger;
                    result[1] = "Programlar - DİĞER";
                    break;
                case "checkElektrikProjesi":
                    result[0] = Paths.KlasorYolu_ElektrikProjesi;
                    result[1] = "Elektrik Projesi";
                    break;
                case "checkMalzemeListesi":
                    result[0] = Paths.KlasorYolu_MalzemeListesi;
                    result[1] = "Malzeme Listesi";
                    break;
                case "checkCizimler":
                    result[0] = Paths.KlasorYolu_Cizimler;
                    result[1] = "Çizimler";
                    break;
                case "checkFotografVideo":
                    result[0] = Paths.KlasorYolu_FotografVideo;
                    result[1] = "Fotoğraf & Video";
                    break;
                case "checkIsZamanPlanı":
                    result[0] = Paths.KlasorYolu_IsZamanPlani;
                    result[1] = "İş-Zaman Planları";
                    break;
                case "checkServisEgitimFormlari":
                    result[0] = Paths.KlasorYolu_Formlar;
                    result[1] = "Eğitim Servis Formları";
                    break;
                case "checkDokumanlar":
                    result[0] = Paths.KlasorYolu_Dokumanlar;
                    result[1] = "Dokümanlar";
                    break;
                case "checkCihazDokumanlari":
                    result[0] = Paths.KlasorYolu_Cihazlar;
                    result[1] = "Cihaz Dokümanları";
                    break;
                case "checkDigerDokumanlar":
                    result[0] = Paths.KlasorYolu_DigerDokumanlar;
                    result[1] = "Diğer Dokümanlar";
                    break;
                case "checkMusteriliskileri":
                    result[0] = Paths.KlasorYolu_MusteriIliskileri;
                    result[1] = "Müşteri İlişkileri";
                    break;
            }

            return result;
        }
        static void AdresTanimlamalari()
        {
            Paths.KlasorYolu_MusteriKlasoru         = AnaProjeDizini                  + "\\" + MusteriAdi;
            Paths.KlasorYolu_ProjeKlasoru           = Paths.KlasorYolu_MusteriKlasoru + "\\" + ProjeRefNo;
            Paths.KlasorYolu_HedefProjeKlasoru      = Paths.KlasorYolu_ProjeKlasoru   + "\\" + ProjeRevNo;
            
            Paths.KlasorYolu_MusteriIliskileri      = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D1";
            Paths.KlasorYolu_MalzemeListesi         = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D2";
            Paths.KlasorYolu_ElektrikProjesi        = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D3";
            Paths.KlasorYolu_Programlar             = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D4";
            Paths.KlasorYolu_Dokumanlar             = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D5";
            Paths.KlasorYolu_FotografVideo          = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D6";
            Paths.KlasorYolu_IsZamanPlani           = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D7";
                                                      
            Paths.KlasorYolu_Gelenler               = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D1" + "\\" + "Gelenler";
            Paths.KlasorYolu_Teklifler              = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D1" + "\\" + "Teklifler";
            Paths.KlasorYolu_TeklifOnaylanan        = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D1" + "\\" + "Teklifler" + "\\" + "Teklif - Onaylanan";
            Paths.KlasorYolu_TeklifVerilen          = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D1" + "\\" + "Teklifler" + "\\" + "Teklif - Verilen";
                                                    
            Paths.KlasorYolu_PLC                    = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D4" + "\\" + "PLC";
            Paths.KlasorYolu_HMI                    = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D4" + "\\" + "HMI";
            Paths.KlasorYolu_PC                     = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D4" + "\\" + "PC";
            Paths.KlasorYolu_PrgDiger               = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D4" + "\\" + "Diger";
                                                      
            Paths.KlasorYolu_Cihazlar               = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D5" + "\\" + "Cihazlar";
            Paths.KlasorYolu_Cizimler               = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D5" + "\\" + "Cizimler";
            Paths.KlasorYolu_DigerDokumanlar        = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D5" + "\\" + "Diger";
            Paths.KlasorYolu_Formlar                = Paths.KlasorYolu_HedefProjeKlasoru + "\\" + "D5" + "\\" + "Formlar";
        }

        static class Paths
        {
           public static string KlasorYolu_MusteriKlasoru{get; set;}
           public static string KlasorYolu_ProjeKlasoru{get; set;}
           public static string KlasorYolu_HedefProjeKlasoru{get; set;}
        
           public static string KlasorYolu_MusteriIliskileri{get; set;}
           public static string KlasorYolu_MalzemeListesi{get; set;}
           public static string KlasorYolu_ElektrikProjesi{get; set;}
           public static string KlasorYolu_Programlar{get; set;}
           public static string KlasorYolu_Dokumanlar{get; set;}
           public static string KlasorYolu_FotografVideo{get; set;}
           public static string KlasorYolu_IsZamanPlani{get; set;}
       
           public static string KlasorYolu_Gelenler{get; set;}
           public static string KlasorYolu_Teklifler{get; set;}
           public static string KlasorYolu_TeklifOnaylanan{get; set;}
           public static string KlasorYolu_TeklifVerilen{get; set;}
         
           public static string KlasorYolu_PLC{get; set;}
           public static string KlasorYolu_HMI{get; set;}
           public static string KlasorYolu_PC{get; set;}
           public static string KlasorYolu_PrgDiger{get; set;}
     
           public static string KlasorYolu_Cihazlar{get; set;}
           public static string KlasorYolu_Cizimler{get; set;}
           public static string KlasorYolu_DigerDokumanlar{get; set;}
           public static string KlasorYolu_Formlar{get; set;}
        }

        public static long KlasorBoyutKontrol(DirectoryInfo yol)
        {
            return yol.GetFiles().Sum(fi => fi.Length) +
            yol.GetDirectories().Sum(di => KlasorBoyutKontrol(di));

        }
        public static bool KlasorDolulukKontrol(string KlasorYolu)
        {
            DirectoryInfo Yol = new DirectoryInfo(KlasorYolu);
            if (Yol.GetFiles().Sum(fi => fi.Length) + Yol.GetDirectories().Sum(di => KlasorBoyutKontrol(di)) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}



//public void Sorgulama()
//{
//    try
//    {
//        //CLS.Form_Main.FP_SorguCevaplari.Controls.Clear();
//        //CLS.Form_Main.FP_SorguCevaplari.Update();
//        //CLS.Form_Main.FP_SorguCevaplari.Refresh();
//        //GC.Collect();

//        //CLS.Form_Main.TB_Sorgu_Hata_Bildirimi.Text = "";

//        //if (Sorgulama_On_Kontrol() == "OK!")
//        //{
//        //    CLS.Form_Main.LB_Dosya_NitelikSecilmedi.Visible = false;
//        string[] NesneTextleri = new string[10];
//        bool DolulukKnt_OK = false;
//        try
//        {

//            ////=================================================================
//            ////=================================================================
//            if (CLS.Form_Main.CHB_Sorgu_PrgPLC.Checked)
//            {
//                if (KlasorDoluBosKontrol(KlasorYolu_PLC))
//                {
//                    DosyaBrowser_PLC.XID_LB_Baslik.Text = "Programlar - PLC";
//                    DolulukKnt_OK = true;
//                }
//                else
//                {
//                    DosyaBrowser_PLC.XID_LB_Baslik.Text = "Programlar - PLC - Dosya Yok!";
//                    DolulukKnt_OK = false;
//                }


//                DosyaBrowser_PLC.Name = "DosyaBrowser_PLC";
//                DosyaBrowser_PLC.BrowserYol = KlasorYolu_PLC;
//                DosyaBrowser_PLC.XID_WBrowser.Url = new Uri(KlasorYolu_PLC);
//                DosyaBrowser_PLC.XID_Picture.Image = Properties.Resources.i103;

//                if (!CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked || (DolulukKnt_OK && CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked))
//                {
//                    CLS.Form_Main.FP_SorguCevaplari.Controls.Add(DosyaBrowser_PLC);
//                }

//            }
//            ////=================================================================
//            ////=================================================================
//            if (CLS.Form_Main.CHB_Sorgu_PrgHMI.Checked)
//            {
//                if (KlasorDoluBosKontrol(KlasorYolu_HMI))
//                {
//                    DosyaBrowser_HMI.XID_LB_Baslik.Text = "Programlar - HMI";
//                    DolulukKnt_OK = true;
//                }
//                else
//                {
//                    DosyaBrowser_HMI.XID_LB_Baslik.Text = "Programlar - HMI - Dosya Yok!";
//                    DolulukKnt_OK = false;
//                }

//                DosyaBrowser_HMI.Name = "DosyaBrowser_HMI";
//                DosyaBrowser_HMI.BrowserYol = KlasorYolu_HMI;
//                DosyaBrowser_HMI.XID_WBrowser.Url = new Uri(KlasorYolu_HMI);
//                DosyaBrowser_HMI.XID_Picture.Image = Properties.Resources.i88;

//                if (!CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked || (DolulukKnt_OK && CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked))
//                {
//                    CLS.Form_Main.FP_SorguCevaplari.Controls.Add(DosyaBrowser_HMI);
//                }
//            }
//            ////=================================================================
//            ////=================================================================
//            if (CLS.Form_Main.CHB_Sorgu_Programlar.Checked)
//            {
//                if (KlasorDoluBosKontrol(KlasorYolu_Programlar))
//                {
//                    DosyaBrowser_Programlar.XID_LB_Baslik.Text = "Programlar";
//                    DolulukKnt_OK = true;
//                }
//                else
//                {
//                    DosyaBrowser_Programlar.XID_LB_Baslik.Text = "Programlar - Dosya Yok!";
//                    DolulukKnt_OK = false;
//                }

//                DosyaBrowser_Programlar.Name = "DosyaBrowser_Programlar";
//                DosyaBrowser_Programlar.BrowserYol = KlasorYolu_Programlar;
//                DosyaBrowser_Programlar.XID_WBrowser.Url = new Uri(KlasorYolu_Programlar);
//                DosyaBrowser_Programlar.XID_Picture.Image = Properties.Resources.i91;

//                if (!CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked || (DolulukKnt_OK && CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked))
//                {

//                    CLS.Form_Main.FP_SorguCevaplari.Controls.Add(DosyaBrowser_Programlar);
//                }
//            }
//            ////=================================================================
//            ////=================================================================
//            if (CLS.Form_Main.CHB_Sorgu_PrgDiger.Checked)
//            {
//                if (KlasorDoluBosKontrol(KlasorYolu_PrgDiger))
//                {
//                    DosyaBrowser_PrgDiger.XID_LB_Baslik.Text = "Diğer Programlar";
//                    DolulukKnt_OK = true;
//                }
//                else
//                {
//                    DosyaBrowser_PrgDiger.XID_LB_Baslik.Text = "Diğer Programlar - Dosya Yok!";
//                    DolulukKnt_OK = false;
//                }

//                DosyaBrowser_PrgDiger.Name = "DosyaBrowser_PrgDiger";
//                DosyaBrowser_PrgDiger.BrowserYol = KlasorYolu_PrgDiger;
//                DosyaBrowser_PrgDiger.XID_WBrowser.Url = new Uri(KlasorYolu_PrgDiger);
//                DosyaBrowser_PrgDiger.XID_Picture.Image = Properties.Resources.i105;

//                if (!CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked || (DolulukKnt_OK && CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked))
//                {

//                    CLS.Form_Main.FP_SorguCevaplari.Controls.Add(DosyaBrowser_PrgDiger);
//                }

//            }
//            ////=================================================================
//            ////=================================================================
//            if (CLS.Form_Main.CHB_Sorgu_Cizimler.Checked)
//            {
//                if (KlasorDoluBosKontrol(KlasorYolu_Cizimler))
//                {
//                    DosyaBrowser_Cizimler.XID_LB_Baslik.Text = "Cizimler";
//                    DolulukKnt_OK = true;
//                }
//                else
//                {
//                    DosyaBrowser_Cizimler.XID_LB_Baslik.Text = "Cizimler - Dosya Yok!";
//                    DolulukKnt_OK = false;
//                }

//                DosyaBrowser_Cizimler.Name = "DosyaBrowser_Cizimler";
//                DosyaBrowser_Cizimler.BrowserYol = KlasorYolu_Cizimler;
//                DosyaBrowser_Cizimler.XID_WBrowser.Url = new Uri(KlasorYolu_Cizimler);
//                DosyaBrowser_Cizimler.XID_Picture.Image = Properties.Resources.i94;

//                if (!CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked || (DolulukKnt_OK && CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked))
//                {
//                    CLS.Form_Main.FP_SorguCevaplari.Controls.Add(DosyaBrowser_Cizimler);
//                }
//            }
//            ////=================================================================
//            ////=================================================================
//            if (CLS.Form_Main.CHB_Sorgu_ElektrikPrj.Checked)
//            {
//                if (KlasorDoluBosKontrol(KlasorYolu_ElektrikProjesi))
//                {
//                    DosyaBrowser_ElektrikProjesi.XID_LB_Baslik.Text = "Elektrik Projesi";
//                    DolulukKnt_OK = true;
//                }
//                else
//                {
//                    DosyaBrowser_ElektrikProjesi.XID_LB_Baslik.Text = "Elektrik Projesi - Dosya Yok!";
//                    DolulukKnt_OK = false;
//                }

//                DosyaBrowser_ElektrikProjesi.Name = "DosyaBrowser_ElektrikProjesi";
//                DosyaBrowser_ElektrikProjesi.BrowserYol = KlasorYolu_ElektrikProjesi;
//                DosyaBrowser_ElektrikProjesi.XID_WBrowser.Url = new Uri(KlasorYolu_ElektrikProjesi);
//                DosyaBrowser_ElektrikProjesi.XID_Picture.Image = Properties.Resources.i92;

//                if (!CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked || (DolulukKnt_OK && CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked))
//                {
//                    CLS.Form_Main.FP_SorguCevaplari.Controls.Add(DosyaBrowser_ElektrikProjesi);
//                }
//            }
//            ////=================================================================
//            ////=================================================================
//            if (CLS.Form_Main.CHB_Sorgu_MalzemeListesi.Checked)
//            {
//                if (KlasorDoluBosKontrol(KlasorYolu_MalzemeListesi))
//                {
//                    DosyaBrowser_MalzemeListesi.XID_LB_Baslik.Text = "Malzeme Listesi";
//                    DolulukKnt_OK = true;
//                }
//                else
//                {
//                    DosyaBrowser_MalzemeListesi.XID_LB_Baslik.Text = "Malzeme Listesi - Dosya Yok!";
//                    DolulukKnt_OK = false;
//                }

//                DosyaBrowser_MalzemeListesi.Name = "DosyaBrowser_MalzemeListesi";
//                DosyaBrowser_MalzemeListesi.BrowserYol = KlasorYolu_MalzemeListesi;
//                DosyaBrowser_MalzemeListesi.XID_WBrowser.Url = new Uri(KlasorYolu_MalzemeListesi);
//                DosyaBrowser_MalzemeListesi.XID_Picture.Image = Properties.Resources.i101;

//                if (!CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked || (DolulukKnt_OK && CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked))
//                {
//                    CLS.Form_Main.FP_SorguCevaplari.Controls.Add(DosyaBrowser_MalzemeListesi);
//                }
//            }
//            ////=================================================================
//            ////=================================================================
//            if (CLS.Form_Main.CHB_Sorgu_PrgPC.Checked)
//            {
//                if (KlasorDoluBosKontrol(KlasorYolu_PC))
//                {
//                    DosyaBrowser_PC.XID_LB_Baslik.Text = "Programlar - PC";
//                    DolulukKnt_OK = true;
//                }
//                else
//                {
//                    DosyaBrowser_PC.XID_LB_Baslik.Text = "Programlar - PC - Dosya Yok!";
//                    DolulukKnt_OK = false;
//                }

//                DosyaBrowser_PC.Name = "DosyaBrowser_PC";
//                DosyaBrowser_PC.BrowserYol = KlasorYolu_PC;
//                DosyaBrowser_PC.XID_WBrowser.Url = new Uri(KlasorYolu_PC);
//                DosyaBrowser_PC.XID_Picture.Image = Properties.Resources.i90;

//                if (!CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked || (DolulukKnt_OK && CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked))
//                {
//                    CLS.Form_Main.FP_SorguCevaplari.Controls.Add(DosyaBrowser_PC);
//                }

//            }
//            ////=================================================================
//            ////=================================================================
//            if (CLS.Form_Main.CHB_Sorgu_Dokumanlar.Checked)
//            {
//                if (KlasorDoluBosKontrol(KlasorYolu_Dokumanlar))
//                {
//                    DosyaBrowser_Dokumanlar.XID_LB_Baslik.Text = "Dökümanlar";
//                    DolulukKnt_OK = true;
//                }
//                else
//                {
//                    DosyaBrowser_Dokumanlar.XID_LB_Baslik.Text = "Dökümanlar - Dosya Yok!";
//                    DolulukKnt_OK = false;
//                }

//                DosyaBrowser_Dokumanlar.Name = "DosyaBrowser_Dokumanlar";
//                DosyaBrowser_Dokumanlar.BrowserYol = KlasorYolu_Dokumanlar;
//                DosyaBrowser_Dokumanlar.XID_WBrowser.Url = new Uri(KlasorYolu_Dokumanlar);
//                DosyaBrowser_Dokumanlar.XID_Picture.Image = Properties.Resources.i142;

//                if (!CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked || (DolulukKnt_OK && CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked))
//                {
//                    CLS.Form_Main.FP_SorguCevaplari.Controls.Add(DosyaBrowser_Dokumanlar);
//                }
//            }
//            ////=================================================================
//            ////=================================================================
//            if (CLS.Form_Main.CHB_Sorgu_CihazDokumanlari.Checked)
//            {
//                if (KlasorDoluBosKontrol(KlasorYolu_Cihazlar))
//                {
//                    DosyaBrowser_Cihazlar.XID_LB_Baslik.Text = "Cihaz Dökümanları";
//                    DolulukKnt_OK = true;
//                }
//                else
//                {
//                    DosyaBrowser_Cihazlar.XID_LB_Baslik.Text = "Cihaz Dökümanları - Dosya Yok!";
//                    DolulukKnt_OK = false;
//                }

//                DosyaBrowser_Cihazlar.Name = "DosyaBrowser_Cihazlar";
//                DosyaBrowser_Cihazlar.BrowserYol = KlasorYolu_Cihazlar;
//                DosyaBrowser_Cihazlar.XID_WBrowser.Url = new Uri(KlasorYolu_Cihazlar);
//                DosyaBrowser_Cihazlar.XID_Picture.Image = Properties.Resources.i127;

//                if (!CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked || (DolulukKnt_OK && CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked))
//                {
//                    CLS.Form_Main.FP_SorguCevaplari.Controls.Add(DosyaBrowser_Cihazlar);
//                }
//            }

//            ////=================================================================
//            ////=================================================================
//            if (CLS.Form_Main.CHB_Sorgu_DigerDokumanlar.Checked)
//            {
//                if (KlasorDoluBosKontrol(KlasorYolu_DigerDokumanlar))
//                {
//                    DosyaBrowser_DigerDokumanlar.XID_LB_Baslik.Text = "Diğer Dökümanlar";
//                    DolulukKnt_OK = true;
//                }
//                else
//                {
//                    DosyaBrowser_DigerDokumanlar.XID_LB_Baslik.Text = "Diğer Dökümanlar - Dosya Yok!";
//                    DolulukKnt_OK = false;
//                }

//                DosyaBrowser_DigerDokumanlar.Name = "DosyaBrowser_DigerDokumanlar";
//                DosyaBrowser_DigerDokumanlar.BrowserYol = KlasorYolu_DigerDokumanlar;
//                DosyaBrowser_DigerDokumanlar.XID_WBrowser.Url = new Uri(KlasorYolu_DigerDokumanlar);
//                DosyaBrowser_DigerDokumanlar.XID_Picture.Image = Properties.Resources.i150;

//                if (!CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked || (DolulukKnt_OK && CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked))
//                {
//                    CLS.Form_Main.FP_SorguCevaplari.Controls.Add(DosyaBrowser_DigerDokumanlar);
//                }
//            }
//            ////=================================================================
//            ////=================================================================
//            if (CLS.Form_Main.CHB_Sorgu_Formlar.Checked)
//            {
//                if (KlasorDoluBosKontrol(KlasorYolu_Formlar))
//                {
//                    DosyaBrowser_Formlar.XID_LB_Baslik.Text = "Formlar";
//                    DolulukKnt_OK = true;
//                }
//                else
//                {
//                    DosyaBrowser_Formlar.XID_LB_Baslik.Text = "Formlar - Dosya Yok!";
//                    DolulukKnt_OK = false;
//                }

//                DosyaBrowser_Formlar.Name = "DosyaBrowser_Formlar";
//                DosyaBrowser_Formlar.BrowserYol = KlasorYolu_Formlar;
//                DosyaBrowser_Formlar.XID_WBrowser.Url = new Uri(KlasorYolu_Formlar);
//                DosyaBrowser_Formlar.XID_Picture.Image = Properties.Resources.i149;

//                if (!CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked || (DolulukKnt_OK && CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked))
//                {
//                    CLS.Form_Main.FP_SorguCevaplari.Controls.Add(DosyaBrowser_Formlar);
//                }
//            }
//            ////=================================================================
//            ////=================================================================
//            if (CLS.Form_Main.CHB_Sorgu_MusteriIliskileri.Checked)
//            {
//                if (KlasorDoluBosKontrol(KlasorYolu_MusteriIliskileri))
//                {
//                    DosyaBrowser_MusteriIliskileri.XID_LB_Baslik.Text = "Müşteri İlişkileri";
//                    DolulukKnt_OK = true;
//                }
//                else
//                {
//                    DosyaBrowser_MusteriIliskileri.XID_LB_Baslik.Text = "Müşteri İlişkileri - Dosya Yok!";
//                    DolulukKnt_OK = false;
//                }

//                DosyaBrowser_MusteriIliskileri.Name = "DosyaBrowser_MusteriIliskileri";
//                DosyaBrowser_MusteriIliskileri.BrowserYol = KlasorYolu_MusteriIliskileri;
//                DosyaBrowser_MusteriIliskileri.XID_WBrowser.Url = new Uri(KlasorYolu_MusteriIliskileri);
//                DosyaBrowser_MusteriIliskileri.XID_Picture.Image = Properties.Resources.i116;

//                if (!CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked || (DolulukKnt_OK && CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked))
//                {
//                    CLS.Form_Main.FP_SorguCevaplari.Controls.Add(DosyaBrowser_MusteriIliskileri);
//                }
//            }
//            ////=================================================================
//            ////=================================================================
//            if (CLS.Form_Main.CHB_Sorgu_IsZamanPlani.Checked)
//            {
//                if (KlasorDoluBosKontrol(KlasorYolu_IsZamanPlani))
//                {
//                    DosyaBrowser_IsZamanPlani.XID_LB_Baslik.Text = "İş Zaman Planı";
//                    DolulukKnt_OK = true;
//                }
//                else
//                {
//                    DosyaBrowser_IsZamanPlani.XID_LB_Baslik.Text = "İş Zaman Planı - Dosya Yok!";
//                    DolulukKnt_OK = false;
//                }

//                DosyaBrowser_IsZamanPlani.Name = "DosyaBrowser_IsZamanPlani";
//                DosyaBrowser_IsZamanPlani.BrowserYol = KlasorYolu_IsZamanPlani;
//                DosyaBrowser_IsZamanPlani.XID_WBrowser.Url = new Uri(KlasorYolu_IsZamanPlani);
//                DosyaBrowser_IsZamanPlani.XID_Picture.Image = Properties.Resources.i112;

//                if (!CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked || (DolulukKnt_OK && CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked))
//                {
//                    CLS.Form_Main.FP_SorguCevaplari.Controls.Add(DosyaBrowser_IsZamanPlani);
//                }
//            }
//            ////=================================================================
//            ////=================================================================
//            if (CLS.Form_Main.CHB_Sorgu_FotografVideo.Checked)
//            {
//                if (KlasorDoluBosKontrol(KlasorYolu_FotografVideo))
//                {
//                    DosyaBrowser_FotografVideo.XID_LB_Baslik.Text = "Fotoğraf Video";
//                    DolulukKnt_OK = true;
//                }
//                else
//                {
//                    DosyaBrowser_FotografVideo.XID_LB_Baslik.Text = "Fotoğraf Video - Dosya Yok!";
//                    DolulukKnt_OK = false;
//                }

//                DosyaBrowser_FotografVideo.Name = "DosyaBrowser_FotografVideo";
//                DosyaBrowser_FotografVideo.BrowserYol = KlasorYolu_FotografVideo;
//                DosyaBrowser_FotografVideo.XID_WBrowser.Url = new Uri(KlasorYolu_FotografVideo);
//                DosyaBrowser_FotografVideo.XID_Picture.Image = Properties.Resources.i96;

//                if (!CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked || (DolulukKnt_OK && CLS.Form_Main.CHB_Sorgu_SadeceDoluGetir.Checked))
//                {
//                    CLS.Form_Main.FP_SorguCevaplari.Controls.Add(DosyaBrowser_FotografVideo);
//                }

//            }



//            CLS.ProjeSorgulamaGecmisi.GecmisKaydet();
//            //CLS.ProjeSorgulamaGecmisi.ProjeGecmisGoster();
//        }
//        catch
//        {
//            CLS.Form_Main.TB_Sorgu_Hata_Bildirimi.ForeColor = Color.Red;
//            CLS.Form_Main.TB_Sorgu_Hata_Bildirimi.Text = " Hay Aksi! Arama yapılan dizinde bir problem var gibi gözüküyor. Kontrol edilmesi gerekir." +
//                "Bir klasör silinmiş, taşınmış olabilir ya da bir klasör adı standart dışı.";
//        }


//    }
//                //else
//                //{
//                //    CLS.Form_Main.LB_Dosya_NitelikSecilmedi.Visible = true;
//                //    CLS.Form_Main.TB_Sorgu_Hata_Bildirimi.ForeColor = Color.Red;
//                //    CLS.Form_Main.TB_Sorgu_Hata_Bildirimi.Text = Sorgulama_On_Kontrol();
//                //}
//}
////catch (Exception HATA)
////{

////    CLS.LocalDB.LogsERR(HATA.ToString(), "", "");
////}

////}