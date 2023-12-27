using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class son : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Admins_AdminID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Planes_Admins_AdminID",
                table: "Planes");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Admins_AdminID",
                table: "Routes");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Routes_AdminID",
                table: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Planes_AdminID",
                table: "Planes");

            migrationBuilder.DropIndex(
                name: "IX_Customers_AdminID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "Planes");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "Customers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "Routes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "Planes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AdminPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Routes_AdminID",
                table: "Routes",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_AdminID",
                table: "Planes",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AdminID",
                table: "Customers",
                column: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Admins_AdminID",
                table: "Customers",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_Admins_AdminID",
                table: "Planes",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Admins_AdminID",
                table: "Routes",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
