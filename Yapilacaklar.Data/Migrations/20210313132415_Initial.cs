using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Yapilacaklar.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "Yapilacak",
                columns: table => new
                {
                    YapilacakID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Yapildi = table.Column<bool>(type: "bit", nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yapilacak", x => x.YapilacakID);
                    table.ForeignKey(
                        name: "FK_Yapilacak_Kullanici_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kullanici",
                columns: new[] { "KullaniciID", "Ad", "Soyad" },
                values: new object[] { 1, "Ahmet", "Yılmaz" });

            migrationBuilder.InsertData(
                table: "Kullanici",
                columns: new[] { "KullaniciID", "Ad", "Soyad" },
                values: new object[] { 2, "Mehmet", "Yılmaz" });

            migrationBuilder.InsertData(
                table: "Kullanici",
                columns: new[] { "KullaniciID", "Ad", "Soyad" },
                values: new object[] { 3, "Ayşe", "Yılmaz" });

            migrationBuilder.InsertData(
                table: "Yapilacak",
                columns: new[] { "YapilacakID", "Baslik", "Icerik", "KullaniciID", "Tarih", "Yapildi" },
                values: new object[] { 1, "Un al", "Un al", 1, new DateTime(2021, 3, 13, 16, 24, 15, 507, DateTimeKind.Local).AddTicks(8802), false });

            migrationBuilder.InsertData(
                table: "Yapilacak",
                columns: new[] { "YapilacakID", "Baslik", "Icerik", "KullaniciID", "Tarih", "Yapildi" },
                values: new object[] { 2, "Süt al", "Süt al", 2, new DateTime(2021, 3, 13, 16, 24, 15, 509, DateTimeKind.Local).AddTicks(445), false });

            migrationBuilder.InsertData(
                table: "Yapilacak",
                columns: new[] { "YapilacakID", "Baslik", "Icerik", "KullaniciID", "Tarih", "Yapildi" },
                values: new object[] { 3, "Yoğurt al", "Yoğurt al", 3, new DateTime(2021, 3, 13, 16, 24, 15, 509, DateTimeKind.Local).AddTicks(465), false });

            migrationBuilder.CreateIndex(
                name: "IX_Yapilacak_KullaniciID",
                table: "Yapilacak",
                column: "KullaniciID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yapilacak");

            migrationBuilder.DropTable(
                name: "Kullanici");
        }
    }
}
