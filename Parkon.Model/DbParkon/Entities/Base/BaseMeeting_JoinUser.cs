using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model.Base
{
    public class BaseMeeting_JoinUser : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
