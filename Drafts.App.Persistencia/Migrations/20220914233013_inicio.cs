using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drafts.App.Persistencia.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario_Frecuente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usuario_Nuevo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usuario_Normal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
