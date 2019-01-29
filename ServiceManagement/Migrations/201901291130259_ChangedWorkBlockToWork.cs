namespace ServiceManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedWorkBlockToWork : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.WorkBlocks", newName: "Works");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Works", newName: "WorkBlocks");
        }
    }
}
