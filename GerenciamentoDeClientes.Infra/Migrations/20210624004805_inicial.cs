using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciamentoDeClientes.Infra.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    complementoEndereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dDataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ativo = table.Column<bool>(type: "bit", nullable: false),
                    deletado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
