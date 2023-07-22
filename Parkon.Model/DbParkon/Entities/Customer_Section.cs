using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Customer_Section")]
    public partial class Customer_Section : Base.BaseCustomer_Section
    {
        public Customer_Section()
        {
            Projects = new HashSet<Projects>();
            Offers = new HashSet<Offers>();
        }

        public virtual Customers Customers { get; set; }
        public virtual Zone Zone { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<Offers> Offers { get; set; }
    }
}
