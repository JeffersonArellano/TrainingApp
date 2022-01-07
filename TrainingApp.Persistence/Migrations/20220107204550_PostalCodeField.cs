using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingApp.Persistence.Migrations
{
    public partial class PostalCodeField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Customers");
        }
    }
}
