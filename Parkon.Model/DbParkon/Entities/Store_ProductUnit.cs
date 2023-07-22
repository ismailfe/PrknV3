using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model
{
    [Table("UserPrkn.Store_ProductUnit")]
    public partial class Store_ProductUnit : Base.BaseStore_ProductUnit
    {
        public Store_ProductUnit()
        {
            Store_Product = new HashSet<Store_Product>();
        }

        public virtual ICollection<Store_Product> Store_Product { get; set; }
        public virtual Users Users { get; set; }
    }
}
