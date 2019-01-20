namespace ServiceManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateWorkBlockTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkBlocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Note = c.String(),
                        IsBilled = c.Boolean(nullable: false),
                        Agent_Id = c.String(maxLength: 128),
                        Ticket_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Agent_Id)
                .ForeignKey("dbo.Tickets", t => t.Ticket_Id)
                .Index(t => t.Agent_Id)
                .Index(t => t.Ticket_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkBlocks", "Ticket_Id", "dbo.Tickets");
            DropForeignKey("dbo.WorkBlocks", "Agent_Id", "dbo.AspNetUsers");
            DropIndex("dbo.WorkBlocks", new[] { "Ticket_Id" });
            DropIndex("dbo.WorkBlocks", new[] { "Agent_Id" });
            DropTable("dbo.WorkBlocks");
        }
    }
}
