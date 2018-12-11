namespace Tickets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTicketTitleToSummary : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Summary", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Tickets", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Title", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Tickets", "Summary");
        }
    }
}
