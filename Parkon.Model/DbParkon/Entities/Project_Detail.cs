using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{

    [Table("UserPrkn.Project_Detail")]
    public partial class Project_Detail :Base.BaseProject_Detail
    {
        public Project_Detail()
        {
            Projects = new HashSet<Projects>();
        }

        public virtual Users Users { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
    }
}
