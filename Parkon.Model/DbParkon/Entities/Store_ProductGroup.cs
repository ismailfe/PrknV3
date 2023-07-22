using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model
{
    [Table("UserPrkn.Store_ProductGroup")]
    public partial class Store_ProductGroup : Base.BaseStore_ProductGroup
    {
        public Store_ProductGroup()
        {
            Store_Product = new HashSet<Store_Product>();
        }


        public virtual ICollection<Store_Product> Store_Product { get; set; }
        public virtual Users Users { get; set; }
    }
}
