using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module1DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AlterFKAdminUserRoleInAdminUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminUsers_AdminUserRoles_adminUserRoleId",
                table: "AdminUsers");

            migrationBuilder.AlterColumn<int>(
                name: "adminUserRoleId",
                table: "AdminUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AdminUsers_AdminUserRoles_adminUserRoleId",
                table: "AdminUsers",
                column: "adminUserRoleId",
                principalTable: "AdminUserRoles",
                principalColumn: "adminUserRoleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminUsers_AdminUserRoles_adminUserRoleId",
                table: "AdminUsers");

            migrationBuilder.AlterColumn<int>(
                name: "adminUserRoleId",
                table: "AdminUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminUsers_AdminUserRoles_adminUserRoleId",
                table: "AdminUsers",
                column: "adminUserRoleId",
                principalTable: "AdminUserRoles",
                principalColumn: "adminUserRoleId");
        }
    }
}
