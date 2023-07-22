using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Store_AddressPos")]
    public partial class Store_AddressPos : Base.BaseStore_AddressPos
    {
        public Store_AddressPos()
        {
            Store_Address = new HashSet<Store_Address>();
        }
  
        public virtual ICollection<Store_Address> Store_Address { get; set; }
        public virtual Users Users { get; set; }
    }
}
