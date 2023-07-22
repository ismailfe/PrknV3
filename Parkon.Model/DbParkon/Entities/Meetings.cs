using Prkn.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Meetings")]
    public partial class Meetings : Base.BaseMeetings
    {
        public virtual Users Users { get; set; }
    }
}
