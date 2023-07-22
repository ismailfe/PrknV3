using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using Prkn.Common.Enums;
using Prkn.Common.Message;
using Prkn.Common.Variables;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Prkn.UI.Win.Functions
{
    public static class FileFunctions
    {
        private static string filePathSablon = Global.ProgramDizin.ProgramData_Path_SablonDosyalari; // + @"\Sablon Dosyaları";
        private static string filePathExport = Global.ProgramDizin.ProgramData_Path_ExportFile; // + @"\TempExport";

        public static void FormSablonKaydet(this string SablonAdi, int left, int top, int width, int height, FormWindowState windowState)
        {
            try
            {

                if (!Directory.Exists(filePathSablon))
                {
                    Directory.CreateDirectory(filePathSablon);
                    //File.SetAttributes(filePathSablon, FileAttributes.Normal);
                }

                var settings = new XmlWriterSettings { Indent = true };
                var writer = XmlWriter.Create(filePathSablon  + SablonAdi + "_location.xml", settings);

                writer.WriteStartDocument();

                writer.WriteComment("IDEMIR");

                writer.WriteStartElement("Tablo");
                writer.WriteStartElement("Location");
                writer.WriteAttributeString("Left", left.ToString());
                writer.WriteAttributeString("Top", top.ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("FormSize");
                if (windowState == FormWindowState.Maximized)
                {
                    writer.WriteAttributeString("Width", "-1");
                    writer.WriteAttributeString("Height", "-1");
                }
                else
                {
                    writer.WriteAttributeString("Width", width.ToString());
                    writer.WriteAttributeString("Height", height.ToString());
                }
                writer.WriteEndElement();
                writer.WriteEndElement(); //Tabloyu Kapat
                writer.WriteEndDocument(); // Dosyayı Kapat
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }
        }
        public static void FormSablonYukle(this string sablonAdi, XtraForm frm)
        {
            var list = new List<string>();
            try
            {
                string readerPath = filePathSablon + sablonAdi + "_location.xml";
                if (File.Exists(readerPath))
                {
                    var reader = XmlReader.Create(readerPath);

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Location")
                        {
                            list.Add(reader.GetAttribute(0)); // Left
                            list.Add(reader.GetAttribute(1)); // Top
                        }

                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "FormSize")
                        {
                            list.Add(reader.GetAttribute(0)); // width
                            list.Add(reader.GetAttribute(1)); // height
                        }
                    }

                    reader.Close();
                    reader.Dispose();
                }

            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }

            if (list.Count <= 0) return;
            frm.Location = new System.Drawing.Point(int.Parse(list[0]), int.Parse(list[1]));

            if (list[2] == "-1" && list[3] == "-1")
                frm.WindowState = FormWindowState.Maximized;
            else
                frm.Size = new System.Drawing.Size(int.Parse(list[2]), int.Parse(list[3]));

        }

        public static void TabloSablonKaydet(this GridView tablo, string sablonAdi)
        {
            try
            {
                //tablo.ClearColumnsFilter();


                if (!Directory.Exists(filePathSablon))
                {
                    Directory.CreateDirectory(filePathSablon);
                    //File.SetAttributes(filePathSablon, FileAttributes.Normal);
                }

                tablo.SaveLayoutToXml(filePathSablon + sablonAdi + ".xml");

            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }
        }
        public static void TabloSablonYukle(this GridView tablo, string sablonAdi)
        {
            try
            {
                string readerPath = filePathSablon + sablonAdi + ".xml";
                if (File.Exists(readerPath))
                {
                    tablo.RestoreLayoutFromXml(readerPath);
                }

            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }
        }

        public static bool TabloSablonSil(this GridView tablo, string sablonAdi)
        {
            try
            {
                string readerPath = filePathSablon + sablonAdi + ".xml";
                if (File.Exists(readerPath))
                {
                    File.Delete(readerPath);
                    MessageBox.Show("Filtre Şablonu silindi. Varsayılan görünüme dönmek için sayfayı yeniden açın.", "Filtre Temizlendi");
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
                return false;
            }
        }

        public static void TabloDisariAktar(this GridView tablo, DosyaTuru dosyaturu, string dosyaFormati, string excelSayfaAdi = null)
        {
            if (Messages.TabloExportMesaj(dosyaFormati) != DialogResult.Yes) return;


            if (!Directory.Exists(filePathExport))
            {
                Directory.CreateDirectory(filePathExport);
            }

            var dosyaAdi = Guid.NewGuid().ToString();
            var filePath = filePathExport + $@"\{dosyaAdi}";

            switch (dosyaturu)
            {
                case DosyaTuru.ExcelStandart:
                    {
                        var opt = new XlsxExportOptionsEx
                        {
                            ExportType = DevExpress.Export.ExportType.Default,
                            SheetName = excelSayfaAdi,
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".xlsx";
                        tablo.ExportToXlsx(filePath, opt);
                    }
                    break;
                case DosyaTuru.ExcelFormatli:
                    {
                        var opt = new XlsxExportOptionsEx
                        {
                            ExportType = DevExpress.Export.ExportType.WYSIWYG,
                            SheetName = excelSayfaAdi,
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".xlsx";
                        tablo.ExportToXlsx(filePath, opt);
                    }
                    break;
                case DosyaTuru.ExcelFormatsiz:
                    {
                        var opt = new CsvExportOptionsEx
                        {
                            ExportType = DevExpress.Export.ExportType.WYSIWYG,
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".csv";
                        tablo.ExportToCsv(filePath, opt);
                    }
                    break;
                case DosyaTuru.WordDosyasi:
                    {
                        filePath = filePath + ".docx";
                        tablo.ExportToDocx(filePath);
                    }
                    break;
                case DosyaTuru.PdfDosyasi:
                    {
                        filePath = filePath + ".pdf";
                        tablo.ExportToPdf(filePath);
                    }
                    break;
                case DosyaTuru.TxtDosyasi:
                    {
                        var opt = new TextExportOptions
                        {
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".txt";
                        tablo.ExportToText(filePath, opt);
                    }
                    break;
            }

            if (!File.Exists(filePath))
            {
                Messages.HataMesaji("Tablo verileri dosyaya aktarılamadı.");
                return;
            }

            Process.Start(filePath);
        }
    }
}
