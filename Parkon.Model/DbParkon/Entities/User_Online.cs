using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.User_Online")]
    public partial class User_Online : Base.BaseUser_Online
    {
        public User_Online()
        {
            Users1 = new HashSet<Users>();
        }
        
        public virtual Users Users { get; set; }
        public virtual ICollection<Users> Users1 { get; set; }
    }
}
