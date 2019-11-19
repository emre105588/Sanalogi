using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrnekProje.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "faturas",
                columns: table => new
                {
                    faturaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    faturaTarihi = table.Column<DateTime>(nullable: false),
                    genelToplam = table.Column<decimal>(nullable: false),
                    faturaNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faturas", x => x.faturaId);
                });

            migrationBuilder.CreateTable(
                name: "musteris",
                columns: table => new
                {
                    musteriId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ad = table.Column<string>(nullable: true),
                    soyad = table.Column<string>(nullable: true),
                    adres = table.Column<string>(nullable: true),
                    eposta = table.Column<string>(nullable: true),
                    telefon = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_musteris", x => x.musteriId);
                });

            migrationBuilder.CreateTable(
                name: "alinanUruns",
                columns: table => new
                {
                    alinanUrunId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    urunAdi = table.Column<string>(nullable: false),
                    adet = table.Column<int>(nullable: false),
                    birimFiyat = table.Column<decimal>(nullable: false),
                    toplam = table.Column<decimal>(nullable: false),
                    musteriId = table.Column<int>(nullable: true),
                    faturaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alinanUruns", x => x.alinanUrunId);
                    table.ForeignKey(
                        name: "FK_alinanUruns_faturas_faturaId",
                        column: x => x.faturaId,
                        principalTable: "faturas",
                        principalColumn: "faturaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_alinanUruns_musteris_musteriId",
                        column: x => x.musteriId,
                        principalTable: "musteris",
                        principalColumn: "musteriId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_alinanUruns_faturaId",
                table: "alinanUruns",
                column: "faturaId");

            migrationBuilder.CreateIndex(
                name: "IX_alinanUruns_musteriId",
                table: "alinanUruns",
                column: "musteriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alinanUruns");

            migrationBuilder.DropTable(
                name: "faturas");

            migrationBuilder.DropTable(
                name: "musteris");
        }
    }
}
