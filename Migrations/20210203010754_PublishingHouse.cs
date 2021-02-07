using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCBookManager.Migrations
{
    public partial class PublishingHouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublishingHouse",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishingHouse",
                table: "Book");
        }
    }
}
