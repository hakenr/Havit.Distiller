using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Havit.Distiller.Entity.Migrations
{
    public partial class DistillationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DistillationItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistillationItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistillationScope",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistillationScope", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistillationResponseSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScopeId = table.Column<int>(nullable: false),
                    Submitter = table.Column<string>(maxLength: 100, nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistillationResponseSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DistillationResponseSet_DistillationScope_ScopeId",
                        column: x => x.ScopeId,
                        principalTable: "DistillationScope",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DistillationResponseItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ResponseSetId = table.Column<int>(nullable: false),
                    DistillationItemId = table.Column<int>(nullable: false),
                    ResponseValue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistillationResponseItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DistillationResponseItem_DistillationItem_DistillationItemId",
                        column: x => x.DistillationItemId,
                        principalTable: "DistillationItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DistillationResponseItem_DistillationResponseSet_ResponseSetId",
                        column: x => x.ResponseSetId,
                        principalTable: "DistillationResponseSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DistillationResponseItem_DistillationItemId",
                table: "DistillationResponseItem",
                column: "DistillationItemId");

            migrationBuilder.CreateIndex(
                name: "IX_DistillationResponseItem_ResponseSetId",
                table: "DistillationResponseItem",
                column: "ResponseSetId");

            migrationBuilder.CreateIndex(
                name: "IX_DistillationResponseSet_ScopeId",
                table: "DistillationResponseSet",
                column: "ScopeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistillationResponseItem");

            migrationBuilder.DropTable(
                name: "DistillationItem");

            migrationBuilder.DropTable(
                name: "DistillationResponseSet");

            migrationBuilder.DropTable(
                name: "DistillationScope");
        }
    }
}
