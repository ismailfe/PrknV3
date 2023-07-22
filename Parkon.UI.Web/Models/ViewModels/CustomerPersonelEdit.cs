using Prkn.Model;
using Prkn.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prkn.UI.Web.Models.ViewModels
{
    public class CustomerPersonelEdit
    {
        public IslemTuru IslemTuru { get; set; }
        public string HeaderTitle { get; set; }
        public string FromController { get; set; }
        public string FromRoute { get; set; }
        public Customer_Contact Prm { get; set; }
        public string JobStatus { get; set; }
        public string ModalMessage { get; set; }
        public string ModalStatus { get; set; }
        public string ModalTitle { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
        public List<DropDownModel> Customer { get; set; }
        public List<DropDownModel> Title { get; set; }
    }
}