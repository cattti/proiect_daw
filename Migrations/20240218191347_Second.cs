using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proiect_daw.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "likeCount",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "likeCount",
                table: "Artworks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "likeCount",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "likeCount",
                table: "Artworks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
