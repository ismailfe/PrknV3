using Prkn.Common.Enums;
using Prkn.UI.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prkn.UI.Web.Models.ViewModels
{
    public class ParametersEdit
    {
        public string HeaderTitle { get; set; }
        public IslemTuru IslemTuru {get; set;}
        public string FromController { get; set; }
        public string FromRoute { get; set; }
        public Prm Prm { get; set; }

        public string JobStatus { get; set; }

    }
}