using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCall.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedApllicationDBContextTOHAveUniqueCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UniqueCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UniqueCode",
                table: "AspNetUsers");
        }
    }
}
