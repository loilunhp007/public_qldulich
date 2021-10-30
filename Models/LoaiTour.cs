using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManager.Models
{
    public class LoaiTour
    {
        public LoaiTour() { }

        [Key]
        public int MaLoai { get; set; }

        public string  TenLoai { get; set; }

        public List<Tour> Tours { get; set; }
    }
}
