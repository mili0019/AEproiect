using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AEproiect.Server.Migrations
{
    /// <inheritdoc />
    public partial class ChangePricesVariants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 44.99m, 34.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 25.99m, 10.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 46.99m, 20.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 22.99m, 10.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 25.99m, 4.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 25.99m, 23.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 25.99m, 21.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 18.99m, 12.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 63.99m, 45.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 4 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 69.99m, 50.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 6, 4 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 51.99m, 10.99m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 19.99m, 9.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 19.99m, 9.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 19.99m, 9.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 19.99m, 9.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 19.99m, 9.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 19.99m, 9.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 19.99m, 9.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 19.99m, 9.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 19.99m, 9.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 4 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 19.99m, 9.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 6, 4 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 19.99m, 9.99m });
        }
    }
}
