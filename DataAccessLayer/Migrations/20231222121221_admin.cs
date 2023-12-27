using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class admin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminPassword = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AdminName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AdminSurname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AdminRole = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
