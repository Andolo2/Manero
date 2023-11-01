using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projektgrupp4.Migrations
{
    /// <inheritdoc />
    public partial class RemoveId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressEntityUserEntity_Users_UsersUserId",
                table: "AddressEntityUserEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressEntityUserEntity",
                table: "AddressEntityUserEntity");

            migrationBuilder.DropIndex(
                name: "IX_AddressEntityUserEntity_UsersUserId",
                table: "AddressEntityUserEntity");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "AddressEntityUserEntity");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "AddressEntityUserEntity",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressEntityUserEntity",
                table: "AddressEntityUserEntity",
                columns: new[] { "UserAddressId", "UsersId" });

            migrationBuilder.CreateIndex(
                name: "IX_AddressEntityUserEntity_UsersId",
                table: "AddressEntityUserEntity",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressEntityUserEntity_Users_UsersId",
                table: "AddressEntityUserEntity",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressEntityUserEntity_Users_UsersId",
                table: "AddressEntityUserEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressEntityUserEntity",
                table: "AddressEntityUserEntity");

            migrationBuilder.DropIndex(
                name: "IX_AddressEntityUserEntity_UsersId",
                table: "AddressEntityUserEntity");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "AddressEntityUserEntity");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "UsersUserId",
                table: "AddressEntityUserEntity",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressEntityUserEntity",
                table: "AddressEntityUserEntity",
                columns: new[] { "UserAddressId", "UsersUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AddressEntityUserEntity_UsersUserId",
                table: "AddressEntityUserEntity",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressEntityUserEntity_Users_UsersUserId",
                table: "AddressEntityUserEntity",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
