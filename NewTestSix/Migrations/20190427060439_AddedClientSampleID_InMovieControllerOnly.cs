using Microsoft.EntityFrameworkCore.Migrations;

namespace NewTestSix.Migrations
{
    public partial class AddedClientSampleID_InMovieControllerOnly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientSampleID",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientSampleID",
                table: "Movie");
        }
    }
}
