using Prkn.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Store_WarehouseOut")]
    public partial class Store_WarehouseOut : Base.BaseStore_WarehouseOut
    {
        public virtual Store_Product Store_Product { get; set; }
        public virtual Store_ProductBlock Store_ProductBlock { get; set; }
        public virtual Users Users { get; set; }
    }
}
