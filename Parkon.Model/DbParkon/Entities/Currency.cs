using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Prkn.Model
{
    [Table("UserPrkn.Currency")]
    public class Currency : Base.BaseCurrency
    {
        public Currency()
        {
            Offers = new HashSet<Offers>();
        }

        public virtual Users Users { get; set; }
        public virtual ICollection<Offers> Offers { get; set; }
    }
}
