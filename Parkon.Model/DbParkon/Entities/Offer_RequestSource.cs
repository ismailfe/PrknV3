using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Offer_RequestSource")]
    public partial class Offer_RequestSource : Base.BaseOffer_RequestSource
    {
        public Offer_RequestSource()
        {
            Offers = new HashSet<Offers>();
        }

        public virtual Users Users { get; set; }
        public virtual ICollection<Offers> Offers { get; set; }
    }
}
