using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManager.Models;

namespace TourManager.DAL
{
    public class LoaiTourDAL
    {
        //static Context context = new Context();

        public static List<LoaiTour> GetAll()
        {
            using (var context = new Context())
            {
                return context.Set<LoaiTour>()
                    .ToList();
            }             
        }

        public static LoaiTour GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<LoaiTour>()
                    .Find(id);
            }             
        }

        public static LoaiTour Insert(LoaiTour obj)
        {
            using (var context = new Context())
            {
                context.Set<LoaiTour>().Add(obj);
                context.SaveChanges();
                return obj;
            }             
        }

        public static int Update(LoaiTour obj)
        {
            using (var context = new Context())
            {
                context.Set<LoaiTour>().Attach(obj);
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();
            }             
        }

        public static int Delete(LoaiTour obj)
        {
            using (var context = new Context())
            {
                context.Set<LoaiTour>().Attach(obj);
                context.Set<LoaiTour>().Remove(obj);
                return context.SaveChanges();
            }               
        }
    }
}
