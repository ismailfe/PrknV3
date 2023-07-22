using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Store_Address")]
    public partial class Store_Address : Base.BaseStore_Address
    {
        public Store_Address()
        {
            Store_Product = new HashSet<Store_Product>();
        }

        public virtual Store_AddressCol Store_AddressCol { get; set; }
        public virtual Store_AddressPos Store_AddressPos { get; set; }
        public virtual Store_AddressRow Store_AddressRow { get; set; }
        public virtual Store_AddressZone Store_AddressZone { get; set; }
        public virtual Users Users { get; set; }
        public virtual ICollection<Store_Product> Store_Product { get; set; }
    }
}
