namespace Prkn.Data.Local.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v003 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("UserPrkn.Customer_Section", "Customers_Id", "UserPrkn.Customers");
            DropForeignKey("UserPrkn.Offers", "Customer_Section_Id", "UserPrkn.Customer_Section");
            DropForeignKey("UserPrkn.Projects", "Customer_Section_Id", "UserPrkn.Customer_Section");
            DropForeignKey("UserPrkn.Customer_Section", "ZoneId", "UserPrkn.Zone");
            DropIndex("UserPrkn.Customer_Section", new[] { "ZoneId" });
            DropIndex("UserPrkn.Customer_Section", new[] { "Customers_Id" });
            DropIndex("UserPrkn.Offers", new[] { "Customer_Section_Id" });
            DropIndex("UserPrkn.Projects", new[] { "Customer_Section_Id" });
            DropColumn("UserPrkn.Customer_Section", "Customers_Id");
            DropColumn("UserPrkn.Offers", "Customer_Section_Id");
            DropColumn("UserPrkn.Projects", "Customer_Section_Id");
        }
        
        public override void Down()
        {
            AddColumn("UserPrkn.Projects", "Customer_Section_Id", c => c.Long());
            AddColumn("UserPrkn.Offers", "Customer_Section_Id", c => c.Long());
            AddColumn("UserPrkn.Customer_Section", "Customers_Id", c => c.Long());
            CreateIndex("UserPrkn.Projects", "Customer_Section_Id");
            CreateIndex("UserPrkn.Offers", "Customer_Section_Id");
            CreateIndex("UserPrkn.Customer_Section", "Customers_Id");
            CreateIndex("UserPrkn.Customer_Section", "ZoneId");
            AddForeignKey("UserPrkn.Customer_Section", "ZoneId", "UserPrkn.Zone", "Id");
            AddForeignKey("UserPrkn.Projects", "Customer_Section_Id", "UserPrkn.Customer_Section", "Id");
            AddForeignKey("UserPrkn.Offers", "Customer_Section_Id", "UserPrkn.Customer_Section", "Id");
            AddForeignKey("UserPrkn.Customer_Section", "Customers_Id", "UserPrkn.Customers", "Id");
        }
    }
}
