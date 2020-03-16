using Microsoft.EntityFrameworkCore.Migrations;

namespace SandBoxAPI.Migrations
{
    public partial class FK_RegionCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Region_CountryId",
                table: "Region",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Region_Country_CountryId",
                table: "Region",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Region_Country_CountryId",
                table: "Region");

            migrationBuilder.DropIndex(
                name: "IX_Region_CountryId",
                table: "Region");
        }
    }
}
