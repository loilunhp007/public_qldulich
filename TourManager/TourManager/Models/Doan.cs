using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManager.DAL;

namespace TourManager.Models
{
    public class Doan
    {
        public Doan() { }

        [Key]
        public int MaDoan { get; set; }

        public string TenDoan { get; set; }

        public DateTime NgayBd { get; set; }

        public DateTime NgayKt { get; set; }

        public string NoiDung { get; set; }

        public int MaTour { get; set; }
        [ForeignKey("MaTour")]
        public Tour Tour { get; set; }

        [NotMapped]
        public string LayTenTour { get { return Tour.TenTour; } }

        [NotMapped]
        public int SoKhach { get; set; }

        [NotMapped]
        public int SoNv { get; set; }

        [NotMapped]
        public decimal DoanhSo { get; set; }

        public List<CtDoan> CtDoans { get; set; }
        public List<PhanCong> PhanCongs { get; set; }
        public List<ChiPhi> ChiPhis { get; set; }

        public static List<Doan> GetAll()
        {
            return DoanDAL.GetAll();
        }

        public static List<Doan> GetByTourId(int id)
        {
            return DoanDAL.GetByTourId(id);
        }

        public static List<Doan> Search(string search)
        {
            return DoanDAL.Search(search);
        }

        public static Doan Insert(Doan obj)
        {
            return DoanDAL.Insert(obj);
        }

        public int Update()
        {
            return DoanDAL.Update(this);
        }

        public int Delete()
        {
            return DoanDAL.Delete(this);
        }

        public static List<Doan> ThongKe(DateTime ngaybd, DateTime ngaykt)
        {
            List<Doan> doanTK = new List<Doan>();

            List<Doan> tmpDoans = DoanDAL.GetAllTk(ngaybd, ngaykt);

            foreach (Doan doan in tmpDoans)
            {
                int MaDoan = doan.MaDoan;
                List<CtDoan> k = CtKhachDAL.GetByDoanId(MaDoan);
                List<ChiPhi> c = ChiPhiDAL.GetByDoanId(MaDoan);
                List<PhanCong> p = PhanCongDAL.GetByDoanId(MaDoan);
                doan.SoKhach = k.Count();
                doan.SoNv = p.Count();
                doan.DoanhSo = c.Sum(b => b.GiaTien);

                doanTK.Add(doan);
            }

            return doanTK;
        }

        public static List<Doan> ThongKeByTourId(int id, DateTime ngaybd, DateTime ngaykt)
        {
            List<Doan> doanTK = new List<Doan>();

            List<Doan> tmpDoans = DoanDAL.GetAllTkByTourId(id, ngaybd, ngaykt);

            foreach (Doan doan in tmpDoans)
            {
                int MaDoan = doan.MaDoan;
                List<CtDoan> k = CtKhachDAL.GetByDoanId(MaDoan);
                List<ChiPhi> c = ChiPhiDAL.GetByDoanId(MaDoan);
                List<PhanCong> p = PhanCongDAL.GetByDoanId(MaDoan);
                doan.SoKhach = k.Count();
                doan.SoNv = p.Count();
                doan.DoanhSo = c.Sum(b => b.GiaTien);

                doanTK.Add(doan);
            }

            return doanTK;
        }

        public static List<Doan> ThongKeByDoanId(int id, DateTime ngaybd, DateTime ngaykt)
        {
            List<Doan> doanTK = new List<Doan>();

            List<Doan> tmpDoans = DoanDAL.GetAllTkByDoanId(id, ngaybd, ngaykt);

            foreach (Doan doan in tmpDoans)
            {
                int MaDoan = doan.MaDoan;
                List<CtDoan> k = CtKhachDAL.GetByDoanId(MaDoan);
                List<ChiPhi> c = ChiPhiDAL.GetByDoanId(MaDoan);
                List<PhanCong> p = PhanCongDAL.GetByDoanId(MaDoan);
                doan.SoKhach = k.Count();
                doan.SoNv = p.Count();
                doan.DoanhSo = c.Sum(b => b.GiaTien);

                doanTK.Add(doan);
            }

            return doanTK;
        }

        public static List<Doan> ThongKeBy2Id(int tour, int doan, DateTime ngaybd, DateTime ngaykt)
        {
            List<Doan> doanTK = new List<Doan>();

            List<Doan> tmpDoans = DoanDAL.GetAllTkBy2Id(tour, doan, ngaybd, ngaykt);

            foreach (Doan d in tmpDoans)
            {
                int MaDoan = d.MaDoan;
                List<CtDoan> k = CtKhachDAL.GetByDoanId(MaDoan);
                List<ChiPhi> c = ChiPhiDAL.GetByDoanId(MaDoan);
                List<PhanCong> p = PhanCongDAL.GetByDoanId(MaDoan);
                d.SoKhach = k.Count();
                d.SoNv = p.Count();
                d.DoanhSo = c.Sum(b => b.GiaTien);

                doanTK.Add(d);
            }

            return doanTK;
        }
    }
}
