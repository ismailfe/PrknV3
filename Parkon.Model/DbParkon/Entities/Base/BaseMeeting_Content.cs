using Prkn.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Base
{
    public class BaseMeeting_Content : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
