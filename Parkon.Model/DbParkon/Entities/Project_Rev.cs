namespace Prkn.Model
{
    using Prkn.Model.Entities.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserPrkn.Project_Rev")]
    public partial class Project_Rev : Base.BaseProject_Rev
    {
        public virtual Customer_Contact Customer_Contact { get; set; }
        public virtual Projects Projects { get; set; }
        public virtual Users Users { get; set; }
    }
}
