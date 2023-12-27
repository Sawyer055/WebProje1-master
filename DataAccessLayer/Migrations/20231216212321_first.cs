using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
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
                    AdminName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AdminPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CustomerSurname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CustomerPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customers_Admins_AdminID",
                        column: x => x.AdminID,
                        principalTable: "Admins",
                        principalColumn: "AdminID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    RouteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    TakeOff = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Landing = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    AdminID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteID);
                    table.ForeignKey(
                        name: "FK_Routes_Admins_AdminID",
                        column: x => x.AdminID,
                        principalTable: "Admins",
                        principalColumn: "AdminID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Routes_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID");
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    PlaneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaneName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SeatNum = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    UntakenSeat = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    TakenSeat = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    RouteID = table.Column<int>(type: "int", nullable: true),
                    AdminID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.PlaneID);
                    table.ForeignKey(
                        name: "FK_Planes_Admins_AdminID",
                        column: x => x.AdminID,
                        principalTable: "Admins",
                        principalColumn: "AdminID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Planes_Routes_RouteID",
                        column: x => x.RouteID,
                        principalTable: "Routes",
                        principalColumn: "RouteID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AdminID",
                table: "Customers",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_AdminID",
                table: "Planes",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_RouteID",
                table: "Planes",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_AdminID",
                table: "Routes",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_CustomerID",
                table: "Routes",
                column: "CustomerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
