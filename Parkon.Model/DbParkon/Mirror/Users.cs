using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Mirror
{
    [Table("UserPrkn.Users")]
    public partial class Users : Base.BaseUsers
    {
    }
}
