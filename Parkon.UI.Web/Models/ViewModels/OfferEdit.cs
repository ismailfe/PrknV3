using Prkn.Model;
using Prkn.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prkn.UI.Web.Models.ViewModels
{
    public class OfferEdit
    {
        public IslemTuru IslemTuru { get; set; }
        public string HeaderTitle { get; set; }
        public string FromController { get; set; }
        public string FromRoute { get; set; }
        public Offers Prm { get; set; }
        public string JobStatus { get; set; }
        public int Versiyon { get; set; }
        public double DolarTL { get; set; }
        public double EuroTL { get; set; }
        public string ModalMessage { get; set; }
        public string ModalStatus { get; set; }
        public string ModalTitle { get; set; }
        public string disabled { get; set; }
        public int PreparingTypeId { get; set; }
        public List<DropDownModel> PreparingType { get; set; }
        public List<DropDownModel> Customer { get; set; }
        public List<DropDownModel> CustomerSection { get; set; }
        public List<DropDownModel> CustomerContact { get; set; }
        public List<DropDownModel> OfferRequestSource { get; set; }
        public List<DropDownModel> OfferRequestType { get; set; }
        public List<DropDownModel> OfferType { get; set; }
        public List<DropDownModel> OfferStatus { get; set; }
        public List<DropDownModel> Currency { get; set; }


    }

}