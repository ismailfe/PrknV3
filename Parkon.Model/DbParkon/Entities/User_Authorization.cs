using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{

    [Table("UserPrkn.User_Authorization")]
    public partial class User_Authorization : Base.BaseUser_Authorization
    {
        public User_Authorization()
        {
            Users2 = new HashSet<Users>();
        }

        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
        public virtual ICollection<Users> Users2 { get; set; }
    }
}
