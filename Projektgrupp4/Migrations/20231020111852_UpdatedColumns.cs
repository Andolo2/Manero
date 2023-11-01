using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projektgrupp4.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_PasswordEntity_PasswordId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PasswordEntity",
                table: "PasswordEntity");

            migrationBuilder.RenameTable(
                name: "PasswordEntity",
                newName: "Passwords");

            migrationBuilder.AddColumn<string>(
                name: "UserEntityId",
                table: "Passwords",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passwords",
                table: "Passwords",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Passwords_UserEntityId",
                table: "Passwords",
                column: "UserEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Passwords_Users_UserEntityId",
                table: "Passwords",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Passwords_PasswordId",
                table: "Users",
                column: "PasswordId",
                principalTable: "Passwords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passwords_Users_UserEntityId",
                table: "Passwords");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Passwords_PasswordId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passwords",
                table: "Passwords");

            migrationBuilder.DropIndex(
                name: "IX_Passwords_UserEntityId",
                table: "Passwords");

            migrationBuilder.DropColumn(
                name: "UserEntityId",
                table: "Passwords");

            migrationBuilder.RenameTable(
                name: "Passwords",
                newName: "PasswordEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PasswordEntity",
                table: "PasswordEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_PasswordEntity_PasswordId",
                table: "Users",
                column: "PasswordId",
                principalTable: "PasswordEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
