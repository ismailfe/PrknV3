using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Base
{
    public class BaseUsers : BaseEntity
    {
        public Guid? UId { get; set; }
        public long? AutrizationId { get; set; }
        public long? LevelsId { get; set; }
        public long? OnlineId { get; set; }
        public long? DepartmentId { get; set; }
        public long? TitleId { get; set; }
        public string Role { get; set; }
        public string Pic { get; set; }
        public DateTime? BirthDate { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string Mail1 { get; set; }
        public string Mail2 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
    }
}
