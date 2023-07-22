using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Title")]
    public partial class Title : Base.BaseTitle
    {
        public Title()
        {
            Customer_Contact = new HashSet<Customer_Contact>();
            Supplier_Contact = new HashSet<Supplier_Contact>();
            Users1 = new HashSet<Users>();
        }

        public virtual ICollection<Customer_Contact> Customer_Contact { get; set; }
        public virtual ICollection<Supplier_Contact> Supplier_Contact { get; set; }
        public virtual Users Users { get; set; }
        public virtual ICollection<Users> Users1 { get; set; }
    }
}
