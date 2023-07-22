using Prkn.Bll.Master.PrknDataBll.Offer;
using Prkn.UI.Web.Functions;
using Prkn.UI.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prkn.UI.Web.Controllers
{
    [RoutePrefix("Media")]

    public class MediaController : Controller
    {
        // GET: Media
        [Route("DosyaYukle/{Id?}")]
        [HttpGet]
        public ActionResult Dosya_Yukle_Indir(long Id=0)
        {
            var getBll = new OfferBll();

            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            var parameters = new MediaModel();

            //___Offer tablosundan verileri çekip sayfaya gönderdiğimiz modele yazıyoruz
            parameters.FileNameOfferCode = getData.Code;
            parameters.FileNameVerCode = getData.VerCode;
            parameters.OfferName = getData.Name;
            parameters.Id = Id;
            //____
            //Klasör yolumuzu oluşturuyoruz
            string mainPath = Server.MapPath("~/Files/Teklif/" + parameters.FileNameOfferCode + "/" + parameters.FileNameVerCode + "/");
            if (!Directory.Exists(mainPath))
            {
                //klasör yoksa oluşturalım                
                Directory.CreateDirectory(mainPath);
            }

            List<ObjFile> ObjFiles = new List<ObjFile>();

            foreach (string strfile in Directory.GetFiles(mainPath))
            {
                FileInfo fi = new FileInfo(strfile);
                ObjFile obj = new ObjFile();

                obj.File = fi.Name;
                obj.Size = fi.Length;
                obj.Type = GetFileTypeByExtension(fi.Extension);
                obj.UploadDate = fi.CreationTime;
                ObjFiles.Add(obj);
            }
            parameters.ObjFile1 = ObjFiles;

            parameters.HeaderTitle = "DOSYA İŞLEMLERİ";
            parameters.FromController = "Media";
            parameters.FromRoute = "DosyaYukle";

            return View(parameters);
        }
        [Route("Download")]
        public FileResult Download(string fileName,string path)
        {
            string fullPath = Path.Combine(Server.MapPath("~/Files/Teklif/"+path+"/"), fileName);
            byte[] fileBytes = System.IO.File.ReadAllBytes(fullPath);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        private string GetFileTypeByExtension(string fileExtension)
        {
            switch (fileExtension.ToLower())
            {
                case ".docx":
                case ".doc":
                    return "Microsoft Word Document";
                case ".xlsx":
                case ".xls":
                    return "Microsoft Excel Document";
                case ".txt":
                    return "Text Document";
                case ".jpg":
                case ".png":
                    return "Image";
                case ".rar":
                    return "Winrar";
                case ".zip":
                    return "Winrar";
                default:
                    return "Unknown";
            }
        }
        [Route("DosyaYukle")]
        [HttpPost]
        public ActionResult Dosya_Yukle_Indir(ObjFile doc, MediaModel parameters)
        {

            //Klasör yolumuzu oluşturuyoruz
            string mainPath = Server.MapPath("~/Files/Teklif/" + parameters.FileNameOfferCode + "/" + parameters.FileNameVerCode + "/");

            if (!Directory.Exists(mainPath))
            {
                //klasör yoksa oluşturalım                
                Directory.CreateDirectory(mainPath);
            }

            foreach (var file in doc.files)
            {

                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var filePath = Path.Combine(mainPath, fileName);
                    file.SaveAs(filePath);
                }
            }
            TempData["Message"] = "Dosya Yükleme Başarılı";
            return RedirectToAction("DosyaYukle/"+parameters.Id,"Media");
        }

    }
}

