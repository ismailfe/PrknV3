using Prkn.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Offer_Details")]
    public partial class Offer_Details : Base.BaseOffer_Details
    {
        public Offer_Details()
        {
            Offers = new HashSet<Offers>();
        }
        
        public virtual Users Users { get; set; }
        public virtual ICollection<Offers> Offers { get; set; }
    }
}
