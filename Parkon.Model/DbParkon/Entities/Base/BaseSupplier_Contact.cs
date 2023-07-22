using Prkn.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.Base
{
    public class BaseSupplier_Contact : BaseEntity
    {
        public long? SupplierId { get; set; }
        public long? TitleId { get; set; }
        public int? No { get; set; }
        public string Job { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Mail1 { get; set; }
        public string Mail2 { get; set; }
        public int? Gender { get; set; }
        public string Pic { get; set; }
        public string Score { get; set; }
        public string Info { get; set; }
        public string Keyword { get; set; }
    }
}
