using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NichDevDotNetCore.Data.Migrations
{
    public partial class add_votes_attribute_to_post : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Votes",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Votes",
                table: "Posts");
        }
    }
}
