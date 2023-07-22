using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Mirror
{

    [Table("UserPrkn.User_Authorization")]
    public partial class User_Authorization : Base.BaseUser_Authorization
    {
    }
}
