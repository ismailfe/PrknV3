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
    
    public partial class Tasks
    {
        public long Id { get; set; }
        public string SysCode { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public string VarStatus { get; set; }
        public string Comment { get; set; }
        public Nullable<long> UserId { get; set; }
        public Nullable<long> ProjectId { get; set; }
        public Nullable<long> SubjectPrefixId { get; set; }
        public Nullable<long> StatusId { get; set; }
        public Nullable<long> PriorityId { get; set; }
        public Nullable<long> AssingedUserId { get; set; }
        public Nullable<long> ManagerUserId { get; set; }
        public string Subject { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Description { get; set; }
    
        public virtual Projects Projects { get; set; }
        public virtual Task_Priority Task_Priority { get; set; }
        public virtual Task_Status Task_Status { get; set; }
        public virtual Task_Type Task_Type { get; set; }
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
        public virtual Users Users2 { get; set; }
    }
}
