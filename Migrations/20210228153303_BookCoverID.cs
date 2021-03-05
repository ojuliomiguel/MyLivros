using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCBookManager.Migrations
{
    public partial class BookCoverID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookCoverID",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookCoverID",
                table: "Book");
        }
    }
}
