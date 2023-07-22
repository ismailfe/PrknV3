using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model
{
    [Table("UserPrkn.Store_Location")]
    public partial class Store_Location : Base.BaseStore_Location
    {
        public Store_Location()
        {
            Store_Product = new HashSet<Store_Product>();
        }

        public virtual Users Users { get; set; }
        public virtual ICollection<Store_Product> Store_Product { get; set; }
    }
}
