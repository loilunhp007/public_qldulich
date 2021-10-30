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

        public string TenLoaiTour 
            { 
                get { return LoaiTour.TenLoai; }
            }
            
        public static List<Tour> GetAll()
        {
            return TourDAL.GetAll();
        }

        public int UpdateToDB()
        {
            return TourDAL.Update(this);
        }
    }
}
