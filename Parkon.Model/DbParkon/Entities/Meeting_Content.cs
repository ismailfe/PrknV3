using Prkn.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Meeting_Content")]
    public partial class Meeting_Content : Base.BaseMeeting_Content
    {
        public virtual Users Users { get; set; }
    }
}
