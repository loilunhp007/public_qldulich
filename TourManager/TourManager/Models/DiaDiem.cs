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
    public class DiaDiem
    {
        public DiaDiem() { }

        [Key]
        public int MaDd { get; set; }

        public string TenDd { get; set; }

        public List<CtTour> CtTours { get; set; }


        public static List<DiaDiem> GetAll()
        {
            return DiaDiemDAL.GetAll();
        }

        public static DiaDiem Insert(DiaDiem obj)
        {
            return DiaDiemDAL.Insert(obj);
        }

        public int Update()
        {
            return DiaDiemDAL.Update(this);
        }

        public int Delete()
        {
            return DiaDiemDAL.Delete(this);
        }
    }
}
