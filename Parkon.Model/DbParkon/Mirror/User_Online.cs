using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Mirror
{
    [Table("UserPrkn.User_Online")]
    public partial class User_Online : Base.BaseUser_Online
    {
    }
}
