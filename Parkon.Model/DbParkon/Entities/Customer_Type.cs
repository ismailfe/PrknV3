using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Customer_Type")]
    public partial class Customer_Type : Base.BaseCustomer_Type
    {
        public Customer_Type()
        {
            Customers = new HashSet<Customers>();
        }

        public virtual Users Users { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
    }
}

