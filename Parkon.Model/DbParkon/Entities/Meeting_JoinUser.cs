using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model
{
    [Table("UserPrkn.Meeting_JoinUser")]
    public partial class Meeting_JoinUser : Base.BaseMeeting_JoinUser
    {
        public virtual Users Users { get; set; }
    }
}
