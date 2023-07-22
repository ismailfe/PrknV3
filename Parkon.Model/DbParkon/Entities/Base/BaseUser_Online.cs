using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Base
{
    public class BaseUser_Online : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
