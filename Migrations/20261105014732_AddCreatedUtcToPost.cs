using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWithEf.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedUtcToPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Posts",
                newName: "CreatedUtc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedUtc",
                table: "Posts",
                newName: "CreatedAt");
        }
    }
}
