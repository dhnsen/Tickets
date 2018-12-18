namespace Tickets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactoredTicket : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Tickets", name: "Requestor_Id", newName: "RequestorId");
            RenameIndex(table: "dbo.Tickets", name: "IX_Requestor_Id", newName: "IX_RequestorId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Tickets", name: "IX_RequestorId", newName: "IX_Requestor_Id");
            RenameColumn(table: "dbo.Tickets", name: "RequestorId", newName: "Requestor_Id");
        }
    }
}
