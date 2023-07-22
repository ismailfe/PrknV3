using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model
{
    [Table("UserPrkn.Tasks")]
    public partial class Tasks : Base.BaseTasks
    {
        public virtual Projects Projects { get; set; }
        public virtual Task_Priority Task_Priority { get; set; }
        public virtual Task_Type Task_Type { get; set; }
        public virtual Task_Status Task_Status { get; set; }
        public virtual Task_SubjectPrefix Task_SubjectPrefix { get; set; }
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
        public virtual Users Users2 { get; set; }
    }
}
