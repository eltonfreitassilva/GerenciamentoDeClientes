using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciamentoDeClientes.Infra.Migrations
{
    public partial class MapCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "uf",
                table: "Cliente",
                newName: "UF");

            migrationBuilder.RenameColumn(
                name: "sexo",
                table: "Cliente",
                newName: "Sexo");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Cliente",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Cliente",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Cliente",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "complementoEndereco",
                table: "Cliente",
                newName: "ComplementoEndereco");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "Cliente",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "Cliente",
                newName: "Cep");

            migrationBuilder.RenameColumn(
                name: "bairro",
                table: "Cliente",
                newName: "Bairro");

            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "Cliente",
                type: "nvarchar(3)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Cliente",
                type: "nvarchar(2)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "dNascimento",
                table: "Cliente",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "dDataCadastro",
                table: "Cliente",
                type: "datetime2(0)",
                precision: 0,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Cliente",
                type: "nvarchar(15)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ComplementoEndereco",
                table: "Cliente",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Cliente",
                type: "nvarchar(150)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Cliente",
                type: "nvarchar(10)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Cliente",
                type: "nvarchar(150)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "idCliente",
                table: "Cliente",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "idCliente",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "UF",
                table: "Cliente",
                newName: "uf");

            migrationBuilder.RenameColumn(
                name: "Sexo",
                table: "Cliente",
                newName: "sexo");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cliente",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Cliente",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Cliente",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "ComplementoEndereco",
                table: "Cliente",
                newName: "complementoEndereco");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Cliente",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "Cliente",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Bairro",
                table: "Cliente",
                newName: "bairro");

            migrationBuilder.AlterColumn<DateTime>(
                name: "dNascimento",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "dDataCadastro",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)",
                oldPrecision: 0);

            migrationBuilder.AlterColumn<string>(
                name: "uf",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)");

            migrationBuilder.AlterColumn<string>(
                name: "sexo",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)");

            migrationBuilder.AlterColumn<string>(
                name: "complementoEndereco",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)");

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)");

            migrationBuilder.AlterColumn<string>(
                name: "cep",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "bairro",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");
        }
    }
}
