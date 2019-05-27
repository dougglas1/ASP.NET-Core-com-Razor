using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class CriacaoBancoDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente3",
                columns: table => new
                {
                    Cliente3Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente3", x => x.Cliente3Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa1",
                columns: table => new
                {
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "ntext", nullable: true),
                    CPF = table.Column<string>(type: "ntext", nullable: true),
                    Nascimento = table.Column<DateTime>(type: "date", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa1", x => x.PessoaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente3");

            migrationBuilder.DropTable(
                name: "Pessoa1");
        }
    }
}
