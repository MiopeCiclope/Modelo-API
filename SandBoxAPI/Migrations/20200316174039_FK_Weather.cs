using Microsoft.EntityFrameworkCore.Migrations;

namespace SandBoxAPI.Migrations
{
    public partial class FK_Weather : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "WeatherForecast",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeatherForecast_RegionId",
                table: "WeatherForecast",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherForecast_Region_RegionId",
                table: "WeatherForecast",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeatherForecast_Region_RegionId",
                table: "WeatherForecast");

            migrationBuilder.DropIndex(
                name: "IX_WeatherForecast_RegionId",
                table: "WeatherForecast");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "WeatherForecast");
        }
    }
}
