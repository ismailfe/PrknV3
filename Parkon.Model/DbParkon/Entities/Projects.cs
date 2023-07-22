namespace Prkn.Model
{
    using Prkn.Model.Entities.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserPrkn.Projects")]
    public partial class Projects : Base.BaseProjects
    {
        public Projects()
        {
            Project_Rev = new HashSet<Project_Rev>();
            Tasks = new HashSet<Tasks>();
        }

        public virtual Customer_Contact Customer_Contact { get; set; }
        public virtual Customer_Section Customer_Section { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual Project_Detail Project_Detail { get; set; }
        public virtual ICollection<Project_Rev> Project_Rev { get; set; }
        public virtual Users Users { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}
