using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Customers")]
    public partial class Customers : Base.BaseCustomers
    {
        public Customers()
        {
            Customer_Contact = new HashSet<Customer_Contact>();
            Customer_Section = new HashSet<Customer_Section>();
            Projects = new HashSet<Projects>();
            Offers = new HashSet<Offers>();
        }

        [Required(ErrorMessage = "Boþ Býralamazsýn!")]
        public override string Name { get; set; }

        public virtual ICollection<Customer_Contact> Customer_Contact { get; set; }
        public virtual ICollection<Customer_Section> Customer_Section { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<Offers> Offers { get; set; }

        public virtual Customer_Type Customer_Type { get; set; }
        public virtual Users Users { get; set; }
        public virtual Zone Zone { get; set; }
    }
}
