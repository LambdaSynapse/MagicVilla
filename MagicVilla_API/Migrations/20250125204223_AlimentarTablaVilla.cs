using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImageUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa Real", new DateTime(2025, 1, 25, 21, 42, 23, 163, DateTimeKind.Local).AddTicks(7367), new DateTime(2025, 1, 25, 21, 42, 23, 163, DateTimeKind.Local).AddTicks(7322), "", 500, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de Vailla Pago", new DateTime(2025, 1, 25, 21, 42, 23, 163, DateTimeKind.Local).AddTicks(7371), new DateTime(2025, 1, 25, 21, 42, 23, 163, DateTimeKind.Local).AddTicks(7370), "", 700, "Villa Pago", 10, 300.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
