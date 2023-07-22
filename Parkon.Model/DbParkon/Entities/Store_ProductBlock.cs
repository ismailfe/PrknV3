using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model
{
    [Table("UserPrkn.Store_ProductBlock")]
    public partial class Store_ProductBlock : Base.BaseStore_ProductBlock
    {
        public Store_ProductBlock()
        {
            Store_Warehouse = new HashSet<Store_Warehouse>();
            Store_WarehouseOut = new HashSet<Store_WarehouseOut>();
        }

        public virtual ICollection<Store_Warehouse> Store_Warehouse { get; set; }
        public virtual ICollection<Store_WarehouseOut> Store_WarehouseOut { get; set; }
    }
}
