using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Zone")]
    public partial class Zone : Base.BaseZone
    {
        public Zone()
        {
            Customer_Section = new HashSet<Customer_Section>();
            Customers = new HashSet<Customers>();
            Supplier_Section = new HashSet<Supplier_Section>();
            Suppliers = new HashSet<Suppliers>();
        }

        public virtual ICollection<Customer_Section> Customer_Section { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Supplier_Section> Supplier_Section { get; set; }
        public virtual ICollection<Suppliers> Suppliers { get; set; }
        public virtual Users Users { get; set; }
    }
}
