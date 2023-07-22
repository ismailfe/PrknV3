using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Prkn.Common.Message
{
    public class Messages
    {
        public static void HataMesaji(string mesaj)
        {
            XtraMessageBox.Show(mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void UyariMesaji(string mesaj)
        {
            XtraMessageBox.Show(mesaj, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult EvetSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult HayirSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult EvetSeciliEvetHayirIptal(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult HayirSeciliEvetHayirIptal(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }


        public static DialogResult SilMesaj(string SilinecekVeriBilgisi)
        {
            return HayirSeciliEvetHayir($"{SilinecekVeriBilgisi} silinecektir. Onaylıyor musunuz?", "Silme Onay");
        }

        public static DialogResult TemizleMesaj()
        {
            return HayirSeciliEvetHayir($"Yeni veri eklemek için ilgili bölümler temizlenecektir. Onaylıyor musunuz?", "Silme Onay");
        }

        public static DialogResult KapanisMesaj()
        {
            return HayirSeciliEvetHayirIptal("Yapılan değişiklikler kayıt edilsin mi?", "Çıkış Onay");
        }

        public static DialogResult KayitMesaj()
        {
            return EvetSeciliEvetHayir("Yapılan değişiklikler mevcut verinin üzerine kaydedilsin mi?", "Kaydet Onay");
        }

        public static DialogResult FarkliKayitMesaj()
        {
            return EvetSeciliEvetHayir("Yapılan değişiklikler yeni veri olarak kaydedilsin mi?", "Farklı Kaydet Onay");
        }

        public static void KartSecmemeUyariMesaji()
        {
            UyariMesaji("Lütfen bir kart seçiniz.");
        }

        public static void MukerrerKayitHataMesaji(string fieldName)
        {
            HataMesaji($"Girmiş olduğunuz {fieldName} daha önce kullanılmıştır.");
        }

        public static void HataliVeriMesaji(string fieldName)
        {
            HataMesaji($"{fieldName} alanına geçerli bir değer girmelisiniz.");
        }

        public static DialogResult TabloExportMesaj(string dosyaFormati)
        {
            return EvetSeciliEvetHayir($"İlgili tablo, {dosyaFormati} olarak dışarı aktarılacaktır. Onaylıyor musunuz?", "Export Onay");
        }
    }
}
