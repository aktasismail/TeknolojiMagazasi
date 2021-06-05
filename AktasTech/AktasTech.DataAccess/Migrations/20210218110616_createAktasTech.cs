using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AktasTech.DataAccess.Migrations
{
    public partial class createAktasTech : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorilers",
                columns: table => new
                {
                    KategoriId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KategoriAd = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorilers", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Urunlers",
                columns: table => new
                {
                    UrunId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UrunAd = table.Column<string>(nullable: false),
                    KategoriId = table.Column<int>(nullable: false),
                    Fiyat = table.Column<decimal>(nullable: false),
                    Stok = table.Column<short>(nullable: false),
                    Gorsel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunlers", x => x.UrunId);
                    table.ForeignKey(
                        name: "FK_Urunlers_Kategorilers_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategorilers",
                        principalColumn: "KategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urunlers_KategoriId",
                table: "Urunlers",
                column: "KategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urunlers");

            migrationBuilder.DropTable(
                name: "Kategorilers");
        }
    }
}
