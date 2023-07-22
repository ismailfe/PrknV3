using Prkn.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model.Mirror
{
    [Table("UserPrkn.Meeting_Status")]
    public partial class Meeting_Status : Base.BaseMeeting_Status
    {
    }
}
