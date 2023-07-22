using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model
{
    [Table("UserPrkn.Task_Type")]
    public partial class Task_Type : Base.BaseTask_Type
    {
        public Task_Type()
        {
            Tasks = new HashSet<Tasks>();
        }

        public virtual Users Users { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}
