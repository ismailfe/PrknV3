using Prkn.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Base
{
    public class BaseStore_Brand : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Pic { get; set; }
        public string Score { get; set; }
        public string Info { get; set; }
        public string Keyword { get; set; }
    }
}
