namespace Tickets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRequiredFieldsToTicket : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tickets", "Requestor_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Tickets", new[] { "Requestor_Id" });
            AlterColumn("dbo.Tickets", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Tickets", "Requestor_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Tickets", "Requestor_Id");
            AddForeignKey("dbo.Tickets", "Requestor_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Requestor_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Tickets", new[] { "Requestor_Id" });
            AlterColumn("dbo.Tickets", "Requestor_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Tickets", "Title", c => c.String());
            CreateIndex("dbo.Tickets", "Requestor_Id");
            AddForeignKey("dbo.Tickets", "Requestor_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
