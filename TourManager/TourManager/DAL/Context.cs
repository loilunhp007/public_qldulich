using Microsoft.EntityFrameworkCore;
using TourManager.Models;

namespace TourManager.DAL
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<LoaiTour> LoaiTours { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<BangGia> BangGias { get; set; }
        public DbSet<CtTour> CtTours { get; set; }
        public DbSet<DiaDiem> DiaDiems { get; set; }
        public DbSet<Doan> Doans { get; set; }
        public DbSet<Khach> Khachs { get; set; }
        public DbSet<CtDoan> CtDoans { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhanCong> PhanCongs { get; set; }
        public DbSet<LoaiCp> LoaiCps { get; set; }
        public DbSet<ChiPhi> ChiPhis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////LoaiTour - Tour
            //modelBuilder.Entity<LoaiTour>()
            //    .HasMany(lt => lt.Tours)
            //    .WithOne(t => t.LoaiTour).HasForeignKey(t => t.MaLoai);

            ////Tour - BangGia
            //modelBuilder.Entity<Tour>()
            //    .HasMany(t => t.BangGias)
            //    .WithOne(g => g.Tour).HasForeignKey(g => g.MaTour);

            ////Tour - CtTour
            // modelBuilder.Entity<Tour>()
            //    .HasMany(t => t.CtTours)
            //    .WithOne(ct => ct.Tour).HasForeignKey(ct => ct.MaTour);

            ////DiaDiem - CtTour
            // modelBuilder.Entity<DiaDiem>()
            //    .HasMany(dd => dd.CtTours)
            //    .WithOne(ct => ct.DiaDiem).HasForeignKey(ct => ct.MaDd);

            ////Tour - Doan
            // modelBuilder.Entity<Tour>()
            //    .HasMany(t => t.Doans)
            //    .WithOne(d => d.Tour).HasForeignKey(d => d.MaTour);

            ////Doan - CtDoan
            //modelBuilder.Entity<Doan>()
            //    .HasMany(d => d.CtDoans)
            //    .WithOne(ct => ct.Doan).HasForeignKey(ct => ct.MaDoan);

            ////Khach - CtDoan
            //modelBuilder.Entity<Khach>()
            //    .HasMany(k => k.CtDoans)
            //    .WithOne(ct => ct.Khach).HasForeignKey(ct => ct.MaKhach);

            ////Doan - PhanCong
            //modelBuilder.Entity<Doan>()
            //    .HasMany(d => d.PhanCongs)
            //    .WithOne(pc => pc.Doan).HasForeignKey(pc => pc.MaDoan);

            ////NhanVien - PhanCong
            //modelBuilder.Entity<NhanVien>()
            //    .HasMany(nv => nv.PhanCongs)
            //    .WithOne(pc => pc.NhanVien).HasForeignKey(pc => pc.MaNv);

            ////Doan - ChiPhi
            //modelBuilder.Entity<Doan>()
            //    .HasMany(d => d.ChiPhis)
            //    .WithOne(cp => cp.Doan).HasForeignKey(cp => cp.MaDoan);

            ////LoaiCp - ChiPhi
            //modelBuilder.Entity<LoaiCp>()
            //    .HasMany(l => l.ChiPhis)
            //    .WithOne(cp => cp.LoaiCp).HasForeignKey(cp => cp.MaLoaiCp);

            //Add Seed data from ModelBuilderExtentions
            modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-2G7FG5TV;Database=TourData;Trusted_Connection=True");
        }
    }
}
