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
    public class BangGia
    {
        public BangGia() { }

        [Key]
        public int MaGia { get; set; }


        [Column(TypeName = "decimal(18,0)")]
        public decimal GiaTour { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        [DataType(DataType.Date)]
        public DateTime Tgbd { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        [DataType(DataType.Date)]
        public DateTime Tgkt { get; set; }


        public int MaTour { get; set; }
        [ForeignKey("MaTour")]
        public Tour Tour { get; set; }


        public static List<BangGia> GetByTourId(int id)
        {
            return BangGiaDAL.GetByTourId(id);
        }

        public static BangGia Insert(BangGia obj)
        {
            return BangGiaDAL.Insert(obj);
        }

        public int Update()
        {
            return BangGiaDAL.Update(this);
        }

        public int Delete()
        {
            return BangGiaDAL.Delete(this);
        }
    }
}
