using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Mirror
{
    [Table("UserPrkn.Customer_Section")]
    public partial class Customer_Section : Base.BaseCustomer_Section
    {
        public Customer_Section()
        {
        }
    }
}
