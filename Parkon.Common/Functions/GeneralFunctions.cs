using DevExpress.Utils.Design.Internal;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using Prkn.Common.Enums;
using Prkn.Common.Variables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Prkn.Common.Variables.Static;

namespace Prkn.Common.Functions
{
    public static class GeneralFunctions
    {


        /// <summary>
        /// readClass propertyleri okunarak, writeClass da bulunan aynı propertylere yazılır.
        /// </summary>
        /// <param name="readClass">Property okunacak Class</param>
        /// <param name="writeClass">Property yazılacak Class</param>
        /// <returns>False: Read Class null </returns>
        public static bool ClassPropertyFilling(object readClass, object writeClass)
        {
            if (readClass != null)
            {
                var _writeClassProperties   = writeClass.GetType().GetProperties();    // Fonksiyon içinde kullanılacak Data
                var _readClassProperties    = readClass.GetType().GetProperties();      // Tablodan Gelen Data

                for (int i = 0; i < _readClassProperties.Count(); i++)
                {
                    var readClassDataProperty       = _readClassProperties[i];
                    var writeClassDataProperty      = _writeClassProperties.Where(x => x.Name == readClassDataProperty.Name).FirstOrDefault();

                    if (writeClassDataProperty != null)
                    {
                        var propertyName        = readClassDataProperty.Name;
                        var readPropertyValue   = readClass.GetType().GetProperty(propertyName).GetValue(readClass);

                        writeClass.GetType()
                            .GetProperty(propertyName)
                            .SetValue(writeClass, readPropertyValue);
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ControlName başındaki txt ön ekini kaldırır.
        /// Amaç controlName ile FieldName tespit etmektir.
        /// </summary>
        /// <param name="txt">ön eki kaldırılacak ControlName</param>
        /// <returns></returns>
        public static string ControlNameToFieldName(string txt)
        {
            string result = "";

            if (txt.StartsWith("rating"))
            {
                result = txt.Replace("rating", "");
            }
            else if (txt.StartsWith("txt"))
            {
                result = txt.Replace("txt", "");
            }
            else if (txt.StartsWith("pic"))
            {
                result = "Pic";
            }

            return result;
        }
        public static void ComboBoxDataFilling<T>(string uri, ComboBoxEdit comboBox)
        {
            ConnWebAPI.SET_Get(uri, out string json);
            var JsonData                = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);
            List<ComboboxItem> mylist   = new List<ComboboxItem>();
            comboBox.Text               = string.Empty;
            comboBox.Properties.Items.Clear();

            if (JsonData != null)
            {
                for (int i = 0; i < JsonData.Count; i++)
                {
                    ComboboxItem itm    = new ComboboxItem();
                    itm.Text            = JsonData[i].GetType().GetProperty("Name").GetValue(JsonData[i]).ToString();
                    itm.Value           = JsonData[i].GetType().GetProperty("Id").GetValue(JsonData[i]);
                    mylist.Add(itm);
                    //comboBox.Properties.Items.Add(itm);
                }
                var mylistOrderBy = mylist.OrderBy(x => x.Text).ToList();
                comboBox.Properties.Items.AddRange(mylistOrderBy);
            }
        }
        public static void ComboBoxDataFillingFromList<T>(List<T> myList, ComboBoxEdit comboBox)
        {
            comboBox.Text = string.Empty;
            comboBox.Properties.Items.Clear();
            if (myList != null)
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    ComboboxItem itm    = new ComboboxItem();
                    itm.Text            = myList[i].GetType().GetProperty("Name").GetValue(myList[i]).ToString();
                    itm.Value           = myList[i].GetType().GetProperty("Id").GetValue(myList[i]).ToString();
                    comboBox.Properties.Items.Add(itm);
                }
            }
        }
        public static void ComboBoxDataFillingFromListForContact<T>(List<T> myList, ComboBoxEdit comboBox)
        {
            comboBox.Text = string.Empty;
            comboBox.Properties.Items.Clear();
            if (myList != null)
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    ComboboxItem itm    = new ComboboxItem();
                    var Ad      = myList[i].GetType().GetProperty("NameFirst").GetValue(myList[i]).ToString();
                    var Soyad   = myList[i].GetType().GetProperty("NameLast").GetValue(myList[i]).ToString();
                    var Unvan   = myList[i].GetType().GetProperty("Job").GetValue(myList[i]).ToString();
                    var txt     = Ad + " " + Soyad + " | " + Crypto.Decrypt(Unvan, Global.Str_ProjeCrypto);
                    itm.Text    = txt;
                    itm.Value   = myList[i].GetType().GetProperty("Id").GetValue(myList[i]);
                    comboBox.Properties.Items.Add(itm);
                }
            }
        }
        public static void ComboBoxDataFillingFromListForUser<T>(List<T> myList, ComboBoxEdit comboBox)
        {
            comboBox.Text = string.Empty;
            comboBox.Properties.Items.Clear();
            if (myList != null)
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    ComboboxItem itm    = new ComboboxItem();
                    var Ad      = myList[i].GetType().GetProperty("NameFirst").GetValue(myList[i]).ToString();
                    var Soyad   = myList[i].GetType().GetProperty("NameLast").GetValue(myList[i]).ToString();
                    var txt     = Ad + " " + Soyad;
                    itm.Text    = txt;
                    itm.Value   = myList[i].GetType().GetProperty("Id").GetValue(myList[i]);
                    comboBox.Properties.Items.Add(itm);
                }
            }
        }
        public static void ComboBoxDataFillingForContact<T>(string uri, ComboBoxEdit comboBox)
        {
            ConnWebAPI.SET_Get(uri, out string json);
            var JsonData                    = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);
            List<ComboboxItem> mylist       = new List<ComboboxItem>();
            comboBox.Text                   = string.Empty;
            comboBox.Properties.Items.Clear();

            if (JsonData != null)
            {
                for (int i = 0; i < JsonData.Count; i++)
                {
                    ComboboxItem itm = new ComboboxItem();

                    var Ad      = JsonData[i].GetType().GetProperty("NameFirst").GetValue(JsonData[i]).ToString();
                    var Soyad   = JsonData[i].GetType().GetProperty("NameLast").GetValue(JsonData[i]).ToString();
                    var Unvan   = JsonData[i].GetType().GetProperty("Job").GetValue(JsonData[i]).ToString();
                    var txt     = Ad + " " + Soyad + " | " + Crypto.Decrypt(Unvan, Global.Str_ProjeCrypto);
                    itm.Text    = txt;
                    itm.Value   = JsonData[i].GetType().GetProperty("Id").GetValue(JsonData[i]);
                    mylist.Add(itm);
                }
                var mylistOrderBy = mylist.OrderBy(x => x.Text).ToList();
                comboBox.Properties.Items.AddRange(mylistOrderBy);
            }
        }
        public static void ComboBoxDataFillingForUser<T>(string uri, ComboBoxEdit comboBox)
        {
            ConnWebAPI.SET_Get(uri, out string json);
            var JsonData                    = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);
            List<ComboboxItem> mylist       = new List<ComboboxItem>();
            comboBox.Text                   = string.Empty;
            comboBox.Properties.Items.Clear();

            if (JsonData != null)
            {
                for (int i = 0; i < JsonData.Count; i++)
                {
                    ComboboxItem itm = new ComboboxItem();

                    var Ad      = JsonData[i].GetType().GetProperty("NameFirst").GetValue(JsonData[i]).ToString();
                    var Soyad   = JsonData[i].GetType().GetProperty("NameLast").GetValue(JsonData[i]).ToString();
                    var txt = Ad + " " + Soyad;
                    itm.Text    = txt;
                    itm.Value   = JsonData[i].GetType().GetProperty("Id").GetValue(JsonData[i]);
                    mylist.Add(itm);
                }
                var mylistOrderBy = mylist.OrderBy(x => x.Text).ToList();
                comboBox.Properties.Items.AddRange(mylistOrderBy);
            }
        }

        public static void LookUpEditDataFilling(object ListData, LookUpEdit lookUpEdit, object[] ShowValues)
        {

            lookUpEdit.Properties.Columns.Clear();

            lookUpEdit.Properties.DataSource = ListData;
            lookUpEdit.Properties.PopulateColumns();
            lookUpEdit.Properties.ValueMember = "Id";
            lookUpEdit.QueryPopUp += LookUpEdit_QueryPopUp;
            lookUpEdit.EditValue = null;

            if (lookUpEdit.Properties.Columns.Count > 0)
            {
                lookUpEdit.Properties.Columns["Id"].Visible = false;
            }

            //var Data = ListData;// _offers.Select(x => new { x.Name, x.Code, x.VerCode, x.Id }).ToList();

            lookUpEdit.Properties.CustomDisplayText += (sender, e) => Properties_CustomDisplayText(sender, e, ShowValues);
        }

        private static void LookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = sender as LookUpEdit;
            lookUpEdit.Properties.PopulateColumns();
            lookUpEdit.Properties.Columns["Id"].Visible = false;
        }

        private static void Properties_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e, object[] ShowValues)
        {
            RepositoryItemLookUpEdit props;
            if (sender is LookUpEdit)
                props = (sender as LookUpEdit).Properties;
            else
                props = sender as RepositoryItemLookUpEdit;

            if (props != null && (e.Value is long))
            {
                object row = props.GetDataSourceRowByKeyValue(e.Value);
                //var dt = props.get
                if (row == null)
                {
                    e.DisplayText = "---";
                }
                else
                {
                    if (row != null)
                    {
                        string txt = "";

                        for (int i = 0; i < ShowValues.Length; i++)
                        {
                            var propertyName = ShowValues[i].ToString();

                            if (row.GetType().GetProperty(propertyName) != null)
                            {
                                if (i == 0)
                                {
                                    if (row.GetType().GetProperty(propertyName).GetValue(row) != null)
                                    {
                                        txt = row.GetType().GetProperty(propertyName).GetValue(row).ToString();
                                    }
                               
                                }
                                else
                                {
                                    if (row.GetType().GetProperty(propertyName).GetValue(row) != null)
                                    {
                                        txt += "  " + row.GetType().GetProperty(propertyName).GetValue(row).ToString();
                                    }
                         
                                }
                            }
                            else
                            {
                                if (propertyName.ToString().StartsWith("#"))
                                {
                                    txt += "  " + propertyName.ToString().Replace("#", "");
                                }
                            }
                        }
                        //switch (tur)
                        //{
                        //    case LookUpEditTuru.Name:
                        //        txt = row.GetType().GetProperty("Name").GetValue(row).ToString();
                        //        break;
                        //    case LookUpEditTuru.Name_Code:
                        //        txt = row.GetType().GetProperty("Code").GetValue(row).ToString() + "   " + row.GetType().GetProperty("Name").GetValue(row).ToString();
                        //        break;
                        //    case LookUpEditTuru.Offer:
                        //        txt = row.GetType().GetProperty("Code").GetValue(row).ToString() + "   " + row.GetType().GetProperty("Name").GetValue(row).ToString();
                        //        break;
                        //    case LookUpEditTuru.Contact:
                        //        txt = row.GetType().GetProperty("NameFirst").GetValue(row).ToString() + "   " + row.GetType().GetProperty("NameLast").GetValue(row).ToString();
                        //        break;
                        //    case LookUpEditTuru.ShowCode:
                        //        txt = row.GetType().GetProperty("Code").GetValue(row).ToString();
                        //        break;
                        //    default:
                        //        break;
                        //}



                        e.DisplayText = txt; // row.GetType().GetProperty("Code").GetValue(row).ToString();  //String.Format("{0} {1}", ((DataRowView)row)["Code"].ToString(), ((DataRowView)row)["Name"].ToString());

                    }
                }
            }
        }


        private static void OpenFolder(string Path)
        {
            //Cursor = Cursors.WaitCursor;
            //if (Directory.Exists(Path))
            //{
            //    if (!string.IsNullOrEmpty(Path))
            //    {
            //        string myDocspath = txtOfferDirectory.Text; // Buraya istediğimiz dosyanın yolunu yazıyorz
            //        string windir = Environment.GetEnvironmentVariable("WINDIR");
            //        System.Diagnostics.Process prc = new System.Diagnostics.Process();
            //        prc.StartInfo.FileName = windir + @"\explorer.exe";
            //        prc.StartInfo.Arguments = myDocspath;
            //        prc.Start();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("İlgili Klasör yolu bulunamadı. Birden çok sebebi olabilir. Oluşturulan iş Server'a senkron edilmemiş ya da bilgisayarınız senkron olmayabilir.", "Klasör Bulunamadı");
            //}
            //Cursor = Cursors.Default;
        }

        public static T GetComboBoxVal<T>(object comboboxSelectedItem)
        {
            object val = new object();

            try
            {
                //ComboboxItem itm = new ComboboxItem();
                val = ((ComboboxItem)comboboxSelectedItem).Value;
            }
            catch (Exception)
            {
     
            }

            return (T)Convert.ChangeType(val, typeof(T));
        }
        public static List<T> ListDataFilling<T>(string uri)
        {
            ConnWebAPI.SET_Get(uri, out string json);
            var JsonData = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);

            if (JsonData != null)
            {
                return JsonData;
            }
            else
            {
                List<T> myList = new List<T>();
                return myList;
            }
        }
        public static void RowFocus(this GridView tablo, string aranacakKolon, object aranacakDeger)
        {
            var rowHendle = -2147483646;

            for (int i = 0; i < tablo.RowCount; i++)
            {
                var bulunanDeger = tablo.GetRowCellValue(i, aranacakKolon);

                if (aranacakDeger.Equals(bulunanDeger))
                {
                    rowHendle = i;
                }
            }

            tablo.FocusedRowHandle = rowHendle;
        }
        public static void SagMenuGoster(this MouseEventArgs e, PopupMenu sagMenu)
        {
            if (e.Button != MouseButtons.Right) return;
            sagMenu.ShowPopup(Control.MousePosition);
        }
        public static List<string> YazicilariListele()
        {
            return PrinterSettings.InstalledPrinters.Cast<string>().ToList();
        }
        public static string DefaultYazici()
        {
            var settings = new PrinterSettings();
            return settings.PrinterName;
        }


        public static void Keywords_ValidateToken(object sender, TokenEditValidateTokenEventArgs e)
        {
            e.IsValid = true;
            var a = e.Value; ;
        }
    }
}
