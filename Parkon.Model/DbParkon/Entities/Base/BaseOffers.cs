using Prkn.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Base
{
    public class BaseOffers : BaseEntity
    {
        public long? CustomerId { get; set; }
        public long? CustomerSectionId { get; set; }
        public long? CustomerContactId { get; set; }
        public long? OfferTypeId { get; set; }
        public long? OfferRequestTypeId { get; set; }
        public long? OfferRequestSourceId { get; set; }
        public long? OfferStatusId { get; set; }
        public long? OfferDetailsId { get; set; }
        public long? RefNo { get; set; }
        public string Code { get; set; }
     
        public string VerCode { get; set; }
        public string Name { get; set; }
        public DateTime? PreparationDate { get; set; }
        public int? ValidityPeriodWeek { get; set; }
        public string OfferContent { get; set; }
        public string ResultComment { get; set; }
        public DateTime? ResultDate { get; set; }

        public double? Price { get; set; }
        public double? TargetCost { get; set; }
        public double? RealCost { get; set; }

        //public double Price { get; set; }
        //public double TargetCost { get; set; }
        //public double RealCost { get; set; }
        public double? ExchangeRate { get; set; }
        public DateTime? ExchangeRateDate { get; set; }

        public long? CurrencyId { get; set; }
        public string Keyword { get; set; }
        public string Active { get; set; }
    }
}
