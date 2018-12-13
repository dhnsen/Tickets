namespace Tickets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactoredTicket : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "TicketType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "TicketType");
        }
    }
}
