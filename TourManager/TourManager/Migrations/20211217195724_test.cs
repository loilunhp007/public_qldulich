using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TourManager.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaDiems",
                columns: table => new
                {
                    MaDd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaDiems", x => x.MaDd);
                });

            migrationBuilder.CreateTable(
                name: "Khachs",
                columns: table => new
                {
                    MaKhach = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cmnd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuocTich = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachs", x => x.MaKhach);
                });

            migrationBuilder.CreateTable(
                name: "LoaiCps",
                columns: table => new
                {
                    MaLoaiCp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiCp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiCps", x => x.MaLoaiCp);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTours",
                columns: table => new
                {
                    MaLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTours", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    MaNv = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.MaNv);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    MaTour = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DacDiem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.MaTour);
                    table.ForeignKey(
                        name: "FK_Tours_LoaiTours_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "LoaiTours",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BangGias",
                columns: table => new
                {
                    MaGia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiaTour = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Tgbd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tgkt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaTour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangGias", x => x.MaGia);
                    table.ForeignKey(
                        name: "FK_BangGias_Tours_MaTour",
                        column: x => x.MaTour,
                        principalTable: "Tours",
                        principalColumn: "MaTour",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CtTours",
                columns: table => new
                {
                    MaCtTour = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThuTu = table.Column<int>(type: "int", nullable: false),
                    MaTour = table.Column<int>(type: "int", nullable: false),
                    MaDd = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CtTours", x => x.MaCtTour);
                    table.ForeignKey(
                        name: "FK_CtTours_DiaDiems_MaDd",
                        column: x => x.MaDd,
                        principalTable: "DiaDiems",
                        principalColumn: "MaDd",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CtTours_Tours_MaTour",
                        column: x => x.MaTour,
                        principalTable: "Tours",
                        principalColumn: "MaTour",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doans",
                columns: table => new
                {
                    MaDoan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaTour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doans", x => x.MaDoan);
                    table.ForeignKey(
                        name: "FK_Doans_Tours_MaTour",
                        column: x => x.MaTour,
                        principalTable: "Tours",
                        principalColumn: "MaTour",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiPhis",
                columns: table => new
                {
                    MaCp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiaTien = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    MaLoaiCp = table.Column<int>(type: "int", nullable: false),
                    MaDoan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiPhis", x => x.MaCp);
                    table.ForeignKey(
                        name: "FK_ChiPhis_Doans_MaDoan",
                        column: x => x.MaDoan,
                        principalTable: "Doans",
                        principalColumn: "MaDoan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiPhis_LoaiCps_MaLoaiCp",
                        column: x => x.MaLoaiCp,
                        principalTable: "LoaiCps",
                        principalColumn: "MaLoaiCp",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CtDoans",
                columns: table => new
                {
                    MaCtDoan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDoan = table.Column<int>(type: "int", nullable: false),
                    MaKhach = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CtDoans", x => x.MaCtDoan);
                    table.ForeignKey(
                        name: "FK_CtDoans_Doans_MaDoan",
                        column: x => x.MaDoan,
                        principalTable: "Doans",
                        principalColumn: "MaDoan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CtDoans_Khachs_MaKhach",
                        column: x => x.MaKhach,
                        principalTable: "Khachs",
                        principalColumn: "MaKhach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhanCongs",
                columns: table => new
                {
                    MaPhanCong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhiemVu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaDoan = table.Column<int>(type: "int", nullable: false),
                    MaNv = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanCongs", x => x.MaPhanCong);
                    table.ForeignKey(
                        name: "FK_PhanCongs_Doans_MaDoan",
                        column: x => x.MaDoan,
                        principalTable: "Doans",
                        principalColumn: "MaDoan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhanCongs_NhanViens_MaNv",
                        column: x => x.MaNv,
                        principalTable: "NhanViens",
                        principalColumn: "MaNv",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DiaDiems",
                columns: new[] { "MaDd", "TenDd" },
                values: new object[,]
                {
                    { 1, "Sài Gòn" },
                    { 2, "Nha Trang" },
                    { 3, "Đà Lạt" },
                    { 4, "Phú Quốc" },
                    { 5, "Miền Tây" },
                    { 6, "Sapa" }
                });

            migrationBuilder.InsertData(
                table: "Khachs",
                columns: new[] { "MaKhach", "Cmnd", "DiaChi", "GioiTinh", "QuocTich", "Sdt", "Ten" },
                values: new object[,]
                {
                    { 10, "121234558", "Mỹ Tho", "Nữ", "Vietnam", "0123456780", "Trần Cúc Thị" },
                    { 8, "121234560", "Bến Tre", "Nữ", "Vietnam", "0123456782", "Trần Cúc" },
                    { 7, "121234561", "Kiên Giang", "Nam", "Vietnam", "0123456783", "Thị Cúc" },
                    { 6, "121234562", "Long An", "Nữ", "Vietnam", "0123456784", "Trần Thị Cúc" },
                    { 9, "121234559", "Củ Chi", "Nam", "Vietnam", "0123456781", "Trần Thị" },
                    { 4, "121234564", "Củ Chi", "Nam", "Vietnam", "0123456786", "Nguyễn Tèo" },
                    { 3, "121234565", "Mỹ Tho", "Nữ", "Vietnam", "0123456787", "Nguyễn Văn" },
                    { 2, "121234566", "Kiên Giang", "Nam", "Vietnam", "0123456788", "Văn Tèo" },
                    { 1, "121234567", "Long An", "Nữ", "Vietnam", "0123456789", "Nguyễn Văn Tèo" },
                    { 5, "121234563", "Bến Tre", "Nữ", "Vietnam", "0123456785", "Nguyễn Tèo Văn" }
                });

            migrationBuilder.InsertData(
                table: "LoaiCps",
                columns: new[] { "MaLoaiCp", "TenLoaiCp" },
                values: new object[,]
                {
                    { 1, "Chi phí ăn uống" },
                    { 2, "Chi phí phương tiện" },
                    { 3, "Chi phí khác" }
                });

            migrationBuilder.InsertData(
                table: "LoaiTours",
                columns: new[] { "MaLoai", "TenLoai" },
                values: new object[,]
                {
                    { 4, "Du lịch ẩm thực" },
                    { 3, "Du lịch xã hội và gia đình" },
                    { 2, "Du lịch kết hợp nghề nghiệp" },
                    { 1, "Du lịch di động" }
                });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "MaNv", "GioiTinh", "Sdt", "TenNv" },
                values: new object[,]
                {
                    { 6, "Nữ", "0198765437", "A Trần Văn" },
                    { 1, "Nam", "0198765432", "Lê Văn Tèo" },
                    { 2, "Nữ", "0198765433", "Lê Tèo Văn" },
                    { 3, "Nam", "0198765434", "Văn Lê Tèo" },
                    { 4, "Nữ", "0198765435", "Tèo Lê Văn" },
                    { 5, "Nam", "0198765436", "Trần Văn A" },
                    { 7, "Nam", "0198765438", "Trần A Văn" }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "MaTour", "DacDiem", "MaLoai", "TenTour" },
                values: new object[] { 3, "Đặc điểm tour 3", 2, "Tour 3" });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "MaTour", "DacDiem", "MaLoai", "TenTour" },
                values: new object[] { 2, null, 3, "Tour 2" });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "MaTour", "DacDiem", "MaLoai", "TenTour" },
                values: new object[] { 1, "Đặc điểm tour 1", 4, "Tour 1" });

            migrationBuilder.InsertData(
                table: "BangGias",
                columns: new[] { "MaGia", "GiaTour", "MaTour", "Tgbd", "Tgkt" },
                values: new object[,]
                {
                    { 3, 4000000m, 3, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, 3500000m, 2, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 1, 3000000m, 1, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "CtTours",
                columns: new[] { "MaCtTour", "MaDd", "MaTour", "ThuTu" },
                values: new object[,]
                {
                    { 8, 3, 3, 1 },
                    { 9, 6, 3, 2 },
                    { 4, 4, 1, 4 },
                    { 5, 6, 2, 1 },
                    { 6, 5, 2, 2 },
                    { 7, 4, 2, 3 },
                    { 3, 3, 1, 3 },
                    { 2, 2, 1, 2 },
                    { 1, 1, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Doans",
                columns: new[] { "MaDoan", "MaTour", "NgayBd", "NgayKt", "NoiDung", "TenDoan" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Nội dung 1", "Đoàn 1" },
                    { 4, 2, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Nội dung 4", "Đoàn 4" },
                    { 5, 2, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Nội dung 5", "Đoàn 5" },
                    { 2, 1, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Nội dung 2", "Đoàn 2" },
                    { 8, 3, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), "Nội dung 8", "Đoàn 8" },
                    { 7, 3, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), "Nội dung 7", "Đoàn 7" },
                    { 6, 2, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Nội dung 6", "Đoàn 6" },
                    { 3, 1, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Nội dung 3", "Đoàn 3" }
                });

            migrationBuilder.InsertData(
                table: "ChiPhis",
                columns: new[] { "MaCp", "GiaTien", "MaDoan", "MaLoaiCp" },
                values: new object[,]
                {
                    { 1, 1000000m, 1, 1 },
                    { 9, 50000m, 3, 3 },
                    { 8, 700000m, 3, 2 },
                    { 7, 1200000m, 3, 1 },
                    { 5, 500000m, 2, 2 },
                    { 4, 700000m, 2, 1 },
                    { 6, 1000000m, 2, 3 },
                    { 2, 1000000m, 1, 2 },
                    { 3, 1000000m, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "CtDoans",
                columns: new[] { "MaCtDoan", "MaDoan", "MaKhach" },
                values: new object[,]
                {
                    { 7, 2, 5 },
                    { 10, 3, 8 },
                    { 9, 3, 7 },
                    { 3, 1, 3 },
                    { 2, 1, 2 },
                    { 5, 2, 3 },
                    { 6, 2, 4 },
                    { 4, 1, 4 },
                    { 8, 2, 6 },
                    { 1, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "PhanCongs",
                columns: new[] { "MaPhanCong", "MaDoan", "MaNv", "NhiemVu" },
                values: new object[,]
                {
                    { 1, 1, 1, "Lái xe" },
                    { 5, 2, 5, "Lái xe" },
                    { 7, 3, 3, "Lái xe" },
                    { 4, 1, 4, "Phục vụ" },
                    { 3, 1, 3, "Thông dịch viên" },
                    { 2, 1, 2, "Hướng dẫn viên" },
                    { 6, 2, 6, "Hướng dẫn viên" },
                    { 8, 3, 4, "Phục vụ" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BangGias_MaTour",
                table: "BangGias",
                column: "MaTour");

            migrationBuilder.CreateIndex(
                name: "IX_ChiPhis_MaDoan",
                table: "ChiPhis",
                column: "MaDoan");

            migrationBuilder.CreateIndex(
                name: "IX_ChiPhis_MaLoaiCp",
                table: "ChiPhis",
                column: "MaLoaiCp");

            migrationBuilder.CreateIndex(
                name: "IX_CtDoans_MaDoan",
                table: "CtDoans",
                column: "MaDoan");

            migrationBuilder.CreateIndex(
                name: "IX_CtDoans_MaKhach",
                table: "CtDoans",
                column: "MaKhach");

            migrationBuilder.CreateIndex(
                name: "IX_CtTours_MaDd",
                table: "CtTours",
                column: "MaDd");

            migrationBuilder.CreateIndex(
                name: "IX_CtTours_MaTour",
                table: "CtTours",
                column: "MaTour");

            migrationBuilder.CreateIndex(
                name: "IX_Doans_MaTour",
                table: "Doans",
                column: "MaTour");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCongs_MaDoan",
                table: "PhanCongs",
                column: "MaDoan");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCongs_MaNv",
                table: "PhanCongs",
                column: "MaNv");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_MaLoai",
                table: "Tours",
                column: "MaLoai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BangGias");

            migrationBuilder.DropTable(
                name: "ChiPhis");

            migrationBuilder.DropTable(
                name: "CtDoans");

            migrationBuilder.DropTable(
                name: "CtTours");

            migrationBuilder.DropTable(
                name: "PhanCongs");

            migrationBuilder.DropTable(
                name: "LoaiCps");

            migrationBuilder.DropTable(
                name: "Khachs");

            migrationBuilder.DropTable(
                name: "DiaDiems");

            migrationBuilder.DropTable(
                name: "Doans");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "LoaiTours");
        }
    }
}
