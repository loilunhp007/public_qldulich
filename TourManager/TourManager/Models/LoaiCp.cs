using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManager.DAL;

namespace TourManager.Models
{
    public class LoaiCp
    {
        public LoaiCp() { }

        [Key]
        public int MaLoaiCp { get; set; }

        public string TenLoaiCp { get; set; }

        public List<ChiPhi> ChiPhis { get; set; }


        public static List<LoaiCp> GetAll()
        {
            return LoaiCpDAL.GetAll();
        }

        public static LoaiCp Insert(LoaiCp obj)
        {
            return LoaiCpDAL.Insert(obj);
        }

        public int Update()
        {
            return LoaiCpDAL.Update(this);
        }

        public int Delete()
        {
            return LoaiCpDAL.Delete(this);
        }
    }
}
