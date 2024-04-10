using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCall.Migrations
{
    /// <inheritdoc />
    public partial class AddingShoppimgData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingInput",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPriceM = table.Column<double>(type: "float", nullable: false),
                    ProductPriceF = table.Column<double>(type: "float", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categpories = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarRatings = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingInput", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingInput");
        }
    }
}
