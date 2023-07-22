using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model.Mirror
{
    [Table("UserPrkn.User_Level")]
    public partial class User_Level : Base.BaseUser_Level
    {
    }
}
