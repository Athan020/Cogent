using Microsoft.EntityFrameworkCore.Migrations;

namespace Cogent.Migrations
{
    public partial class Update_Call2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Call_AbpUsers_UserId",
                table: "Call");

            migrationBuilder.DropIndex(
                name: "IX_Call_UserId",
                table: "Call");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Call",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Call",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Call_UserId",
                table: "Call",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Call_AbpUsers_UserId",
                table: "Call",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
