using Prkn.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model.Base
{
    public class BaseMeeting_Status : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
