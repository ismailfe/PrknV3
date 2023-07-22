using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{

    [Table("UserPrkn.User_Department")]
    public partial class User_Department : Base.BaseUser_Department
    {
        public User_Department()
        {
            Users1 = new HashSet<Users>();
        }

        public virtual Users Users { get; set; }
        public virtual ICollection<Users> Users1 { get; set; }
    }
}
