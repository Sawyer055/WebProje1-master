using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class last1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planes_Routes_RouteID",
                table: "Planes");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Customers_CustomerID",
                table: "Routes");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Routes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RouteID",
                table: "Planes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_Routes_RouteID",
                table: "Planes",
                column: "RouteID",
                principalTable: "Routes",
                principalColumn: "RouteID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Customers_CustomerID",
                table: "Routes",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planes_Routes_RouteID",
                table: "Planes");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Customers_CustomerID",
                table: "Routes");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Routes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RouteID",
                table: "Planes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_Routes_RouteID",
                table: "Planes",
                column: "RouteID",
                principalTable: "Routes",
                principalColumn: "RouteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Customers_CustomerID",
                table: "Routes",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID");
        }
    }
}
