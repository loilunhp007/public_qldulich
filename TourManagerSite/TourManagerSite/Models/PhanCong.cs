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
    public class PhanCong
    {
        public PhanCong() { }

        [Key]
        public int MaPhanCong { get; set; }

        public string NhiemVu { get; set; }

        public int MaDoan { get; set; }
        [ForeignKey("MaDoan")]
        public Doan Doan { get; set; }

        public int MaNv { get; set; }
        [ForeignKey("MaNv")]
        public NhanVien NhanVien { get; set; }

        //[NotMapped]
        //public string TenNvPc { get {return NhanVien.TenNv;} }


        public static List<PhanCong> GetAll()
        {
            return PhanCongDAL.GetAll();
        }

        public static List<PhanCong> GetByDoanId(int id)
        {
            return PhanCongDAL.GetByDoanId(id);
        }

        public static PhanCong GetById(int id)
        {
            return PhanCongDAL.GetById(id);
        }

        public static PhanCong Insert(PhanCong obj)
        {
            return PhanCongDAL.Insert(obj);
        }

        public int Update()
        {
            return PhanCongDAL.Update(this);
        }

        public int Delete()
        {
            return PhanCongDAL.Delete(this);
        }
    }
}
