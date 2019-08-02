using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Files_Tree.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Node",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nodeName = table.Column<string>(nullable: true),
                    parentNodeid = table.Column<int>(nullable: true),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Node", x => x.id);
                    table.ForeignKey(
                        name: "FK_Node_Node_parentNodeid",
                        column: x => x.parentNodeid,
                        principalTable: "Node",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "File",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fileName = table.Column<string>(nullable: true),
                    parentNodeid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_File", x => x.id);
                    table.ForeignKey(
                        name: "FK_File_Node_parentNodeid",
                        column: x => x.parentNodeid,
                        principalTable: "Node",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_File_parentNodeid",
                table: "File",
                column: "parentNodeid");

            migrationBuilder.CreateIndex(
                name: "IX_Node_parentNodeid",
                table: "Node",
                column: "parentNodeid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "File");

            migrationBuilder.DropTable(
                name: "Node");
        }
    }
}
