using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Offer_Status")]
    public partial class Offer_Status : Base.BaseOffer_Status
    {
        public Offer_Status()
        {
            Offers = new HashSet<Offers>();
        }

        public virtual Users Users { get; set; }
        public virtual ICollection<Offers> Offers { get; set; }
    }
}
