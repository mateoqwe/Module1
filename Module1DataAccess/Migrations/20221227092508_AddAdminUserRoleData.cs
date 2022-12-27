using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module1DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminUserRoleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO AdminUserRoles VALUES('Boss', 0)");
            migrationBuilder.Sql("INSERT INTO AdminUserRoles VALUES('Dev', 1)");
            migrationBuilder.Sql("INSERT INTO AdminUserRoles VALUES('Admin', 2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
