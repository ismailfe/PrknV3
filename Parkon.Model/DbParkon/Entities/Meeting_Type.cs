using Prkn.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Meeting_Type")]
    public partial class Meeting_Type : Base.BaseMeeting_Type
    {
        public virtual Users Users { get; set; }
    }
}
