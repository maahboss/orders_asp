namespace ordersApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubToNews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubToNews", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubToNews");
        }
    }
}
