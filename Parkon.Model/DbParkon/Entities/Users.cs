using Prkn.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prkn.Model
{
    [Table("UserPrkn.Users")]
    public partial class Users : Base.BaseUsers
    {
        public Users()
        {
            Customer_Contact = new HashSet<Customer_Contact>();
            Customer_Type = new HashSet<Customer_Type>();
            Customers = new HashSet<Customers>();
            Keyword = new HashSet<Keyword>();
            Meeting_Content = new HashSet<Meeting_Content>();
            Meeting_JoinUser = new HashSet<Meeting_JoinUser>();
            Meeting_Status = new HashSet<Meeting_Status>();
            Meeting_Type = new HashSet<Meeting_Type>();
            Meetings = new HashSet<Meetings>();
            Project_Detail = new HashSet<Project_Detail>();
            Project_Rev = new HashSet<Project_Rev>();
            Projects = new HashSet<Projects>();
            Store_Address = new HashSet<Store_Address>();
            Store_AddressCol = new HashSet<Store_AddressCol>();
            Store_AddressPos = new HashSet<Store_AddressPos>();
            Store_AddressRow = new HashSet<Store_AddressRow>();
            Store_AddressZone = new HashSet<Store_AddressZone>();
            Store_Brand = new HashSet<Store_Brand>();
            Store_Location = new HashSet<Store_Location>();
            Store_Logs = new HashSet<Store_Logs>();
            Store_OutAction = new HashSet<Store_OutAction>();
            Store_Product = new HashSet<Store_Product>();
            Store_ProductGroup = new HashSet<Store_ProductGroup>();
            Store_ProductType = new HashSet<Store_ProductType>();
            Store_ProductUnit = new HashSet<Store_ProductUnit>();
            Store_Warehouse = new HashSet<Store_Warehouse>();
            Store_WarehouseOut = new HashSet<Store_WarehouseOut>();
            Supplier_Contact = new HashSet<Supplier_Contact>();
            Supplier_Section = new HashSet<Supplier_Section>();
            Supplier_Type = new HashSet<Supplier_Type>();
            Suppliers = new HashSet<Suppliers>();
            Task_Priority = new HashSet<Task_Priority>();
            Task_Status = new HashSet<Task_Status>();
            Task_SubjectPrefix = new HashSet<Task_SubjectPrefix>();
            Tasks = new HashSet<Tasks>();
            Tasks1 = new HashSet<Tasks>();
            Tasks2 = new HashSet<Tasks>();
            Title = new HashSet<Title>();
            User_Access = new HashSet<User_Access>();
            //User_Access1 = new HashSet<User_Access>();
            User_Authorization = new HashSet<User_Authorization>();
            User_Authorization1 = new HashSet<User_Authorization>();
            User_Department = new HashSet<User_Department>();
            User_Level = new HashSet<User_Level>();
            User_Logs = new HashSet<User_Logs>();
            User_Online = new HashSet<User_Online>();
            Users1 = new HashSet<Users>();
            Zone = new HashSet<Zone>();
            User_Screen = new HashSet<User_Screen>();
            SoftwareVersion = new HashSet<SoftwareVersion>();

            Offer_Type = new HashSet<Offer_Type>();
            Offer_Status = new HashSet<Offer_Status>();
            Offer_RequestType = new HashSet<Offer_RequestType>();
            Offer_RequestSource = new HashSet<Offer_RequestSource>();
            Offer_Details = new HashSet<Offer_Details>();
            Offers = new HashSet<Offers>();
            Currency = new HashSet<Currency>();
        }

        public virtual Title Title1 { get; set; }
        public virtual User_Online User_Online1 { get; set; }
        public virtual User_Authorization User_Authorization2 { get; set; }
        public virtual User_Level User_Level1 { get; set; }
        public virtual Users Users2 { get; set; }
        public virtual User_Department User_Department1 { get; set; }
        public virtual ICollection<Customer_Contact> Customer_Contact { get; set; }
        public virtual ICollection<Customer_Type> Customer_Type { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Keyword> Keyword { get; set; }
        public virtual ICollection<Meeting_Content> Meeting_Content { get; set; }
        public virtual ICollection<Meeting_JoinUser> Meeting_JoinUser { get; set; }
        public virtual ICollection<Meeting_Status> Meeting_Status { get; set; }
        public virtual ICollection<Meeting_Type> Meeting_Type { get; set; }
        public virtual ICollection<Meetings> Meetings { get; set; }
        public virtual ICollection<Project_Detail> Project_Detail { get; set; }
        public virtual ICollection<Project_Rev> Project_Rev { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<Store_Address> Store_Address { get; set; }
        public virtual ICollection<Store_AddressCol> Store_AddressCol { get; set; }
        public virtual ICollection<Store_AddressPos> Store_AddressPos { get; set; }
        public virtual ICollection<Store_AddressRow> Store_AddressRow { get; set; }
        public virtual ICollection<Store_AddressZone> Store_AddressZone { get; set; }
        public virtual ICollection<Store_Brand> Store_Brand { get; set; }
        public virtual ICollection<Store_Location> Store_Location { get; set; }
        public virtual ICollection<Store_Logs> Store_Logs { get; set; }
        public virtual ICollection<Store_OutAction> Store_OutAction { get; set; }
        public virtual ICollection<Store_Product> Store_Product { get; set; }
        public virtual ICollection<Store_ProductGroup> Store_ProductGroup { get; set; }
        public virtual ICollection<Store_ProductType> Store_ProductType { get; set; }
        public virtual ICollection<Store_ProductUnit> Store_ProductUnit { get; set; }
        public virtual ICollection<Store_Warehouse> Store_Warehouse { get; set; }
        public virtual ICollection<Store_WarehouseOut> Store_WarehouseOut { get; set; }
        public virtual ICollection<Supplier_Contact> Supplier_Contact { get; set; }
        public virtual ICollection<Supplier_Section> Supplier_Section { get; set; }
        public virtual ICollection<Supplier_Type> Supplier_Type { get; set; }
        public virtual ICollection<Suppliers> Suppliers { get; set; }
        public virtual ICollection<Task_Priority> Task_Priority { get; set; }
        public virtual ICollection<Task_Status> Task_Status { get; set; }
        public virtual ICollection<Task_SubjectPrefix> Task_SubjectPrefix { get; set; }
        public virtual ICollection<Task_Type> Task_Type { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
        public virtual ICollection<Tasks> Tasks1 { get; set; }
        public virtual ICollection<Tasks> Tasks2 { get; set; }
        public virtual ICollection<Title> Title { get; set; }
        public virtual ICollection<User_Access> User_Access { get; set; }
        //public virtual ICollection<User_Access> User_Access1 { get; set; }
        public virtual ICollection<User_Authorization> User_Authorization { get; set; }
        public virtual ICollection<User_Authorization> User_Authorization1 { get; set; }
        public virtual ICollection<User_Department> User_Department { get; set; }
        public virtual ICollection<User_Level> User_Level { get; set; }
        public virtual ICollection<User_Logs> User_Logs { get; set; }
        public virtual ICollection<User_Online> User_Online { get; set; }
        public virtual ICollection<Users> Users1 { get; set; }
        public virtual ICollection<Zone> Zone { get; set; }
        public virtual ICollection<User_Screen> User_Screen { get; set; }
        public virtual ICollection<Offers> Offers { get; set; }
        public virtual ICollection<Offer_Details> Offer_Details { get; set; }
        public virtual ICollection<Offer_RequestType> Offer_RequestType { get; set; }
        public virtual ICollection<Offer_RequestSource> Offer_RequestSource { get; set; }
        public virtual ICollection<Offer_Status> Offer_Status { get; set; }
        public virtual ICollection<Offer_Type> Offer_Type { get; set; }
        public virtual ICollection<SoftwareVersion> SoftwareVersion { get; set; }
        public virtual ICollection<Currency> Currency { get; set; }

    }
}
