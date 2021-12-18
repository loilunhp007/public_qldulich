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
    public class Tour
    {
        public Tour() {}

        [Key]
        public int MaTour { get; set; }

        public string TenTour { get; set; }

        public string DacDiem { get; set; }

        public int MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public LoaiTour LoaiTour { get; set; }

        [NotMapped]
        public string TenLoaiTour { get { return LoaiTour.TenLoai; } }

        [NotMapped]
        public int SoDoan { get; set; }

        [NotMapped]
        public int SoKhach { get; set; }

        [NotMapped]
        public int SoNv { get; set; }

        [NotMapped]
        public decimal Gia { get; set; }

        [NotMapped]
        public decimal TongCp { get; set; }

        public List<BangGia> BangGias { get; set; }
        public List<CtTour> CtTours { get; set; }
        public List<Doan> Doans { get; set; }

        public static List<Tour> GetAll()
        {
            return TourDAL.GetAll();
        }

        public static List<Tour> Search(string search)
        {
            return TourDAL.Search(search);
        }

        public static Tour Insert(Tour obj)
        {
            return TourDAL.Insert(obj);
        }

        public int Update()
        {
            return TourDAL.Update(this);
        }

        public int Delete()
        {
            return TourDAL.Delete(this);
        }

        public static List<Tour> ThongKe()
        {
            List<Tour> tourTK = new List<Tour>();

            List<Tour> tmpTours = TourDAL.GetAll();

            foreach (Tour tour in tmpTours)
            {
                int MaTour = tour.MaTour;
                List<Doan> d = DoanDAL.GetAll();
                List<BangGia> b = BangGiaDAL.GetByTourId(MaTour);
                tour.SoDoan = d.Count(t => t.MaTour == MaTour);
                tour.Gia = b.Select(b => b.GiaTour).FirstOrDefault();

                List<Doan> doanbytour = DoanDAL.GetByTourId(MaTour);
                List<ChiPhi> cpbydoan = new List<ChiPhi>();
                List<CtDoan> ctbydoan = new List<CtDoan>();
                List<PhanCong> pcbydoan = new List<PhanCong>();
                foreach (Doan doan in doanbytour)
                {
                    int MaDoan = doan.MaDoan;
                    List<ChiPhi> cp = ChiPhiDAL.GetByDoanId(MaDoan);
                    List<CtDoan> ct = CtKhachDAL.GetByDoanId(MaDoan);
                    List<PhanCong> pc = PhanCongDAL.GetByDoanId(MaDoan);
                    cpbydoan.AddRange(cp);
                    ctbydoan.AddRange(ct);
                    pcbydoan.AddRange(pc);
                }

                tour.TongCp = cpbydoan.Sum(cpbd => cpbd.GiaTien); 
                tour.SoKhach = ctbydoan.Count();
                tour.SoNv = pcbydoan.Count();

                tourTK.Add(tour);
            }

            return tourTK;
        }

        public static List<Tour> ThongKeById(int id)
        {
            List<Tour> tourTK = new List<Tour>();

            List<Tour> tmpTours = TourDAL.GetTourById(id);

            foreach (Tour tour in tmpTours)
            {
                int MaTour = tour.MaTour;
                List<Doan> d = DoanDAL.GetAll();
                List<BangGia> b = BangGiaDAL.GetByTourId(MaTour);
                tour.SoDoan = d.Count(t => t.MaTour == MaTour);
                tour.Gia = b.Select(b => b.GiaTour).FirstOrDefault();

                List<Doan> doanbytour = DoanDAL.GetByTourId(MaTour);
                List<ChiPhi> cpbydoan = new List<ChiPhi>();
                List<CtDoan> ctbydoan = new List<CtDoan>();
                List<PhanCong> pcbydoan = new List<PhanCong>();
                foreach (Doan doan in doanbytour)
                {
                    int MaDoan = doan.MaDoan;
                    List<ChiPhi> cp = ChiPhiDAL.GetByDoanId(MaDoan);
                    List<CtDoan> ct = CtKhachDAL.GetByDoanId(MaDoan);
                    List<PhanCong> pc = PhanCongDAL.GetByDoanId(MaDoan);
                    cpbydoan.AddRange(cp);
                    ctbydoan.AddRange(ct);
                    pcbydoan.AddRange(pc);
                }

                tour.TongCp = cpbydoan.Sum(cpbd => cpbd.GiaTien); 
                tour.SoKhach = ctbydoan.Count();
                tour.SoNv = pcbydoan.Count();

                tourTK.Add(tour);
            }

            return tourTK;
        }
    }
}
