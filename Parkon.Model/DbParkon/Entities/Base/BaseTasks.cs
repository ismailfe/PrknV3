using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model.Base
{
    public class BaseTasks : BaseEntity
    {
        public long? ProjectId { get; set; }
        public long? SubjectPrefixId { get; set; }
        public long? StatusId { get; set; }
        public long? PriorityId { get; set; }
        public long? TypeId { get; set; }
        public long? AssingedUserId { get; set; }
        public long? ManagerUserId { get; set; }
        public string Subject { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
    }
}
