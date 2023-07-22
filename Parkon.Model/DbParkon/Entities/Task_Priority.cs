using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{

    [Table("UserPrkn.Task_Priority")]
    public partial class Task_Priority : Base.BaseTask_Priority
    {
        public Task_Priority()
        {
            Tasks = new HashSet<Tasks>();
        }

        public virtual Users Users { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}
