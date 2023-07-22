using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Base
{
    public class BaseStore_Product : BaseEntity
    {
        public long? BrandId { get; set; }
        public long? GroupId { get; set; }
        public long? TypeId { get; set; }
        public long? LocationId { get; set; }
        public long? AddressId { get; set; }
        public long? UnitId { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }
        public string ProductCodeFirstChar { get; set; }
        public string ProductCodeEndChar { get; set; }
        public string ProductIDFirstChar { get; set; }
        public string ProductIDEndChar { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Features { get; set; }
        public string Pic { get; set; }
        public string Score { get; set; }
        public string Info { get; set; }
        public string Keyword { get; set; }
    }
}
