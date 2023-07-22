using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Prkn.Model
{
    [Table("UserPrkn.Store_ProductType")]
    public partial class Store_ProductType : Base.BaseStore_ProductType
    {
        public Store_ProductType()
        {
            Store_Product = new HashSet<Store_Product>();
        }

        public virtual ICollection<Store_Product> Store_Product { get; set; }
        public virtual Users Users { get; set; }
    }
}
