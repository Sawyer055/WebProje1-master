using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class removeKeepmeLoggedin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeepCustomerLoggedIn",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "KeepAdminLoggedIn",
                table: "Admins");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "KeepCustomerLoggedIn",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "KeepAdminLoggedIn",
                table: "Admins",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
