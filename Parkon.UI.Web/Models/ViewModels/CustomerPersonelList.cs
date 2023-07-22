using Prkn.Model;
using Prkn.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prkn.UI.Web.Models.ViewModels
{
    public class CustomerPersonelList
    {
        public string HeaderTitle { get; set; }
        public string FromController { get; set; }
        public string FromRoute { get; set; }
        public List<Customer_Contact> Prm { get; set; }
        public IslemTuru IslemTuru { get; set; }
        public List<DropDownModel> Customer { get; set; }
        public List<DropDownModel> Title { get; set; }
    }
}