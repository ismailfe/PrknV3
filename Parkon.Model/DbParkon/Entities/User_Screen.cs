using Prkn.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{


    [Table("UserPrkn.User_Screen")]
    public class User_Screen : Base.BaseUser_Screen
    {
        public virtual Users Users { get; set; }
    }
}
