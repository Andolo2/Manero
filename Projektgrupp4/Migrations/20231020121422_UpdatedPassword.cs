using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projektgrupp4.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Passwords_PasswordId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Passwords");

            migrationBuilder.DropIndex(
                name: "IX_Users_PasswordId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordId",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PasswordId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Passwords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Password = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    SecurityKey = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    UserEntityId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passwords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passwords_Users_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_PasswordId",
                table: "Users",
                column: "PasswordId");

            migrationBuilder.CreateIndex(
                name: "IX_Passwords_UserEntityId",
                table: "Passwords",
                column: "UserEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Passwords_PasswordId",
                table: "Users",
                column: "PasswordId",
                principalTable: "Passwords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
