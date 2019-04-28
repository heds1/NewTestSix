using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewTestSix.Migrations
{
    public partial class SubmitFormV2_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubmitFormV2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientSampleID = table.Column<string>(nullable: true),
                    AcidStables = table.Column<bool>(nullable: false),
                    Sulfurs = table.Column<bool>(nullable: false),
                    Trp = table.Column<bool>(nullable: false),
                    FAAs = table.Column<bool>(nullable: false),
                    AdditionalComments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubmitFormV2", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubmitFormV2");
        }
    }
}
