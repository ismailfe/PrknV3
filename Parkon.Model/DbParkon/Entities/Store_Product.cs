using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Store_Product")]
    public partial class Store_Product : Base.BaseStore_Product
    {
        public Store_Product()
        {
            Store_Warehouse = new HashSet<Store_Warehouse>();
            Store_WarehouseOut = new HashSet<Store_WarehouseOut>();
        }

        public virtual Store_Address Store_Address { get; set; }
        public virtual Store_Location Store_Location { get; set; }
        public virtual Store_ProductGroup Store_ProductGroup { get; set; }
        public virtual Store_ProductType Store_ProductType { get; set; }
        public virtual Store_ProductUnit Store_ProductUnit { get; set; }
        public virtual Users Users { get; set; }
        public virtual ICollection<Store_Warehouse> Store_Warehouse { get; set; }
        public virtual ICollection<Store_WarehouseOut> Store_WarehouseOut { get; set; }
    }
}
