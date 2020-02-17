using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IlanProjesi.Migrations
{
    public partial class dokuz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "araba",
                columns: table => new
                {
                    ArabaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArabaModel = table.Column<string>(nullable: true),
                    ArabaFiyat = table.Column<decimal>(nullable: false),
                    ArabaAdres = table.Column<string>(nullable: true),
                    ArabaAcıklama = table.Column<string>(nullable: true),
                    ArabaResim = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_araba", x => x.ArabaId);
                });

            migrationBuilder.CreateTable(
                name: "ıs",
                columns: table => new
                {
                    IsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsAcıklama = table.Column<string>(nullable: true),
                    IsAdres = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ıs", x => x.IsId);
                });

            migrationBuilder.CreateTable(
                name: "konut",
                columns: table => new
                {
                    KonutId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KonutFiyat = table.Column<decimal>(nullable: false),
                    KonutAdres = table.Column<string>(nullable: true),
                    KonutAçıklama = table.Column<string>(nullable: true),
                    KonutResim = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_konut", x => x.KonutId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "araba");

            migrationBuilder.DropTable(
                name: "ıs");

            migrationBuilder.DropTable(
                name: "konut");
        }
    }
}
