using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model.DbSettings.Entities
{
    public class Prg
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Column(Order = 1)]
        public DateTime? UpdateDate { get; set; }
        [Column(Order = 2)]
        public string Name { get; set; }
        [Column(Order = 3)]
        public string Type { get; set; }
        [Column(Order = 4)]
        public string Value { get; set; }
        [Column(Order = 5)]
        public string Comment { get; set; }
    }
}
