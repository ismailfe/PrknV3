using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prkn.UI.Web.Models.ViewModels
{
    public class MediaModel
    {
        public List<ObjFile> ObjFile1 { get; set; }
        public string FileNameOfferCode { get; set; }
        public string FileNameVerCode { get; set; }
        public string OfferName { get; set; }
        public long Id { get; set; }
        public string HeaderTitle { get; internal set; }
        public string FromController { get; internal set; }
        public string FromRoute { get; internal set; }
    }
    public class ObjFile
    {
        public IEnumerable<HttpPostedFileBase> files { get; set; }
        public string File { get; set; }
        public long Size { get; set; }
        public string Type { get; set; }
        public DateTime UploadDate { get; set; }
        public long Id { get; set; }
    }
}