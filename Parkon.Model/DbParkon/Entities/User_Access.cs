using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model
{
    [Table("UserPrkn.User_Access")]
    public partial class User_Access : Base.BaseUser_Access
    {
        public virtual Users Users { get; set; }
    }
}
