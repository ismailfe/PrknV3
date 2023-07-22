using Prkn.UI.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prkn.UI.Web.Models.ViewModels
{
    public class Prm 
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Comment { get; set; }

    }
}