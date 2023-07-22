using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Store_AddressRow")]
    public partial class Store_AddressRow : Base.BaseStore_AddressRow
    {
        public Store_AddressRow()
        {
            Store_Address = new HashSet<Store_Address>();
        }

        public virtual ICollection<Store_Address> Store_Address { get; set; }
        public virtual Users Users { get; set; }
    }
}
