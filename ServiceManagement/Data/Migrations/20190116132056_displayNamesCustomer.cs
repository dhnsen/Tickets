using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceManagement.Data.Migrations
{
    public partial class displayNamesCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SecondaryPhone",
                table: "Customers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecondaryPhone",
                table: "Customers");
        }
    }
}
