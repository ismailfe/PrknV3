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
    
    public partial class Logs
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string OnlineUser { get; set; }
        public string WorkArea { get; set; }
        public string Job { get; set; }
        public string OldVal { get; set; }
        public string NewVal { get; set; }
        public string Status { get; set; }
        public string Messages { get; set; }
    }
}