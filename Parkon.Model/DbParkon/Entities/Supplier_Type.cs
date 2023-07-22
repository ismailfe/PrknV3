using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model
{

    [Table("UserPrkn.Supplier_Type")]
    public partial class Supplier_Type : Base.BaseSupplier_Type
    {
        public Supplier_Type()
        {
            Suppliers = new HashSet<Suppliers>();
        }

        public virtual Users Users { get; set; }
        public virtual ICollection<Suppliers> Suppliers { get; set; }
    }
}
