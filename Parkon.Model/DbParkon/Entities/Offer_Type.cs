using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Offer_Type")]
    public partial class Offer_Type : Base.BaseOffer_Type
    {
        public Offer_Type()
        {
            Offers = new HashSet<Offers>();
        }

        public virtual Users Users { get; set; }
        public virtual ICollection<Offers> Offers { get; set; }
    }
}
