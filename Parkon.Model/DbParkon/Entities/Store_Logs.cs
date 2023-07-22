using Prkn.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Store_Logs")]
    public partial class Store_Logs : Base.BaseStore_Logs
    {
        public virtual Users Users { get; set; }
    }
}
