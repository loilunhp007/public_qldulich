using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManager.Models;

namespace TourManager.DAL
{
    public class TourDAL
    {
        static Context context = new Context();

        public static List<Tour> GetAll()
        {
             return context.Set<Tour>()
                .Include("LoaiTour")
                .ToList();
        }

        public static int Update(Tour obj)
        {
            context.Set<Tour>().Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
            return context.SaveChanges();
        }
    }
}
