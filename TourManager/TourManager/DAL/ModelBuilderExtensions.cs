using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManager.Models;

namespace TourManager.DAL
{
    public static class ModelBuilderExtensions 
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiTour>().HasData(
                new LoaiTour { MaLoai = 1, TenLoai = "Du lịch di động" },
                new LoaiTour { MaLoai = 2, TenLoai = "Du lịch kết hợp nghề nghiệp" },
                new LoaiTour { MaLoai = 3, TenLoai = "Du lịch xã hội và gia đình" },
                new LoaiTour { MaLoai = 4, TenLoai = "Du lịch ẩm thực" });

             modelBuilder.Entity<Tour>().HasData(
                 new Tour { MaTour = 1, TenTour = "Tour 1", MaLoai = 4, DacDiem = "Đặc điểm tour 1"  },
                 new Tour { MaTour = 2, TenTour = "Tour 2", MaLoai = 3, DacDiem = null  },
                 new Tour { MaTour = 3, TenTour = "Tour 3", MaLoai = 2, DacDiem = "Đặc điểm tour 3"  });

            modelBuilder.Entity<BangGia>().HasData(
                new BangGia { MaGia = 1, MaTour = 1, Tgbd = DateTime.Now.Date, Tgkt = DateTime.Now.AddMonths(1).Date, GiaTour = 3000000 },
                new BangGia { MaGia = 2, MaTour = 2, Tgbd = DateTime.Now.Date, Tgkt = DateTime.Now.AddMonths(1).AddDays(15).Date, GiaTour = 3500000 },
                new BangGia { MaGia = 3, MaTour = 3, Tgbd = DateTime.Now.Date, Tgkt = DateTime.Now.AddDays(15).Date, GiaTour = 4000000 }
                );

            modelBuilder.Entity<DiaDiem>().HasData(
                new DiaDiem { MaDd = 1, TenDd = "Sài Gòn" },
                new DiaDiem { MaDd = 2, TenDd = "Nha Trang" },
                new DiaDiem { MaDd = 3, TenDd = "Đà Lạt" },
                new DiaDiem { MaDd = 4, TenDd = "Phú Quốc" },
                new DiaDiem { MaDd = 5, TenDd = "Miền Tây" },
                new DiaDiem { MaDd = 6, TenDd = "Sapa" }
                );

            modelBuilder.Entity<CtTour>().HasData(
                new CtTour { MaCtTour = 1, MaTour = 1, MaDd = 1, ThuTu = 1},
                new CtTour { MaCtTour = 2, MaTour = 1, MaDd = 2, ThuTu = 2},
                new CtTour { MaCtTour = 3, MaTour = 1, MaDd = 3, ThuTu = 3},
                new CtTour { MaCtTour = 4, MaTour = 1, MaDd = 4, ThuTu = 4},

                new CtTour { MaCtTour = 5, MaTour = 2, MaDd = 6, ThuTu = 1},
                new CtTour { MaCtTour = 6, MaTour = 2, MaDd = 5, ThuTu = 2},
                new CtTour { MaCtTour = 7, MaTour = 2, MaDd = 4, ThuTu = 3},

                new CtTour { MaCtTour = 8, MaTour = 3, MaDd = 3, ThuTu = 1},
                new CtTour { MaCtTour = 9, MaTour = 3, MaDd = 6, ThuTu = 2}
                );

            modelBuilder.Entity<Doan>().HasData(
                new Doan { MaDoan = 1, MaTour = 1, TenDoan = "Đoàn 1", NgayBd = DateTime.Now.Date, NgayKt = DateTime.Now.AddDays(4).Date, NoiDung = "Nội dung 1" },
                new Doan { MaDoan = 2, MaTour = 1, TenDoan = "Đoàn 2", NgayBd = DateTime.Now.Date, NgayKt = DateTime.Now.AddDays(4).Date, NoiDung = "Nội dung 2"  },
                new Doan { MaDoan = 3, MaTour = 1, TenDoan = "Đoàn 3", NgayBd = DateTime.Now.Date, NgayKt = DateTime.Now.AddDays(4).Date, NoiDung = "Nội dung 3"  },

                new Doan { MaDoan = 4, MaTour = 2, TenDoan = "Đoàn 4", NgayBd = DateTime.Now.Date, NgayKt = DateTime.Now.AddDays(5).Date, NoiDung = "Nội dung 4"  },
                new Doan { MaDoan = 5, MaTour = 2, TenDoan = "Đoàn 5", NgayBd = DateTime.Now.Date, NgayKt = DateTime.Now.AddDays(5).Date, NoiDung = "Nội dung 5"  },
                new Doan { MaDoan = 6, MaTour = 2, TenDoan = "Đoàn 6", NgayBd = DateTime.Now.Date, NgayKt = DateTime.Now.AddDays(5).Date, NoiDung = "Nội dung 6"  },

                new Doan { MaDoan = 7, MaTour = 3, TenDoan = "Đoàn 7", NgayBd = DateTime.Now.Date, NgayKt = DateTime.Now.AddDays(3).Date, NoiDung = "Nội dung 7"  },
                new Doan { MaDoan = 8, MaTour = 3, TenDoan = "Đoàn 8", NgayBd = DateTime.Now.Date, NgayKt = DateTime.Now.AddDays(3).Date, NoiDung = "Nội dung 8"  }
                );

            modelBuilder.Entity<Khach>().HasData(
                new Khach { MaKhach = 1, Ten = "Nguyễn Văn Tèo", Sdt = "0123456789", Cmnd = "121234567", GioiTinh = "Nữ", DiaChi = "Long An", QuocTich = "Vietnam" },
                new Khach { MaKhach = 2, Ten = "Văn Tèo", Sdt = "0123456788", Cmnd = "121234566", GioiTinh = "Nam", DiaChi = "Kiên Giang", QuocTich = "Vietnam" },
                new Khach { MaKhach = 3, Ten = "Nguyễn Văn", Sdt = "0123456787", Cmnd = "121234565", GioiTinh = "Nữ", DiaChi = "Mỹ Tho", QuocTich = "Vietnam" },
                new Khach { MaKhach = 4, Ten = "Nguyễn Tèo", Sdt = "0123456786", Cmnd = "121234564", GioiTinh = "Nam", DiaChi = "Củ Chi", QuocTich = "Vietnam" },
                new Khach { MaKhach = 5, Ten = "Nguyễn Tèo Văn", Sdt = "0123456785", Cmnd = "121234563", GioiTinh = "Nữ", DiaChi = "Bến Tre", QuocTich = "Vietnam" },
                new Khach { MaKhach = 6, Ten = "Trần Thị Cúc", Sdt = "0123456784", Cmnd = "121234562", GioiTinh = "Nữ", DiaChi = "Long An", QuocTich = "Vietnam" },
                new Khach { MaKhach = 7, Ten = "Thị Cúc", Sdt = "0123456783", Cmnd = "121234561", GioiTinh = "Nam", DiaChi = "Kiên Giang", QuocTich = "Vietnam" },
                new Khach { MaKhach = 8, Ten = "Trần Cúc", Sdt = "0123456782", Cmnd = "121234560", GioiTinh = "Nữ", DiaChi = "Bến Tre", QuocTich = "Vietnam" },
                new Khach { MaKhach = 9, Ten = "Trần Thị", Sdt = "0123456781", Cmnd = "121234559", GioiTinh = "Nam", DiaChi = "Củ Chi", QuocTich = "Vietnam" },
                new Khach { MaKhach = 10, Ten = "Trần Cúc Thị", Sdt = "0123456780", Cmnd = "121234558", GioiTinh = "Nữ", DiaChi = "Mỹ Tho", QuocTich = "Vietnam" }
                );

            modelBuilder.Entity<CtDoan>().HasData(
                new CtDoan { MaCtDoan = 1, MaDoan = 1, MaKhach = 1 },
                new CtDoan { MaCtDoan = 2, MaDoan = 1, MaKhach = 2 },
                new CtDoan { MaCtDoan = 3, MaDoan = 1, MaKhach = 3 },
                new CtDoan { MaCtDoan = 4, MaDoan = 1, MaKhach = 4 },

                new CtDoan { MaCtDoan = 5, MaDoan = 2, MaKhach = 3 },
                new CtDoan { MaCtDoan = 6, MaDoan = 2, MaKhach = 4 },
                new CtDoan { MaCtDoan = 7, MaDoan = 2, MaKhach = 5 },
                new CtDoan { MaCtDoan = 8, MaDoan = 2, MaKhach = 6 },

                new CtDoan { MaCtDoan = 9, MaDoan = 3, MaKhach = 7 },
                new CtDoan { MaCtDoan = 10, MaDoan = 3, MaKhach = 8 }
                );

            modelBuilder.Entity<NhanVien>().HasData(
                new NhanVien { MaNv = 1, TenNv = "Lê Văn Tèo", GioiTinh = "Nam", Sdt = "0198765432" },
                new NhanVien { MaNv = 2, TenNv = "Lê Tèo Văn", GioiTinh = "Nữ", Sdt = "0198765433" },
                new NhanVien { MaNv = 3, TenNv = "Văn Lê Tèo", GioiTinh = "Nam", Sdt = "0198765434" },
                new NhanVien { MaNv = 4, TenNv = "Tèo Lê Văn", GioiTinh = "Nữ", Sdt = "0198765435" },
                new NhanVien { MaNv = 5, TenNv = "Trần Văn A", GioiTinh = "Nam", Sdt = "0198765436" },
                new NhanVien { MaNv = 6, TenNv = "A Trần Văn", GioiTinh = "Nữ", Sdt = "0198765437" },
                new NhanVien { MaNv = 7, TenNv = "Trần A Văn", GioiTinh = "Nam", Sdt = "0198765438" }
                );

            modelBuilder.Entity<PhanCong>().HasData(
                new PhanCong { MaPhanCong = 1, MaDoan = 1, MaNv = 1, NhiemVu = "Lái xe" },
                new PhanCong { MaPhanCong = 2, MaDoan = 1, MaNv = 2, NhiemVu = "Hướng dẫn viên" },
                new PhanCong { MaPhanCong = 3, MaDoan = 1, MaNv = 3, NhiemVu = "Thông dịch viên" },
                new PhanCong { MaPhanCong = 4, MaDoan = 1, MaNv = 4, NhiemVu = "Phục vụ" },

                new PhanCong { MaPhanCong = 5, MaDoan = 2, MaNv = 5, NhiemVu = "Lái xe" },
                new PhanCong { MaPhanCong = 6, MaDoan = 2, MaNv = 6, NhiemVu = "Hướng dẫn viên" },

                new PhanCong { MaPhanCong = 7, MaDoan = 3, MaNv = 3, NhiemVu = "Lái xe" },
                new PhanCong { MaPhanCong = 8, MaDoan = 3, MaNv = 4, NhiemVu = "Phục vụ" }
                );

            modelBuilder.Entity<LoaiCp>().HasData(
                new LoaiCp { MaLoaiCp = 1, TenLoaiCp = "Chi phí ăn uống"},
                new LoaiCp { MaLoaiCp = 2, TenLoaiCp = "Chi phí phương tiện"},
                new LoaiCp { MaLoaiCp = 3, TenLoaiCp = "Chi phí khác"}
                );

            modelBuilder.Entity<ChiPhi>().HasData(
                new ChiPhi { MaCp = 1, MaDoan = 1, MaLoaiCp = 1, GiaTien = 1000000 },
                new ChiPhi { MaCp = 2, MaDoan = 1, MaLoaiCp = 2, GiaTien = 1000000 },
                new ChiPhi { MaCp = 3, MaDoan = 1, MaLoaiCp = 3, GiaTien = 1000000 },

                new ChiPhi { MaCp = 4, MaDoan = 2, MaLoaiCp = 1, GiaTien = 700000 },
                new ChiPhi { MaCp = 5, MaDoan = 2, MaLoaiCp = 2, GiaTien = 500000 },
                new ChiPhi { MaCp = 6, MaDoan = 2, MaLoaiCp = 3, GiaTien = 1000000 },

                new ChiPhi { MaCp = 7, MaDoan = 3, MaLoaiCp = 1, GiaTien = 1200000 },
                new ChiPhi { MaCp = 8, MaDoan = 3, MaLoaiCp = 2, GiaTien = 700000 },
                new ChiPhi { MaCp = 9, MaDoan = 3, MaLoaiCp = 3, GiaTien = 50000 }
                );
        }
    } 
}

