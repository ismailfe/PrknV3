using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model.Base
{
    public class BaseSupplier_Section : BaseEntity
    {
        public long? SupplierId { get; set; }
        public long? ZoneId { get; set; }
        public int? No { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Maps { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Pic { get; set; }
        public string Score { get; set; }
        public string Info { get; set; }
        public string Keyword { get; set; }
    }
}
