using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.DbSettings.Entities
{
    public class Logs
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string OnlineUser { get; set; }
        public string WorkArea { get; set; }
        public string Job { get; set; }
        public string OldVal { get; set; }
        public string NewVal { get; set; }
        public string Status { get; set; }
        public string Messages { get; set; }
    }
}
