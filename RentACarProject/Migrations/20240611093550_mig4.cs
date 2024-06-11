using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarProject.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACar_Cars_CarId",
                table: "RentACar");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACar_DeliveryLocation_DeliveryLocationId",
                table: "RentACar");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACar_ReceivingLocation_ReceivingLocationId",
                table: "RentACar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentACar",
                table: "RentACar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReceivingLocation",
                table: "ReceivingLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryLocation",
                table: "DeliveryLocation");

            migrationBuilder.RenameTable(
                name: "RentACar",
                newName: "RentACars");

            migrationBuilder.RenameTable(
                name: "ReceivingLocation",
                newName: "ReceivingLocations");

            migrationBuilder.RenameTable(
                name: "DeliveryLocation",
                newName: "DeliveryLocations");

            migrationBuilder.RenameIndex(
                name: "IX_RentACar_ReceivingLocationId",
                table: "RentACars",
                newName: "IX_RentACars_ReceivingLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_RentACar_DeliveryLocationId",
                table: "RentACars",
                newName: "IX_RentACars_DeliveryLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_RentACar_CarId",
                table: "RentACars",
                newName: "IX_RentACars_CarId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "RentACars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReceivingDate",
                table: "RentACars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentACars",
                table: "RentACars",
                column: "RentACarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReceivingLocations",
                table: "ReceivingLocations",
                column: "ReceivingLocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryLocations",
                table: "DeliveryLocations",
                column: "DeliveryLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACars_Cars_CarId",
                table: "RentACars",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACars_DeliveryLocations_DeliveryLocationId",
                table: "RentACars",
                column: "DeliveryLocationId",
                principalTable: "DeliveryLocations",
                principalColumn: "DeliveryLocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACars_ReceivingLocations_ReceivingLocationId",
                table: "RentACars",
                column: "ReceivingLocationId",
                principalTable: "ReceivingLocations",
                principalColumn: "ReceivingLocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACars_Cars_CarId",
                table: "RentACars");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACars_DeliveryLocations_DeliveryLocationId",
                table: "RentACars");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACars_ReceivingLocations_ReceivingLocationId",
                table: "RentACars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentACars",
                table: "RentACars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReceivingLocations",
                table: "ReceivingLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryLocations",
                table: "DeliveryLocations");

            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "RentACars");

            migrationBuilder.DropColumn(
                name: "ReceivingDate",
                table: "RentACars");

            migrationBuilder.RenameTable(
                name: "RentACars",
                newName: "RentACar");

            migrationBuilder.RenameTable(
                name: "ReceivingLocations",
                newName: "ReceivingLocation");

            migrationBuilder.RenameTable(
                name: "DeliveryLocations",
                newName: "DeliveryLocation");

            migrationBuilder.RenameIndex(
                name: "IX_RentACars_ReceivingLocationId",
                table: "RentACar",
                newName: "IX_RentACar_ReceivingLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_RentACars_DeliveryLocationId",
                table: "RentACar",
                newName: "IX_RentACar_DeliveryLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_RentACars_CarId",
                table: "RentACar",
                newName: "IX_RentACar_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentACar",
                table: "RentACar",
                column: "RentACarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReceivingLocation",
                table: "ReceivingLocation",
                column: "ReceivingLocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryLocation",
                table: "DeliveryLocation",
                column: "DeliveryLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACar_Cars_CarId",
                table: "RentACar",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACar_DeliveryLocation_DeliveryLocationId",
                table: "RentACar",
                column: "DeliveryLocationId",
                principalTable: "DeliveryLocation",
                principalColumn: "DeliveryLocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACar_ReceivingLocation_ReceivingLocationId",
                table: "RentACar",
                column: "ReceivingLocationId",
                principalTable: "ReceivingLocation",
                principalColumn: "ReceivingLocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
