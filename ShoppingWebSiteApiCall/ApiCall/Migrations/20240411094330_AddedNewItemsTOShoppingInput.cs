using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCall.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewItemsTOShoppingInput : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "StarRatings",
                table: "ShoppingInput",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ItemsRemaining",
                table: "ShoppingInput",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemsRemaining",
                table: "ShoppingInput");

            migrationBuilder.AlterColumn<int>(
                name: "StarRatings",
                table: "ShoppingInput",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
