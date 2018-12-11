namespace Tickets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTicketModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        Title = c.String(),
                        AssignedUser_Id = c.String(maxLength: 128),
                        Requestor_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AssignedUser_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Requestor_Id)
                .Index(t => t.AssignedUser_Id)
                .Index(t => t.Requestor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Requestor_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Tickets", "AssignedUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Tickets", new[] { "Requestor_Id" });
            DropIndex("dbo.Tickets", new[] { "AssignedUser_Id" });
            DropTable("dbo.Tickets");
        }
    }
}
