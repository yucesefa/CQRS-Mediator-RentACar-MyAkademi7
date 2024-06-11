using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarProject.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeliveryLocation",
                columns: table => new
                {
                    DeliveryLocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryLocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryLocation", x => x.DeliveryLocationId);
                });

            migrationBuilder.CreateTable(
                name: "ReceivingLocation",
                columns: table => new
                {
                    ReceivingLocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceivingLocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivingLocation", x => x.ReceivingLocationId);
                });

            migrationBuilder.CreateTable(
                name: "RentACar",
                columns: table => new
                {
                    RentACarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    ReceivingLocationId = table.Column<int>(type: "int", nullable: false),
                    DeliveryLocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentACar", x => x.RentACarId);
                    table.ForeignKey(
                        name: "FK_RentACar_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentACar_DeliveryLocation_DeliveryLocationId",
                        column: x => x.DeliveryLocationId,
                        principalTable: "DeliveryLocation",
                        principalColumn: "DeliveryLocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentACar_ReceivingLocation_ReceivingLocationId",
                        column: x => x.ReceivingLocationId,
                        principalTable: "ReceivingLocation",
                        principalColumn: "ReceivingLocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentACar_CarId",
                table: "RentACar",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_RentACar_DeliveryLocationId",
                table: "RentACar",
                column: "DeliveryLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_RentACar_ReceivingLocationId",
                table: "RentACar",
                column: "ReceivingLocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentACar");

            migrationBuilder.DropTable(
                name: "DeliveryLocation");

            migrationBuilder.DropTable(
                name: "ReceivingLocation");
        }
    }
}
