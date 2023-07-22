using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Base
{
    public class BaseOffer_Type : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
