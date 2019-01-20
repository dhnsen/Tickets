namespace ServiceManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTicketTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        Summary = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        IsCompleted = c.Boolean(nullable: false),
                        AssignedAgent_Id = c.String(maxLength: 128),
                        CreatedBy_Id = c.String(maxLength: 128),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AssignedAgent_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.AssignedAgent_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Tickets", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Tickets", "AssignedAgent_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Tickets", new[] { "Customer_Id" });
            DropIndex("dbo.Tickets", new[] { "CreatedBy_Id" });
            DropIndex("dbo.Tickets", new[] { "AssignedAgent_Id" });
            DropTable("dbo.Tickets");
        }
    }
}
