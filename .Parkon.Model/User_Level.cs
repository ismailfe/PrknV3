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
    
    public partial class User_Level
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_Level()
        {
            this.Users1 = new HashSet<Users>();
        }
    
        public long Id { get; set; }
        public string SysCode { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public string VarStatus { get; set; }
        public string Comment { get; set; }
        public Nullable<long> UserId { get; set; }
        public string Level1 { get; set; }
        public string Level2 { get; set; }
        public string Level3 { get; set; }
        public string Level4 { get; set; }
        public string Level5 { get; set; }
        public string Level6 { get; set; }
        public string Level7 { get; set; }
        public string Level8 { get; set; }
        public string Level9 { get; set; }
        public string Level10 { get; set; }
        public string Level11 { get; set; }
        public string Level12 { get; set; }
        public string Level13 { get; set; }
        public string Level14 { get; set; }
        public string Level15 { get; set; }
    
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users> Users1 { get; set; }
    }
}
