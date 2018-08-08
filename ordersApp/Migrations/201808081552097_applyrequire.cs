namespace ordersApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class applyrequire : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
