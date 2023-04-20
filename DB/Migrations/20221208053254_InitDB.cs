using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemonx",
                columns: table => new
                {
                    IDPokemon = table.Column<int>(name: "ID_Pokemon", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pokemon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HP = table.Column<int>(type: "int", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    SpecialAttack = table.Column<int>(name: "Special_Attack", type: "int", nullable: false),
                    SpecialDefense = table.Column<int>(name: "Special_Defense", type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemonx", x => x.IDPokemon);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemonx");
        }
    }
}
