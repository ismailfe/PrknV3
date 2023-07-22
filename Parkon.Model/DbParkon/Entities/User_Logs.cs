using Prkn.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.User_Logs")]
    public partial class User_Logs : Base.BaseUser_Logs
    {
        public virtual Users Users { get; set; }
    }
}
