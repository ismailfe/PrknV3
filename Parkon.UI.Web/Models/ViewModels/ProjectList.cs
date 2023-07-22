using Prkn.Model;
using Prkn.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prkn.UI.Web.Models.ViewModels
{
    public class ProjectList
    {
        public string HeaderTitle { get; set; }
        public string FromController { get; set; }
        public string FromRoute { get; set; }
        public List<Projects> Prm { get; set; }
        public IslemTuru IslemTuru { get; set; }
        public List<DropDownModel> Project_Status { get; set; }
        public List<DropDownModel> Users { get; set; }
        public List<DropDownModel> Customers { get; set; }
        public List<DropDownModel> Customer_Section { get; set; }
        public List<DropDownModel> Currency { get; set; }
        public int ProjectCount { get; set; }
        public int ProjectSuccessCount { get; set; }
        public int ProjectPreparationCount { get; set; }
        public int ProjectNegativeCount { get; set; }
        public int ProjectWaitingreplyCount { get; set; }
        public double ProjectAcceptenceRate { get; set; }
        public double ProjectNegativeRate { get; set; }
        public int ProjectOtherResultCount { get; set; }
        public double ProjectOtherResultRate { get; set; }
        public int? TableMode { get; set; }
    }
}