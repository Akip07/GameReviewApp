using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameReviewApp.Migrations
{
    /// <inheritdoc />
    public partial class addedreviewcount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "reviewCount",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "reviewCount",
                table: "Game");
        }
    }
}
