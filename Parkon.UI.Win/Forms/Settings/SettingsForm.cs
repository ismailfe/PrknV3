using Emikon.Parkon.Bll.Settings;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;
using DevExpress.XtraLayout.Customization;
using Emikon.Parkon.Common.Variables;
using Emikon.Parkon.Bll.Project;
using System.Threading;

namespace Emikon.Parkon.UI.Win.Forms.Settings
{
    public partial class SettingsForm : DevExpress.XtraEditors.XtraForm
    {

        public SettingsForm()
        {
            InitializeComponent();
            EnbDisb();

            txtSecilenProjeAnaDizin.Text = SettingsBll.GetMainProjectsPath();
            txtSecilenTeklifAnaDizin.Text = SettingsBll.GetMainTeklifPath();
            DizinListele();
        }

        void EnbDisb()
        {
            if (Dynamic.OnlineUser.NameLast != "DEMİR")
            {
                btnPathEskiParkonProjeDizin.Enabled = false;
                btnProjeDizinV1toV2Degistir.Enabled = false;
                btnProjectCodeGenerate.Enabled      = false;
            }
        }

        private void B_PathProjeDizin_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FbWDialog = new FolderBrowserDialog();
            DialogResult dr = FbWDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtSecilenProjeAnaDizin.Text = FbWDialog.SelectedPath; // + "\\";
                //   CLS.PrgSettings.KAYDET_AnaDizin();
               DialogResult d =  MessageBox.Show("Projelerin yer aldığı ana dizin; ''" + FbWDialog.SelectedPath + "'' olarak değiştirildi. ", "Ana dizin seçimi");

                if (d == DialogResult.OK)
                {
                    SettingsBll.PostMainProjectsPath(FbWDialog.SelectedPath);
                    Global.ProjeDizin.ProjeAnadizin = txtSecilenProjeAnaDizin.Text;
                }
            }
        }

        private void btnPathEskiParkonProjeDizin_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FbWDialog = new FolderBrowserDialog();
            DialogResult dr = FbWDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var secilendizin = FbWDialog.SelectedPath + "\\";
                //   CLS.PrgSettings.KAYDET_AnaDizin();
                DialogResult d = MessageBox.Show("PARKON V1 Projelerinin yer aldığı ana dizin; ''" + secilendizin + "'' olarak seçildi. ", "Ana dizin seçimi");

                if (d == DialogResult.OK)
                {
                    txtEskiParkonProjeDizin.Text = secilendizin;
                    DizinListele();
                }
            }
        }

        void DizinListele()
        {
            try
            {
                var MusteriDizin = Directory.GetDirectories(txtEskiParkonProjeDizin.Text);
                myMemoEdit1.Text = "";
                for (int i = 0; i < MusteriDizin.Count(); i++)
                {
                    var SubMusteriNameTxt = MusteriDizin[i].Replace(txtEskiParkonProjeDizin.Text, "");
                    var SubDizinMusteri = MusteriDizin[i].Replace(SubMusteriNameTxt, "");
                    //var NewMusteriNameTxt = SubMusteriNameTxt.Substring(5, SubMusteriNameTxt.Length - 5);
                    //var NewMusteriDizin = SubDizinMusteri + "" + NewMusteriNameTxt;

                    myMemoEdit1.Text += MusteriDizin[i] + Environment.NewLine;

                    if (Directory.Exists(MusteriDizin[i]))
                    {
                        var ProjeDizini = Directory.GetDirectories(MusteriDizin[i]);

                        if (ProjeDizini != null)
                        {
                            if (ProjeDizini.Count() > 0)
                            {
                                for (int K = 0; K < ProjeDizini.Count(); K++)
                                {
                                    var prjDizin = ProjeDizini[K];
                                    myMemoEdit1.Text += "      - " + prjDizin + Environment.NewLine;
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void btnProjeDizinV1toV2Degistir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("''" + txtEskiParkonProjeDizin.Text + "'' dizinindeki PARKON V1 versiyon proje dizin formatını PARKON V2 formatı olarak değiştirmek istediğinizden emin misiniz?. ", "PARKON V1 => PARKON V2 Proje Dizin Format Değişikliği", MessageBoxButtons.YesNo);

            if (d == DialogResult.Yes)
            {
                var MusteriDizin = Directory.GetDirectories(txtEskiParkonProjeDizin.Text);

                for (int i = 0; i < MusteriDizin.Count(); i++)
                {
                    var SubMusteriNameTxt       = MusteriDizin[i].Replace(txtEskiParkonProjeDizin.Text, "");
                    var SubDizinMusteri         = MusteriDizin[i].Replace(SubMusteriNameTxt, "");

                    var SubMusteriNameTxtSplit = SubMusteriNameTxt.Split(' ');
                    string NewMusteriNameTxt    = "";

                    if (SubMusteriNameTxtSplit.Count() > 0)
                    {
                        var a = SubMusteriNameTxtSplit[0];
                        if (int.TryParse(SubMusteriNameTxtSplit[0], out int setint))
                        {
                            NewMusteriNameTxt = SubMusteriNameTxt.Substring(5, SubMusteriNameTxt.Length - 5);
                        }
                        else
                        {
                            NewMusteriNameTxt = SubMusteriNameTxt;
                        }
                    }

                    var NewMusteriDizin         = SubDizinMusteri + "" + NewMusteriNameTxt;

                    if (Directory.Exists(MusteriDizin[i]))
                    {
                        var ProjeDizini = Directory.GetDirectories(MusteriDizin[i]);

                        if (ProjeDizini != null)
                        {
                            if (ProjeDizini.Count() > 0)
                            {
                                for (int K = 0; K < ProjeDizini.Count(); K++)
                                {
                                    var prjDizin        = ProjeDizini[K];
                                    var SubPrjTxt       = prjDizin.Replace(MusteriDizin[i] + "\\" , "")
                                                            .Replace("P0000", "")
                                                            .Replace("P000", "")
                                                            .Replace("P00", "")
                                                            .Replace("P0", "");

                                    int txtLength       = SubPrjTxt.Length;
                                    string NewPrjTxt    = "";

                                    if (txtLength == 7)
                                    {
                                        NewPrjTxt = SubPrjTxt + "00000000";
                                    }
                                    else if (txtLength == 8)
                                    {
                                        NewPrjTxt = SubPrjTxt + "0000000";
                                    }
                                    else if (txtLength == 9)
                                    {
                                        NewPrjTxt = SubPrjTxt + "000000";
                                    }
                                    else if (txtLength == 10)
                                    {
                                        NewPrjTxt = SubPrjTxt + "00000";
                                    }
                                    
                                    var newPrjDizin     = MusteriDizin[i] + "\\" + NewPrjTxt;

                                    if (Directory.Exists(prjDizin) ) //&& (SubPrjTxt.Length == 12) )
                                    {
                                        System.IO.Directory.Move(prjDizin, newPrjDizin);
                                    }
                                }
                            }
                        }

                       System.IO.Directory.Move(MusteriDizin[i], NewMusteriDizin);
                    }
                }



                DizinListele();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult d = MessageBox.Show("Proje kodları yeniden düzenlensin mi? ", "Proje Kodu Düzenle", MessageBoxButtons.YesNo);

            if (d == DialogResult.Yes)
            {

                var prjList = ProjectBll.GetList<Model.Projects>().OrderBy(x => x.DateStart);
                var prjListGrp = ProjectBll.GetList<Model.Projects>().OrderBy(x => x.DateStart).GroupBy(x => x.DateStart.Value.Year).Select(grp => grp.ToList()).ToList();

                for (int i = 0; i < prjList.Count(); i++)
                {

                    for (int K = 0; K < prjListGrp[i].Count(); K++)
                    {
                        var yil = prjListGrp[i][K].DateStart.Value.Year.ToString().Remove(0, 2);
                        var data = prjListGrp[i][K];
                        string idx = UcBasamakYap((K + 1).ToString());
                        var PrjCode = "P" + yil + "e" + idx;
                        data.Code = PrjCode;
                        ProjectBll.MyCrud(Common.Enums.IslemTuru.Update, data);
                        Thread.Sleep(100);
                    }


                }

                MessageBox.Show("İşlem Tamam");
            }

      

        }
        string UcBasamakYap(string val)
        {
            switch (val.Length)
            {
                case 1:
                    return "00" + val;
                case 2:
                    return "0" + val;
            }
            return val;
        }

        #region TEKLIFLER
        private void btnPathTeklifDizin_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FbWDialog = new FolderBrowserDialog();
            DialogResult dr = FbWDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtSecilenTeklifAnaDizin.Text = FbWDialog.SelectedPath; // + "\\";
                                                                       //   CLS.PrgSettings.KAYDET_AnaDizin();
                DialogResult d = MessageBox.Show("Tekliflerin yer aldığı ana dizin; ''" + FbWDialog.SelectedPath + "'' olarak değiştirildi. ", "Ana dizin seçimi");

                if (d == DialogResult.OK)
                {
                    SettingsBll.PostMainTeklifPath(FbWDialog.SelectedPath);
                    Global.TeklifDizin.TeklifAnaDizin = txtSecilenTeklifAnaDizin.Text;
                }
            }
        }

        #endregion
    }
}