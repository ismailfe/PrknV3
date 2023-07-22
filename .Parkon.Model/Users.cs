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
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.Customer_Contact = new HashSet<Customer_Contact>();
            this.Customer_Type = new HashSet<Customer_Type>();
            this.Customers = new HashSet<Customers>();
            this.Keyword = new HashSet<Keyword>();
            this.Licenses = new HashSet<Licenses>();
            this.Meeting_Content = new HashSet<Meeting_Content>();
            this.Meeting_JoinUser = new HashSet<Meeting_JoinUser>();
            this.Meeting_Status = new HashSet<Meeting_Status>();
            this.Meeting_Type = new HashSet<Meeting_Type>();
            this.Meetings = new HashSet<Meetings>();
            this.Project_Detail = new HashSet<Project_Detail>();
            this.Project_Rev = new HashSet<Project_Rev>();
            this.Projects = new HashSet<Projects>();
            this.SoftwareVersion = new HashSet<SoftwareVersion>();
            this.Store_Address = new HashSet<Store_Address>();
            this.Store_AddressCol = new HashSet<Store_AddressCol>();
            this.Store_AddressPos = new HashSet<Store_AddressPos>();
            this.Store_AddressRow = new HashSet<Store_AddressRow>();
            this.Store_AddressZone = new HashSet<Store_AddressZone>();
            this.Store_Brand = new HashSet<Store_Brand>();
            this.Store_Location = new HashSet<Store_Location>();
            this.Store_Logs = new HashSet<Store_Logs>();
            this.Store_OutAction = new HashSet<Store_OutAction>();
            this.Store_Product = new HashSet<Store_Product>();
            this.Store_ProductGroup = new HashSet<Store_ProductGroup>();
            this.Store_ProductType = new HashSet<Store_ProductType>();
            this.Store_ProductUnit = new HashSet<Store_ProductUnit>();
            this.Store_Warehouse = new HashSet<Store_Warehouse>();
            this.Store_WarehouseOut = new HashSet<Store_WarehouseOut>();
            this.Supplier_Contact = new HashSet<Supplier_Contact>();
            this.Supplier_Section = new HashSet<Supplier_Section>();
            this.Supplier_Type = new HashSet<Supplier_Type>();
            this.Suppliers = new HashSet<Suppliers>();
            this.Task_Priority = new HashSet<Task_Priority>();
            this.Task_Status = new HashSet<Task_Status>();
            this.Task_Type = new HashSet<Task_Type>();
            this.Tasks = new HashSet<Tasks>();
            this.Tasks1 = new HashSet<Tasks>();
            this.Tasks2 = new HashSet<Tasks>();
            this.Title = new HashSet<Title>();
            this.User_Access = new HashSet<User_Access>();
            this.User_Authorization = new HashSet<User_Authorization>();
            this.User_Authorization1 = new HashSet<User_Authorization>();
            this.User_Department = new HashSet<User_Department>();
            this.User_Level = new HashSet<User_Level>();
            this.User_Logs = new HashSet<User_Logs>();
            this.User_Online = new HashSet<User_Online>();
            this.User_Screen = new HashSet<User_Screen>();
            this.Users1 = new HashSet<Users>();
            this.Users11 = new HashSet<Users>();
            this.Zone = new HashSet<Zone>();
        }
    
        public long Id { get; set; }
        public string SysCode { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public string VarStatus { get; set; }
        public string Comment { get; set; }
        public Nullable<System.Guid> UId { get; set; }
        public Nullable<long> UserId { get; set; }
        public Nullable<long> AutrizationId { get; set; }
        public Nullable<long> LevelsId { get; set; }
        public Nullable<long> OnlineId { get; set; }
        public Nullable<long> DepartmentId { get; set; }
        public Nullable<long> TitleId { get; set; }
        public string Role { get; set; }
        public string Pic { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string Mail1 { get; set; }
        public string Mail2 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Contact> Customer_Contact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Type> Customer_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customers> Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Keyword> Keyword { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Licenses> Licenses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meeting_Content> Meeting_Content { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meeting_JoinUser> Meeting_JoinUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meeting_Status> Meeting_Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meeting_Type> Meeting_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meetings> Meetings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project_Detail> Project_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project_Rev> Project_Rev { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projects> Projects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoftwareVersion> SoftwareVersion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_Address> Store_Address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_AddressCol> Store_AddressCol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_AddressPos> Store_AddressPos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_AddressRow> Store_AddressRow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_AddressZone> Store_AddressZone { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_Brand> Store_Brand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_Location> Store_Location { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_Logs> Store_Logs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_OutAction> Store_OutAction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_Product> Store_Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_ProductGroup> Store_ProductGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_ProductType> Store_ProductType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_ProductUnit> Store_ProductUnit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_Warehouse> Store_Warehouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_WarehouseOut> Store_WarehouseOut { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supplier_Contact> Supplier_Contact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supplier_Section> Supplier_Section { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supplier_Type> Supplier_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Suppliers> Suppliers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task_Priority> Task_Priority { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task_Status> Task_Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task_Type> Task_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tasks> Tasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tasks> Tasks1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tasks> Tasks2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Title> Title { get; set; }
        public virtual Title Title1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Access> User_Access { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Authorization> User_Authorization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Authorization> User_Authorization1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Department> User_Department { get; set; }
        public virtual User_Department User_Department1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Level> User_Level { get; set; }
        public virtual User_Level User_Level1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Logs> User_Logs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Online> User_Online { get; set; }
        public virtual User_Online User_Online1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Screen> User_Screen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users> Users1 { get; set; }
        public virtual Users Users2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users> Users11 { get; set; }
        public virtual Users Users3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zone> Zone { get; set; }
    }
}