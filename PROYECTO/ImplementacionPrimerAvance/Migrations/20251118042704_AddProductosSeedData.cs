using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodApp.PrimerAvance.Migrations
{
    /// <inheritdoc />
    public partial class AddProductosSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Restaurantes_RestauranteId1",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_RestauranteId1",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "RestauranteId1",
                table: "Productos");

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Categoria", "Descripcion", "Disponible", "Imagen", "Nombre", "OpcionesDieteticas", "Precio", "RestauranteId" },
                values: new object[,]
                {
                    { new Guid("550e8400-e29b-41d4-a716-446655440000"), "Sushi", "Roll de sushi con aguacate, pepino y cangrejo", true, null, "Sushi Roll California", new List<string> { "Vegetariano" }, 12.50m, new Guid("3708cfb0-1263-41ec-8e4f-58bec7d860e1") },
                    { new Guid("550e8400-e29b-41d4-a716-446655440001"), "Sashimi", "Fresco sashimi de salmón noruego", true, null, "Sashimi de Salmón", new List<string> { "Sin gluten" }, 15.00m, new Guid("3708cfb0-1263-41ec-8e4f-58bec7d860e1") },
                    { new Guid("550e8400-e29b-41d4-a716-446655440002"), "Tempura", "Camarones rebozados y fritos", true, null, "Tempura de Camarón", new List<string> { "Sin gluten" }, 10.00m, new Guid("3708cfb0-1263-41ec-8e4f-58bec7d860e1") },
                    { new Guid("550e8400-e29b-41d4-a716-446655440003"), "Pizza", "Pizza clásica con mozzarella, tomate y albahaca", true, null, "Pizza Margherita", new List<string> { "Vegetariano" }, 14.00m, new Guid("f354ed19-48c6-4de0-a081-f39c6220eaaf") },
                    { new Guid("550e8400-e29b-41d4-a716-446655440004"), "Pasta", "Pasta con salsa carbonara tradicional", true, null, "Pasta Carbonara", new List<string> { "Sin gluten opcional" }, 13.50m, new Guid("f354ed19-48c6-4de0-a081-f39c6220eaaf") },
                    { new Guid("550e8400-e29b-41d4-a716-446655440005"), "Pasta", "Lasagna casera con carne y salsa boloñesa", true, null, "Lasagna Bolognese", new List<string> { "Sin gluten opcional" }, 16.00m, new Guid("f354ed19-48c6-4de0-a081-f39c6220eaaf") }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440000"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440001"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440002"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440003"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440004"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440005"));

            migrationBuilder.AddColumn<Guid>(
                name: "RestauranteId1",
                table: "Productos",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Restaurantes",
                keyColumn: "Id",
                keyValue: new Guid("3708cfb0-1263-41ec-8e4f-58bec7d860e1"),
                column: "FechaCreacion",
                value: new DateTime(2025, 11, 13, 0, 24, 38, 984, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Restaurantes",
                keyColumn: "Id",
                keyValue: new Guid("f354ed19-48c6-4de0-a081-f39c6220eaaf"),
                column: "FechaCreacion",
                value: new DateTime(2025, 11, 13, 0, 24, 38, 984, DateTimeKind.Utc).AddTicks(9334));

            migrationBuilder.CreateIndex(
                name: "IX_Productos_RestauranteId1",
                table: "Productos",
                column: "RestauranteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Restaurantes_RestauranteId1",
                table: "Productos",
                column: "RestauranteId1",
                principalTable: "Restaurantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
