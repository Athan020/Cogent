using Microsoft.EntityFrameworkCore.Migrations;

namespace Cogent.Migrations
{
    public partial class Update_Call : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Call_AbpUsers_UserID",
                table: "Call");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Call",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Call_UserID",
                table: "Call",
                newName: "IX_Call_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Call_AbpUsers_UserId",
                table: "Call",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Call_AbpUsers_UserId",
                table: "Call");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Call",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Call_UserId",
                table: "Call",
                newName: "IX_Call_UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Call_AbpUsers_UserID",
                table: "Call",
                column: "UserID",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
