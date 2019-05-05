using Microsoft.EntityFrameworkCore.Migrations;

namespace NewTestSix.Migrations
{
    public partial class AddedTableFormFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AcidStables",
                table: "TableForm",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<bool>(
                name: "FAAs",
                table: "TableForm",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Trp",
                table: "TableForm",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FAAs",
                table: "TableForm");

            migrationBuilder.DropColumn(
                name: "Trp",
                table: "TableForm");

            migrationBuilder.AlterColumn<bool>(
                name: "AcidStables",
                table: "TableForm",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
