using Prkn.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.SoftwareVersion")]
    public partial class SoftwareVersion : Base.BaseSoftwareVersion
    {
        public virtual Users Users { get; set; }
    }
}
