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
    public class NhanVien
    {
        public NhanVien() { }

        [Key]
        public int MaNv { get; set; }

        public string TenNv { get; set; }

        public string GioiTinh { get; set; }

        public string Sdt { get; set; }

        [NotMapped]
        public int SoTour { get; set; }

        public List<PhanCong> PhanCongs { get; set; }


        public static List<NhanVien> GetAll()
        {
            return NhanVienDAL.GetAll();
        }

        public static List<NhanVien> Search(string search)
        {
            return NhanVienDAL.Search(search);
        }

        public static NhanVien Insert(NhanVien obj)
        {
            return NhanVienDAL.Insert(obj);
        }

        public int Update()
        {
            return NhanVienDAL.Update(this);
        }

        public int Delete()
        {
            return NhanVienDAL.Delete(this);
        }

        //public static List<NhanVien> ThongKe()
        //{
        //    List<NhanVien> nvTK = new List<NhanVien>();

        //    List<NhanVien> tmpNvs = NhanVienDAL.GetAll();

        //    foreach (NhanVien nv in tmpNvs)
        //    {
        //        int MaNv = nv.MaNv;
        //        List<PhanCong> p = PhanCongDAL.GetByNvId(MaNv);
        //        nv.SoTour = p.Count(p => p.MaNv == MaNv);

        //        nvTK.Add(nv);
        //    }

        //    return nvTK;
        //}

        public static List<NhanVien> ThongKe(DateTime tgbd, DateTime tgkt)
        {
            List<NhanVien> nvTK = new List<NhanVien>();

            List<NhanVien> tmpNvs = NhanVienDAL.GetAll();

            List<Doan> doantheongay = DoanDAL.GetAllTk(tgbd.Date, tgkt.Date);

            List<PhanCong> pctheongay = new List<PhanCong>();

            foreach(Doan doan in doantheongay)
            {
                int MaDoan = doan.MaDoan;
                List<PhanCong> pc = PhanCongDAL.GetByDoanId(MaDoan);
                pctheongay.AddRange(pc);
            }           

            foreach (NhanVien nv in tmpNvs)
            {
                int MaNv = nv.MaNv;
                nv.SoTour = pctheongay.Count(pctheongay => pctheongay.MaNv == MaNv);

                nvTK.Add(nv);
            }

            return nvTK;
        }

        //public static List<NhanVien> ThongKeById(int id)
        //{
        //    List<NhanVien> nvTK = new List<NhanVien>();

        //    List<NhanVien> tmpNvs = NhanVienDAL.GetById(id);

        //    foreach (NhanVien nv in tmpNvs)
        //    {
        //        int MaNv = nv.MaNv;
        //        List<PhanCong> p = PhanCongDAL.GetByNvId(MaNv);
        //        nv.SoTour = p.Count(p => p.MaNv == MaNv);

        //        nvTK.Add(nv);
        //    }

        //    return nvTK;
        //}

        public static List<NhanVien> ThongKeById(int id, DateTime tgbd, DateTime tgkt)
        {
            List<NhanVien> nvTK = new List<NhanVien>();

            List<NhanVien> tmpNvs = NhanVienDAL.GetById(id);

            List<Doan> doantheongay = DoanDAL.GetAllTk(tgbd.Date, tgkt.Date);

            List<PhanCong> pctheongay = new List<PhanCong>();

            foreach(Doan doan in doantheongay)
            {
                int MaDoan = doan.MaDoan;
                List<PhanCong> pc = PhanCongDAL.GetByDoanId(MaDoan);
                pctheongay.AddRange(pc);
            }           

            foreach (NhanVien nv in tmpNvs)
            {
                int MaNv = nv.MaNv;
                nv.SoTour = pctheongay.Count(pctheongay => pctheongay.MaNv == MaNv);

                nvTK.Add(nv);
            }

            return nvTK;
        }
    }
}
