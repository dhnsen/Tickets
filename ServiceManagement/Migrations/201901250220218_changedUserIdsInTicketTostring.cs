namespace ServiceManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedUserIdsInTicketTostring : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tickets", "CreatedBy_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Tickets", new[] { "AssignedAgent_Id" });
            DropIndex("dbo.Tickets", new[] { "CreatedBy_Id" });
            DropColumn("dbo.Tickets", "AssignedAgentId");
            DropColumn("dbo.Tickets", "CreatedById");
            RenameColumn(table: "dbo.Tickets", name: "AssignedAgent_Id", newName: "AssignedAgentId");
            RenameColumn(table: "dbo.Tickets", name: "CreatedBy_Id", newName: "CreatedById");
            AlterColumn("dbo.Tickets", "CreatedById", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Tickets", "AssignedAgentId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Tickets", "CreatedById", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Tickets", "CreatedById");
            CreateIndex("dbo.Tickets", "AssignedAgentId");
            AddForeignKey("dbo.Tickets", "CreatedById", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "CreatedById", "dbo.AspNetUsers");
            DropIndex("dbo.Tickets", new[] { "AssignedAgentId" });
            DropIndex("dbo.Tickets", new[] { "CreatedById" });
            AlterColumn("dbo.Tickets", "CreatedById", c => c.String(maxLength: 128));
            AlterColumn("dbo.Tickets", "AssignedAgentId", c => c.Int(nullable: false));
            AlterColumn("dbo.Tickets", "CreatedById", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Tickets", name: "CreatedById", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.Tickets", name: "AssignedAgentId", newName: "AssignedAgent_Id");
            AddColumn("dbo.Tickets", "CreatedById", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "AssignedAgentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tickets", "CreatedBy_Id");
            CreateIndex("dbo.Tickets", "AssignedAgent_Id");
            AddForeignKey("dbo.Tickets", "CreatedBy_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
