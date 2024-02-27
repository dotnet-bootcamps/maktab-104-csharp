using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace S36_ConsoleApp_EfCore_DbDesign.Migrations
{
    /// <inheritdoc />
    public partial class AddAutherId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutherId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutherId",
                table: "Posts");
        }
    }
}
