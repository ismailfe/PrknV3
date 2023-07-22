using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Prkn.Model.Base
{
    public class BaseStore_ProductGroup : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
