using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module1DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminUserData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO AdminUsers VALUES('Annie', '11', 1)");
            migrationBuilder.Sql("INSERT INTO AdminUsers VALUES('John', '222', 3)");
            migrationBuilder.Sql("INSERT INTO AdminUsers VALUES('Messi', '3333', 2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
