using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Customer_Contact")]
    public partial class Customer_Contact : Base.BaseCustomer_Contact
    {
        public Customer_Contact()
        {
            Project_Rev = new HashSet<Project_Rev>();
            Projects = new HashSet<Projects>();
            Offers = new HashSet<Offers>();
        }

        public virtual Customers Customers { get; set; }
        public virtual Title Title { get; set; }
        public virtual Users Users { get; set; }

        public virtual ICollection<Project_Rev> Project_Rev { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<Offers> Offers { get; set; }
    }
}
