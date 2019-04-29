using Microsoft.EntityFrameworkCore.Migrations;

namespace NewTestSix.Migrations
{
    public partial class AddedSomeValidationToSubmitFormV2Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ClientSampleID",
                table: "SubmitFormV2",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ClientSampleID",
                table: "SubmitFormV2",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);
        }
    }
}
