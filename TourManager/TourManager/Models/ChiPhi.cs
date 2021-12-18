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
    public class ChiPhi
    {
        public ChiPhi() { }

        [Key]
        public int MaCp { get; set; }


        [Column(TypeName = "decimal(18,0)")]
        public decimal GiaTien { get; set; }


        public int MaLoaiCp { get; set; }
        [ForeignKey("MaLoaiCp")]
        public LoaiCp LoaiCp { get; set; }
        [NotMapped]
        public string LayTenLoaiCp { get { return LoaiCp.TenLoaiCp; } }


        public int MaDoan { get; set; }
        [ForeignKey("MaDoan")]
        public Doan Doan { get; set; }     
        [NotMapped]
        public string LayTenDoan { get { return Doan.TenDoan; } }


        public static List<ChiPhi> GetAll()
        {
            return ChiPhiDAL.GetAll();
        }

        public static List<ChiPhi> GetByDoanId(int id)
        {
            return ChiPhiDAL.GetByDoanId(id);
        }

        public static ChiPhi Insert(ChiPhi obj)
        {
            return ChiPhiDAL.Insert(obj);
        }

        public int Update()
        {
            return ChiPhiDAL.Update(this);
        }

        public int Delete()
        {
            return ChiPhiDAL.Delete(this);
        }

        public static List<ChiPhi> ThongKeByTour(int id)
        {
            List<ChiPhi> cpTK = new List<ChiPhi>();

            List<Doan> doanbytour = DoanDAL.GetByTourId(id);
            List<ChiPhi> cpbydoan = new List<ChiPhi>();
            foreach (Doan doan in doanbytour)
            {
                int MaDoan = doan.MaDoan;
                List<ChiPhi> cp = ChiPhiDAL.GetByDoanId(MaDoan);
                cpbydoan.AddRange(cp);
            }

            cpTK.AddRange(cpbydoan);

            return cpTK;        
        }

        public static List<ChiPhi> ThongKeByDoan(int id)
        {
            return ChiPhiDAL.GetByDoanId(id);           
        }

        public static List<ChiPhi> ThongKeByLoaiCp(int id)
        {
            return ChiPhiDAL.GetByLoaiId(id);          
        }

        public static List<ChiPhi> ThongKeByDoanLoai(int doan, int loaicp)
        {
            return ChiPhiDAL.GetBy2Id(doan, loaicp);  
        }

        public static List<ChiPhi> ThongKeByTourLoai(int tour, int loaicp)
        {
            List<ChiPhi> cpTK = new List<ChiPhi>();

            List<Doan> doanbytour = DoanDAL.GetByTourId(tour);
            List<ChiPhi> cpbyloai = new List<ChiPhi>();
            foreach (Doan doan in doanbytour)
            {
                int MaDoan = doan.MaDoan;
                List<ChiPhi> cp = ChiPhiDAL.GetBy2Id(MaDoan, loaicp);
                cpbyloai.AddRange(cp);
            }

            cpTK.AddRange(cpbyloai);

            return cpTK;  
        }

        public static List<ChiPhi> ThongKeByTourDoan(int tour, int doan)
        {
            List<ChiPhi> cpTK = new List<ChiPhi>();

            List<Doan> doanbytour = DoanDAL.GetByTourId(tour);
            List<ChiPhi> cpbyloai = new List<ChiPhi>();
            foreach (Doan d in doanbytour)
            {
                int MaDoan = d.MaDoan;
                if(MaDoan == doan)
                {
                    List<ChiPhi> cp = ChiPhiDAL.GetByDoanId(MaDoan);
                    cpbyloai.AddRange(cp);
                }                
            }

            cpTK.AddRange(cpbyloai);

            return cpTK;   
        }

        public static List<ChiPhi> ThongKeBy3Id(int tour, int doan, int loaicp)
        {
            List<ChiPhi> cpTK = new List<ChiPhi>();

            List<Doan> doanbytour = DoanDAL.GetByTourId(tour);
            List<ChiPhi> cpbyloai = new List<ChiPhi>();
            foreach (Doan d in doanbytour)
            {
                int MaDoan = d.MaDoan;
                if(MaDoan == doan)
                {
                    List<ChiPhi> cp = ChiPhiDAL.GetBy2Id(MaDoan, loaicp);
                    cpbyloai.AddRange(cp);
                }                
            }

            cpTK.AddRange(cpbyloai);

            return cpTK;  
        }
    }
}
