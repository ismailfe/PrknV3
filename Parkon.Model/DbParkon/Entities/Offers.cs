using Prkn.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Offers")]
    public partial class Offers : Base.BaseOffers
    {
        public virtual Currency Currency { get; set; }
        public virtual Users Users { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual Customer_Section Customer_Section { get; set; }
        public virtual Customer_Contact Customer_Contact { get; set; }

        public virtual Offer_Type Offer_Type { get; set; }
        public virtual Offer_RequestType Offer_RequestType { get; set; }
        public virtual Offer_RequestSource Offer_RequestSource { get; set; }
        public virtual Offer_Status Offer_Status { get; set; }
        public virtual Offer_Details Offer_Details { get; set; }

    }
}
