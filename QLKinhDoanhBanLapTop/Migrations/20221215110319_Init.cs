using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLKinhDoanhBanLapTop.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hang",
                columns: table => new
                {
                    MaHang = table.Column<string>(type: "varchar(20)", nullable: false),
                    TenHang = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DvTinh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DonGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hang", x => x.MaHang);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKH = table.Column<string>(type: "varchar(20)", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoDt = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    SoHD = table.Column<string>(type: "varchar(20)", nullable: false),
                    NgayPS = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoTienTT = table.Column<int>(type: "int", nullable: false),
                    LoaiHD = table.Column<string>(type: "varchar(1)", nullable: false),
                    MaKH = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.SoHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhThuChi",
                columns: table => new
                {
                    SoPhieu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoTien = table.Column<int>(type: "int", nullable: false),
                    LoaiPhieu = table.Column<string>(type: "varchar(1)", nullable: false),
                    MaKH = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhThuChi", x => x.SoPhieu);
                    table.ForeignKey(
                        name: "FK_PhThuChi_KhachHang_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHD",
                columns: table => new
                {
                    SoHD = table.Column<string>(type: "varchar(20)", nullable: false),
                    MaHang = table.Column<string>(type: "varchar(20)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHD", x => new { x.SoHD, x.MaHang });
                    table.ForeignKey(
                        name: "FK_ChiTietHD_Hang_MaHang",
                        column: x => x.MaHang,
                        principalTable: "Hang",
                        principalColumn: "MaHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHD_HoaDon_SoHD",
                        column: x => x.SoHD,
                        principalTable: "HoaDon",
                        principalColumn: "SoHD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHD_MaHang",
                table: "ChiTietHD",
                column: "MaHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKH",
                table: "HoaDon",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_PhThuChi_MaKH",
                table: "PhThuChi",
                column: "MaKH");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHD");

            migrationBuilder.DropTable(
                name: "PhThuChi");

            migrationBuilder.DropTable(
                name: "Hang");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "KhachHang");
        }
    }
}
