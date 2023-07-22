namespace Prkn.Data.Local.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v002 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("UserPrkn.Customers", "Customer_Type_Id", "UserPrkn.Customer_Type");
            DropForeignKey("UserPrkn.Customer_Type", "Users_Id", "UserPrkn.Users");
            DropIndex("UserPrkn.Customers", new[] { "Customer_Type_Id" });
            DropIndex("UserPrkn.Customer_Type", new[] { "Users_Id" });
            AlterColumn("UserPrkn.Customers", "Name", c => c.String(maxLength: 4000));
            DropColumn("UserPrkn.Customers", "Customer_Type_Id");
            DropColumn("UserPrkn.Customer_Type", "Users_Id");
        }
        
        public override void Down()
        {
            AddColumn("UserPrkn.Customer_Type", "Users_Id", c => c.Long());
            AddColumn("UserPrkn.Customers", "Customer_Type_Id", c => c.Long());
            AlterColumn("UserPrkn.Customers", "Name", c => c.String(nullable: false, maxLength: 4000));
            CreateIndex("UserPrkn.Customer_Type", "Users_Id");
            CreateIndex("UserPrkn.Customers", "Customer_Type_Id");
            AddForeignKey("UserPrkn.Customer_Type", "Users_Id", "UserPrkn.Users", "Id");
            AddForeignKey("UserPrkn.Customers", "Customer_Type_Id", "UserPrkn.Customer_Type", "Id");
        }
    }
}
