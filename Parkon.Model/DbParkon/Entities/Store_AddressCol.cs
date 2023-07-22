using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model
{
    [Table("UserPrkn.Store_AddressCol")]
    public partial class Store_AddressCol :Base.BaseStore_AddressCol
    {
        public Store_AddressCol()
        {
            Store_Address = new HashSet<Store_Address>();
        }


        public virtual ICollection<Store_Address> Store_Address { get; set; }
        public virtual Users Users { get; set; }
    }
}
