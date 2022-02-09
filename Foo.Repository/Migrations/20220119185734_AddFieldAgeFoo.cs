using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Foo.Repository.Migrations
{
    public partial class AddFieldAgeFoo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "foo",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "foo");
        }
    }
}
