using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prkn.UI.Web.Models.ViewModels
{
    public class Authorization_List
    {
        public string HeaderTitle { get; set; }
        public string FromController { get; set; }
        public string FromRoute { get; set; }
        public List<AuthorizationModel> PrmGroup { get; set; }
        public List<AuthorizationModel> PrmUsers { get; set; }
    }
}