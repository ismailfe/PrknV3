using Prkn.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Base
{
    public class BaseUser_Screen : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public long? SetUserId { get; set; }
    }
}
