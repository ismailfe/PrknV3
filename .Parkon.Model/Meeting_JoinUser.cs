//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Emikon.Parkon.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meeting_JoinUser
    {
        public long Id { get; set; }
        public string SysCode { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public string VarStatus { get; set; }
        public string Comment { get; set; }
        public Nullable<long> UserId { get; set; }
        public Nullable<long> MeetingId { get; set; }
        public Nullable<long> MeetingRefNo { get; set; }
        public Nullable<long> CustomerContactId { get; set; }
        public Nullable<long> SupplierContactId { get; set; }
        public Nullable<long> OtherContact { get; set; }
    
        public virtual Customer_Contact Customer_Contact { get; set; }
        public virtual Meeting_JoinUser Meeting_JoinUser1 { get; set; }
        public virtual Meeting_JoinUser Meeting_JoinUser2 { get; set; }
        public virtual Meetings Meetings { get; set; }
        public virtual Supplier_Contact Supplier_Contact { get; set; }
        public virtual Users Users { get; set; }
    }
}
