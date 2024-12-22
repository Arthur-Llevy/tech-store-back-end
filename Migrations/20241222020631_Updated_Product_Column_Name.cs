using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tech_store.Migrations
{
    /// <inheritdoc />
    public partial class Updated_Product_Column_Name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_produto",
                table: "produto");

            migrationBuilder.RenameTable(
                name: "produto",
                newName: "product");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "product",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product",
                table: "product",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_product",
                table: "product");

            migrationBuilder.RenameTable(
                name: "product",
                newName: "produto");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "produto",
                newName: "Nome");

            migrationBuilder.AddPrimaryKey(
                name: "PK_produto",
                table: "produto",
                column: "Id");
        }
    }
}
