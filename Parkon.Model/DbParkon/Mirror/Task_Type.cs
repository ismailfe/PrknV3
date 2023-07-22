using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model.Mirror
{
    [Table("UserPrkn.Task_Type")]
    public partial class Task_Type : Base.BaseTask_Type
    {

    }
}
