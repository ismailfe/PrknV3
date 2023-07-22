using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Base
{
    public class BaseStore_Address : BaseEntity
    {
        public string Code { get; set; }
        public long? ZoneId { get; set; }
        public long? ColId { get; set; }
        public long? RowId { get; set; }
        public long? PosId { get; set; }
    }
}
