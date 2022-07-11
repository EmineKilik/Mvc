using Microsoft.EntityFrameworkCore.Migrations;

namespace finalhazirlik.Migrations
{
    public partial class Ogrenciler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblogrenci",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciAd = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    OgrenciSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OgrenciVize = table.Column<float>(type: "real", nullable: false),
                    OgrenciFinal = table.Column<float>(type: "real", nullable: false),
                    OgrenciOrtalama = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblogrenci", x => x.OgrenciId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblogrenci");
        }
    }
}
