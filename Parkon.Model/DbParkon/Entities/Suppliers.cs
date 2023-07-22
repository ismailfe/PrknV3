using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model
{
    [Table("UserPrkn.Suppliers")]
    public partial class Suppliers : Base.BaseSuppliers
    {
        public Suppliers()
        {
            Supplier_Contact = new HashSet<Supplier_Contact>();
            Supplier_Section = new HashSet<Supplier_Section>();
        }

        public virtual ICollection<Supplier_Contact> Supplier_Contact { get; set; }
        public virtual ICollection<Supplier_Section> Supplier_Section { get; set; }
        public virtual Supplier_Type Supplier_Type { get; set; }
        public virtual Users Users { get; set; }
        public virtual Zone Zone { get; set; }
    }
}
