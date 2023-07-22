using Prkn.Model;
using Prkn.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prkn.UI.Web.Models.ViewModels
{
    public class UserList
    {
        public string HeaderTitle { get; set; }
        public string FromController { get; set; }
        public string FromRoute { get; set; }
        public List<Users> Prm { get; set; }
        public IslemTuru IslemTuru { get; set; }
        public List<DropDownModel> Title { get; set; }
        public List<DropDownModel> Department { get; set; }
    }
}