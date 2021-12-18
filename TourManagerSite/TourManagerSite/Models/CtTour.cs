using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManager.DAL;

namespace TourManager.Models
{
    public class CtTour
    {
        public CtTour() { }

        [Key]
        public int MaCtTour { get; set; }

        public int ThuTu { get; set; }

        public int MaTour { get; set; }
        [ForeignKey("MaTour")]
        public Tour Tour { get; set; }


        public int MaDd { get; set; }
        [ForeignKey("MaDd")]
        public DiaDiem DiaDiem { get; set; }
        //[NotMapped]
        //public string TenDdCt { get {return DiaDiem.TenDd;} }        


        public static List<CtTour> GetAll()
        {
            return CtTourDAL.GetAll();
        }

        public static CtTour GetById(int id)
        {
            return CtTourDAL.GetById(id);
        }

        public static List<CtTour> GetByTourId(int id)
        {
            return CtTourDAL.GetByTourId(id);
        }

        public static CtTour Insert(CtTour obj)
        {
            return CtTourDAL.Insert(obj);
        }

        public int Update()
        {
            return CtTourDAL.Update(this);
        }

        public int Delete()
        {
            return CtTourDAL.Delete(this);
        }
    }
}
