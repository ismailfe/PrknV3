using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Store_AddressZone")]
    public partial class Store_AddressZone : Base.BaseStore_AddressZone
    {
        public Store_AddressZone()
        {
            Store_Address = new HashSet<Store_Address>();
        }

        public virtual ICollection<Store_Address> Store_Address { get; set; }
        public virtual Users Users { get; set; }
    }
}
