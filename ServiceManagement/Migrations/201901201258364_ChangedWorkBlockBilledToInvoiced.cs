namespace ServiceManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedWorkBlockBilledToInvoiced : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkBlocks", "IsInvoiced", c => c.Boolean(nullable: false));
            DropColumn("dbo.WorkBlocks", "IsBilled");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkBlocks", "IsBilled", c => c.Boolean(nullable: false));
            DropColumn("dbo.WorkBlocks", "IsInvoiced");
        }
    }
}
