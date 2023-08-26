using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lesson14.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Products",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Products");
        }
    }
}
