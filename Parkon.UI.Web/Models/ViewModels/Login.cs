using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prkn.UI.Web.Models.ViewModels
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mesaj { get; set; }
        public bool LoginError { get; set; }
        public string HeaderTitle { get; set; }
        public string FromController { get; set; }
        public string FromRoute { get; set; }

    }
}