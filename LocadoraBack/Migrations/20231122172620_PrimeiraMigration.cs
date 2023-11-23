using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace LocadoraBack.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PESSOAS",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    pessoa_tipo = table.Column<int>(type: "int", nullable: false),
                    cpfcnpj = table.Column<string>(type: "longtext", nullable: false),
                    pessoa = table.Column<string>(type: "longtext", nullable: false),
                    telefone = table.Column<string>(type: "longtext", nullable: false),
                    email = table.Column<string>(type: "longtext", nullable: false),
                    pessoa_act = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PESSOAS", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VEICULOS",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    marca = table.Column<string>(type: "longtext", nullable: false),
                    modelo = table.Column<string>(type: "longtext", nullable: false),
                    ano = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    valor = table.Column<float>(type: "float", nullable: false),
                    combustivel = table.Column<string>(type: "longtext", nullable: false),
                    veiculo_act = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEICULOS", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TELEFONES",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<string>(type: "longtext", nullable: false),
                    DDD = table.Column<string>(type: "longtext", nullable: false),
                    PessoaId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TELEFONES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TELEFONES_PESSOAS_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "PESSOAS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PEDIDOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    PessoaId = table.Column<long>(type: "bigint", nullable: false),
                    VeiculoId = table.Column<long>(type: "bigint", nullable: false),
                    valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    data_locacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_retirada = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_devolucao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    forma_pgto = table.Column<string>(type: "longtext", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    ativo = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDOS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PEDIDOS_PESSOAS_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "PESSOAS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PEDIDOS_VEICULOS_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "VEICULOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDOS_PessoaId",
                table: "PEDIDOS",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDOS_VeiculoId",
                table: "PEDIDOS",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_TELEFONES_PessoaId",
                table: "TELEFONES",
                column: "PessoaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PEDIDOS");

            migrationBuilder.DropTable(
                name: "TELEFONES");

            migrationBuilder.DropTable(
                name: "VEICULOS");

            migrationBuilder.DropTable(
                name: "PESSOAS");
        }
    }
}
