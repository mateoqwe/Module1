using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module1DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminUserView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR ALTER VIEW dbo.GetAdminUserInfo
                AS
                SELECT u.adminUserId, u.userName, u.adminUserRoleId, r.roleName
                FROM dbo.AdminUsers u
                LEFT JOIN dbo.AdminUserRoles r
                ON u.adminUserRoleId = r.adminUserRoleId;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW dbo.GetAdminUserInfo");
        }
    }
}
