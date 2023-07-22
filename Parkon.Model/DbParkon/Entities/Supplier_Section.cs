using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model
{
    [Table("UserPrkn.Supplier_Section")]
    public partial class Supplier_Section : Base.BaseSupplier_Section
    {
        public virtual Suppliers Suppliers { get; set; }
        public virtual Users Users { get; set; }
        public virtual Zone Zone { get; set; }
    }
}
