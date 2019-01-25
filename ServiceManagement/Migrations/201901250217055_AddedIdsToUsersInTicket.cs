namespace ServiceManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIdsToUsersInTicket : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "CreatedById", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "AssignedAgentId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "AssignedAgentId");
            DropColumn("dbo.Tickets", "CreatedById");
        }
    }
}
