namespace ServiceManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedCustomerFieldsToStrings : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "PostalCode", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Phone1", c => c.String());
            AlterColumn("dbo.Customers", "Phone2", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Phone2", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Phone1", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "PostalCode", c => c.Int(nullable: false));
        }
    }
}
