using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace app1_Migrations.Migrations
{
    /// <inheritdoc />
    public partial class dbUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Apellido = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Dirección = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Telefono = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    fechaDeNacimiento = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    Status = table.Column<string>(type: "VARCHAR(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
