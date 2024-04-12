using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCall.Migrations
{
    /// <inheritdoc />
    public partial class ModifieldTheShoppingInput : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "ShoppingInput");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "ShoppingInput",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
