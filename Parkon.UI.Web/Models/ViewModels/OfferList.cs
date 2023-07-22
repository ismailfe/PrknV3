using Prkn.Model;
using Prkn.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prkn.UI.Web.Models.ViewModels
{
    public class OfferList
    {
        public string HeaderTitle { get; set; }
        public string FromController { get; set; }
        public string FromRoute { get; set; }
        public List<Offers> Prm { get; set; }
        public IslemTuru IslemTuru { get; set; }
        public List<DropDownModel> Offer_Status { get; set; }
        public List<DropDownModel> Offer_Type{ get; set; }
        public List<DropDownModel> Users { get; set; }
        public List<DropDownModel> Customers { get; set; }
        public List<DropDownModel> Customer_Section { get; set; }
        public List<DropDownModel> Currency { get; set; }
        public int OfferCount { get; set; }
        public int OfferSuccessCount { get; set; }
        public int OfferPreparationCount { get; set; }
        public int OfferNegativeCount { get; set; }
        public int OfferWaitingreplyCount { get; set; }
        public double OfferAcceptenceRate { get; set; }
        public double OfferNegativeRate { get; set; }
        public int OfferOtherResultCount { get; set; }
        public double OfferOtherResultRate { get; set; }
        public int? TableMode { get; set; }


    }
}