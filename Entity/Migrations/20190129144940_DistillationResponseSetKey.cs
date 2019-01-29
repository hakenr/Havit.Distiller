using Microsoft.EntityFrameworkCore.Migrations;

namespace Havit.Distiller.Entity.Migrations
{
    public partial class DistillationResponseSetKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "DistillationResponseSet",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                table: "DistillationResponseSet");
        }
    }
}
