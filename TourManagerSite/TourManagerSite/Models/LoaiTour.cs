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
    public class LoaiTour
    {
        public LoaiTour() { }

        [Key]
        public int MaLoai { get; set; }

        public string  TenLoai { get; set; }

        public List<Tour> Tours { get; set; }

        public static List<LoaiTour> GetAll()
        {
            return LoaiTourDAL.GetAll();
        }

        public static LoaiTour GetById(int id)
        {
            return LoaiTourDAL.GetById(id);
        }

        public static LoaiTour Insert(LoaiTour obj)
        {
            return LoaiTourDAL.Insert(obj);
        }

        public int Update()
        {
            return LoaiTourDAL.Update(this);
        }

        public int Delete()
        {
            return LoaiTourDAL.Delete(this);
        }
    }
}
