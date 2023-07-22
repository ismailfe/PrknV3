using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model
{
    [Table("UserPrkn.Store_Warehouse")]
    public partial class Store_Warehouse : Base.BaseStore_Warehouse
    {
        public virtual Store_Product Store_Product { get; set; }
        public virtual Store_ProductBlock Store_ProductBlock { get; set; }
        public virtual Users Users { get; set; }
    }
}
