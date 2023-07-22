using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Offer_RequestType")]
    public partial class Offer_RequestType : Base.BaseOffer_RequestType
    {
        public Offer_RequestType()
        {
            Offers = new HashSet<Offers>();
        }

        public virtual Users Users { get; set; }
        public virtual ICollection<Offers> Offers { get; set; }
    }
}
