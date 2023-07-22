using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model.Base
{
    public class BaseStore_Warehouse : BaseEntity
    {
        public long? ProductId { get; set; }
        public long? BlockId { get; set; }
        public string SerialNo { get; set; }
        public string RefNo { get; set; }
        public string StockNo { get; set; }
        public string StockNoAux { get; set; }
        public string Status { get; set; }
        public string PriceList { get; set; }
        public string PriceListCurrency { get; set; }
        public string PricePurchase { get; set; }
        public string PricePurchaseCurrency { get; set; }
        public string PriceSale { get; set; }
        public string PriceSaleCurrency { get; set; }
        public string PercentageTax { get; set; }
        public string PercentageDiscount { get; set; }
    }
}
