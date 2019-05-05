using Microsoft.EntityFrameworkCore.Migrations;

namespace NewTestSix.Migrations
{
    public partial class MoreTableFormFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "_sampleMatrix",
                table: "TableForm",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_sampleMatrix",
                table: "TableForm");
        }
    }
}
