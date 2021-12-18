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
    public class CtDoan
    {
        public CtDoan() { }

        [Key]
        public int MaCtDoan { get; set; }

        public int MaDoan { get; set; }
        [ForeignKey("MaDoan")]
        public Doan Doan { get; set; }


        public int MaKhach { get; set; }
        [ForeignKey("MaKhach")]
        public Khach Khach { get; set; }

        [NotMapped]
        public string TenKhach { get {return Khach.Ten; } }

        [NotMapped]
        public string CmndKhach { get {return Khach.Cmnd; } }


        public static List<CtDoan> GetByDoanId(int id)
        {
            return CtKhachDAL.GetByDoanId(id);
        }

        public static CtDoan Insert(CtDoan obj)
        {
            return CtKhachDAL.Insert(obj);
        }

        public int Update()
        {
            return CtKhachDAL.Update(this);
        }

        public int Delete()
        {
            return CtKhachDAL.Delete(this);
        }
    }
}
