using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodApp.PrimerAvance.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductosSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440000"),
                column: "OpcionesDieteticas",
                value: new List<string> { "Vegetariano" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440001"),
                column: "OpcionesDieteticas",
                value: new List<string> { "Sin gluten" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440002"),
                column: "OpcionesDieteticas",
                value: new List<string> { "Sin gluten" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440003"),
                column: "OpcionesDieteticas",
                value: new List<string> { "Vegetariano" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440004"),
                column: "OpcionesDieteticas",
                value: new List<string> { "Sin gluten opcional" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440005"),
                column: "OpcionesDieteticas",
                value: new List<string> { "Sin gluten opcional" });

            migrationBuilder.UpdateData(
                table: "Restaurantes",
                keyColumn: "Id",
                keyValue: new Guid("3708cfb0-1263-41ec-8e4f-58bec7d860e1"),
                column: "FechaCreacion",
                value: new DateTime(2025, 11, 18, 4, 27, 39, 716, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Restaurantes",
                keyColumn: "Id",
                keyValue: new Guid("f354ed19-48c6-4de0-a081-f39c6220eaaf"),
                column: "FechaCreacion",
                value: new DateTime(2025, 11, 18, 4, 27, 39, 716, DateTimeKind.Utc).AddTicks(3692));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440000"),
                column: "OpcionesDieteticas",
                value: new List<string> { "Vegetariano" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440001"),
                column: "OpcionesDieteticas",
                value: new List<string> { "Sin gluten" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440002"),
                column: "OpcionesDieteticas",
                value: new List<string> { "Sin gluten" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440003"),
                column: "OpcionesDieteticas",
                value: new List<string> { "Vegetariano" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440004"),
                column: "OpcionesDieteticas",
                value: new List<string> { "Sin gluten opcional" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440005"),
                column: "OpcionesDieteticas",
                value: new List<string> { "Sin gluten opcional" });

            migrationBuilder.UpdateData(
                table: "Restaurantes",
                keyColumn: "Id",
                keyValue: new Guid("3708cfb0-1263-41ec-8e4f-58bec7d860e1"),
                column: "FechaCreacion",
                value: new DateTime(2025, 11, 18, 4, 27, 2, 695, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Restaurantes",
                keyColumn: "Id",
                keyValue: new Guid("f354ed19-48c6-4de0-a081-f39c6220eaaf"),
                column: "FechaCreacion",
                value: new DateTime(2025, 11, 18, 4, 27, 2, 695, DateTimeKind.Utc).AddTicks(5134));
        }
    }
}
