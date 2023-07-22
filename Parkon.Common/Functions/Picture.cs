using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Camera;
using Prkn.Common.Enums;
using Prkn.Common.Functions;
using Prkn.Common.Variables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prkn.Common.Functions
{
    public class Picture
    {

        #region IMAGE
        //static string _newPictureName         = string.Empty;
        //static string _newPicturePath          = string.Empty;
        static OpenFileDialog PicSec           = new OpenFileDialog();

        public static Image PictureSelectWithDialog(out string[] result)
        {
            PicSec.Filter           = "Image Files|*.jpg;*.jpeg;*.png;...";
            result                  = new string[2];
            PictureEdit Pic         = new PictureEdit();

            if (PicSec.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi     = new FileInfo(PicSec.FileName);
                long fileSize   = fi.Length; //The size of the current file in bytes.file 

                if (fileSize > 1024 * 1024 * 3) //65535)
                {
                    MessageBox.Show("Seçtiğiniz image boyutu 3MB üzerinde görünüyor. Lütfen 3MB altında bir image seçin.", "HATA");
                }
                else
                {
                    Pic.Image               = Image.FromFile(PicSec.FileName);
                    result[0]               = PicSec.FileName;
                    result[1]               = Static.CreateNewNameViaDate(PicSec);
                   
                }
            }

            return Pic.Image;
        }
        public static Image PictureSelect(string imgPath, out string[] result)
        {
            result = new string[2];
            PictureEdit Pic             = new PictureEdit();
            OpenFileDialog secim        = new OpenFileDialog();

            if (imgPath != null)
            {
                FileInfo fi             = new FileInfo(imgPath);
                long fileSize           = fi.Length; //The size of the current file in bytes.file 

                if (fileSize > 1024 * 1024 * 3) //65535)
                {
                    MessageBox.Show("Seçtiğiniz image boyutu 3MB üzerinde görünüyor. Lütfen 3MB altında bir image seçin.", "HATA");
                }
                else
                {
                    secim.FileName      = imgPath;
                    Pic.Image           = Image.FromFile(secim.FileName);
                    result[0]           = secim.FileName;
                    result[1]           = Static.CreateNewNameViaDate(secim);
                }
            }

            return Pic.Image;
        }
        public static string PictureUpload(string uri, string picturePath, string pictureName)
        {
            try
            {
                return ConnWebAPI.UploadImage(uri, picturePath, pictureName, out string StatusCode);
            }
            catch (Exception HATA)
            {
                return "Select - No Image or Error: " + HATA.ToString();
            }
        }

        /// <summary>
        /// Kameradan çekilen fotoyu TempImg 'ye kaydeder.
        /// Geriye string array döndürür.
        /// 0. index => Path
        /// 1. index => FileName
        /// </summary>
        /// <returns></returns>
        public static string[] TakePicture()
        {
            TakePictureDialog takePictureDialog = new TakePictureDialog();
            TakePictureForm pictureForm         = new TakePictureForm(takePictureDialog);
            pictureForm.Size                    = new Size(700, 520);
            string[] imgPath = new string[2];

            pictureForm.ShowDialog();
            if (pictureForm.DialogResult == DialogResult.OK)
            {
                Image img               = takePictureDialog.Image;
                Static.CreateNewNameViaDate(PicSec);
                imgPath[0]              = Static.CreateDateName() + ".jpg";
                imgPath[1]              = Global.ProgramDizin.ProgramData_Path_Temp_TakeImg + imgPath[0];

                img.Save(imgPath[1]);
            }

            return imgPath;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PicName"></param>
        /// <param name="Type">
        /// User, Customer, Product, Supplier, Brand</param>
        /// <returns></returns>
        public static string GetImageSource(string PicName, PictureSourceType Type)
        {
            string PicPath = Global.ProgramDizin.ProgramData_Path_Temp_Img + PicName;
            if (!File.Exists(PicPath))
            {
                switch (Type)
                {
                    case PictureSourceType.User:
                        ConnWebAPI.DownloadImage(Var_JSON.URI.Image_User_Download, PicName, Global.ProgramDizin.ProgramData_Path_Temp_Img);
                        break;
                    case PictureSourceType.Customer:
                        ConnWebAPI.DownloadImage(Var_JSON.URI.Image_Customer_Download, PicName, Global.ProgramDizin.ProgramData_Path_Temp_Img);
                        break;
                    case PictureSourceType.Product:
                        ConnWebAPI.DownloadImage(Var_JSON.URI.Image_Product_Download, PicName, Global.ProgramDizin.ProgramData_Path_Temp_Img);
                        break;
                    case PictureSourceType.Supplier:
                        ConnWebAPI.DownloadImage(Var_JSON.URI.Image_Supplier_Download, PicName, Global.ProgramDizin.ProgramData_Path_Temp_Img);
                        break;
                    case PictureSourceType.Brand:
                        ConnWebAPI.DownloadImage(Var_JSON.URI.Image_Brand_Download, PicName, Global.ProgramDizin.ProgramData_Path_Temp_Img);
                        break;
                }
                Thread.Sleep(1000);
            }

            return PicPath;
        }
        #endregion


    }
}
