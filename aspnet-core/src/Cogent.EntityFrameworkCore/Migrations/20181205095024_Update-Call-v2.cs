using Microsoft.EntityFrameworkCore.Migrations;

namespace Cogent.Migrations
{
    public partial class UpdateCallv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Callnumber",
                table: "Call",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Callnumber",
                table: "Call",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
