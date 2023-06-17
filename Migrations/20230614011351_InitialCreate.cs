using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiFutsal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Camisa",
                columns: table => new
                {
                    CamisaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JogadorId = table.Column<int>(type: "int", nullable: false),
                    CamisaNumero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camisa", x => x.CamisaId);
                });

            migrationBuilder.CreateTable(
                name: "Jogadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsavel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Posicao = table.Column<int>(type: "int", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogadores", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Camisa",
                columns: new[] { "CamisaId", "CamisaNumero", "JogadorId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 },
                    { 6, 6, 6 },
                    { 7, 7, 7 },
                    { 8, 8, 8 },
                    { 9, 9, 9 },
                    { 10, 10, 10 },
                    { 11, 11, 11 }
                });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "Id", "CPF", "Nome", "Posicao", "Responsavel" },
                values: new object[,]
                {
                    { 1, "509885211-11", "Gustavo Almeida", 1, "Isrraela" },
                    { 2, "455202582-27", "Heverson", 1, "Cindir" },
                    { 3, "523648782-19", "Cauã", 3, "Daniela" },
                    { 4, "485213251-15", "Matheus", 3, "Carmem" },
                    { 5, "502202144-46", "Kauan", 2, "Aline" },
                    { 6, "648558967-79", "Daniel", 2, "Lurdes" },
                    { 7, "002147858-44", "Luan", 2, "Cleide" },
                    { 8, "124525428-88", "Kaue", 2, "Charlene" },
                    { 9, "889652125-45", "Weverton", 4, "Geraldina" },
                    { 10, "551031366-84", "Gustavo", 4, "Erismelk" },
                    { 11, "554102123-54", "Lucas", 4, "Tatiana" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Camisa");

            migrationBuilder.DropTable(
                name: "Jogadores");
        }
    }
}
