using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace desafio_mvc.Migrations
{
    public partial class AddAlocar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alocars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VagaIDId = table.Column<int>(nullable: true),
                    FuncionarioIDId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alocars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alocars_Funcionarios_FuncionarioIDId",
                        column: x => x.FuncionarioIDId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alocars_Vagas_VagaIDId",
                        column: x => x.VagaIDId,
                        principalTable: "Vagas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alocars_FuncionarioIDId",
                table: "Alocars",
                column: "FuncionarioIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Alocars_VagaIDId",
                table: "Alocars",
                column: "VagaIDId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alocars");
        }
    }
}
