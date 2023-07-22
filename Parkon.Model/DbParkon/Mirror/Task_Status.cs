using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace Prkn.Model.Mirror
{
    [Table("UserPrkn.Task_Status")]
    public partial class Task_Status : Base.BaseTask_Status
    {

    }
}
