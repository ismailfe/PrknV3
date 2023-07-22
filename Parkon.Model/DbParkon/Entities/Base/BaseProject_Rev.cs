using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace Prkn.Model.Base
{
    public class BaseProject_Rev : BaseEntity
    {
        public long? ProjectId { get; set; }
        public long? CustomerContactId { get; set; }
        public int? PeriodMonth { get; set; }
        public int? PeriodYear { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public long? RefNo { get; set; }
        public int? No { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Keyword { get; set; }
    }
}
