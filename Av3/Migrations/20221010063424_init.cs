using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIProjetoUpd8.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "disciplinas",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDisciplina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CargaHoraria = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_disciplinas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "disciplinas");
        }
    }
}
