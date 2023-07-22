using Prkn.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Supplier_Contact")]
    public partial class Supplier_Contact : Base.BaseSupplier_Contact
    {
        public virtual Suppliers Suppliers { get; set; }
        public virtual Title Title { get; set; }
        public virtual Users Users { get; set; }
    }
}
