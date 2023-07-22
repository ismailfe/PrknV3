using Prkn.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Store_Brand")]
    public partial class Store_Brand : Base.BaseStore_Brand
    {
        public virtual Users Users { get; set; }
    }
}
