using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BerthaApplication.Migrations
{
    public partial class BerthaApplicationModelsBerthaContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "HealthRecord",
                columns: table => new
                {
                    HealthRecordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Location = table.Column<string>(nullable: true),
                    RecordTime = table.Column<string>(nullable: true),
                    SystolicPressure = table.Column<double>(nullable: false),
                    DiastolicPressure = table.Column<double>(nullable: false),
                    BodyTemperature = table.Column<double>(nullable: false),
                    HeartBeatPerSecond = table.Column<int>(nullable: false),
                    Dust = table.Column<double>(nullable: false),
                    Sulphur = table.Column<double>(nullable: false),
                    Nitrogen = table.Column<double>(nullable: false),
                    Fluor = table.Column<double>(nullable: false),
                    CarbonMonoxide = table.Column<double>(nullable: false),
                    Ozone = table.Column<double>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthRecord", x => x.HealthRecordId);
                    table.ForeignKey(
                        name: "FK_HealthRecord_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HealthRecord_UserId",
                table: "HealthRecord",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HealthRecord");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
