using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POO2_Projeto.Migrations
{
    /// <inheritdoc />
    public partial class TesteMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ABO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Cpf = table.Column<double>(type: "REAL", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    DataDeNascimento = table.Column<string>(type: "TEXT", nullable: false),
                    OrgaoExpedidor = table.Column<string>(type: "TEXT", nullable: false),
                    Naturalidade = table.Column<string>(type: "TEXT", nullable: false),
                    NomePai = table.Column<string>(type: "TEXT", nullable: false),
                    NomeMae = table.Column<string>(type: "TEXT", nullable: false),
                    Emprego = table.Column<string>(type: "TEXT", nullable: false),
                    Celular = table.Column<double>(type: "REAL", nullable: false),
                    CEP = table.Column<string>(type: "TEXT", nullable: false),
                    TipoSanguineoId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsPositivo = table.Column<bool>(type: "INTEGER", nullable: false),
                    Sexo = table.Column<string>(type: "TEXT", nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Cpf);
                    table.ForeignKey(
                        name: "FK_Users_ABO_TipoSanguineoId",
                        column: x => x.TipoSanguineoId,
                        principalTable: "ABO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_TipoSanguineoId",
                table: "Users",
                column: "TipoSanguineoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ABO");
        }
    }
}
