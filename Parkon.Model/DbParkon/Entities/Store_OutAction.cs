using Prkn.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{ 
    [Table("UserPrkn.Store_OutAction")]
    public partial class Store_OutAction : Base.BaseStore_OutAction
    {
        public virtual Users Users { get; set; }
    }
}
