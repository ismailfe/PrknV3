using Prkn.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Prkn.Model.Entities.Base
{
    public class BaseEntity : IBaseEntity
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Column(Order = 1)]
        public virtual string SysCode { get; set; }

        [Column(Order = 2)]
        public DateTime? CreateDate  { get; set; }

        [Column(Order = 3)]
        public DateTime? UpdateDate { get; set; }

        [Column(Order = 4)]
        public DateTime? DeleteDate { get; set; }

        [Column(Order = 5)]
        public string VarStatus { get; set; }

        [Column(Order = 6)]
        public string Comment { get; set; }

        [Column(Order = 7)]
        public long? UserId { get; set; }
    }
}
