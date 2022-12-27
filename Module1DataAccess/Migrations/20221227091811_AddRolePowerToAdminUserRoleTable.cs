using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module1DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRolePowerToAdminUserRoleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "adminUserRoleId",
                table: "AdminUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "rolePower",
                table: "AdminUserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdminUsers_adminUserRoleId",
                table: "AdminUsers",
                column: "adminUserRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminUsers_AdminUserRoles_adminUserRoleId",
                table: "AdminUsers",
                column: "adminUserRoleId",
                principalTable: "AdminUserRoles",
                principalColumn: "adminUserRoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminUsers_AdminUserRoles_adminUserRoleId",
                table: "AdminUsers");

            migrationBuilder.DropIndex(
                name: "IX_AdminUsers_adminUserRoleId",
                table: "AdminUsers");

            migrationBuilder.DropColumn(
                name: "adminUserRoleId",
                table: "AdminUsers");

            migrationBuilder.DropColumn(
                name: "rolePower",
                table: "AdminUserRoles");
        }
    }
}
