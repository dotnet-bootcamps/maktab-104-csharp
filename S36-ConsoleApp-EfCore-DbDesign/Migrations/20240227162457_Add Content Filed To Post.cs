using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace S36_ConsoleApp_EfCore_DbDesign.Migrations
{
    /// <inheritdoc />
    public partial class AddContentFiledToPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Posts");
        }
    }
}
