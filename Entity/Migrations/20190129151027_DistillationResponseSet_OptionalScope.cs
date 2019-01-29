using Microsoft.EntityFrameworkCore.Migrations;

namespace Havit.Distiller.Entity.Migrations
{
    public partial class DistillationResponseSet_OptionalScope : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ScopeId",
                table: "DistillationResponseSet",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ScopeId",
                table: "DistillationResponseSet",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
