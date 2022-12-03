using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sequences.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterSequence(
                name: "EC_Sequence",
                incrementBy: 5);

            migrationBuilder.RestartSequence(
                name: "EC_Sequence",
                startValue: 100L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterSequence(
                name: "EC_Sequence",
                oldIncrementBy: 5);

            migrationBuilder.RestartSequence(
                name: "EC_Sequence",
                startValue: 1L);
        }
    }
}
