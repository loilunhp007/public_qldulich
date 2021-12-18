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
        //static Context context = new Context();

        public static List<Tour> GetAll()
        {
            using (var context = new Context())
            {
                return context.Set<Tour>()
                    .Include("LoaiTour")
                    .ToList();
            }             
        }

        public static List<Tour> GetTourById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<Tour>()
                    .Where(tour => tour.MaTour == id)
                    .ToList();
            }              
        }

        public static Tour GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<Tour>()
                    .Find(id);
            }              
        }

        public static List<Tour> Search(string search)
        {
            using (var context = new Context())
            {
                return context.Set<Tour>()
                .Where(tour =>                 
                    tour.TenTour.Contains(search) || 
                    tour.LoaiTour.TenLoai.Contains(search) || 
                    tour.DacDiem.Contains(search))
                .ToList();
            }              
        }

        public static Tour Insert(Tour obj)
        {
            using (var context = new Context())
            {
                context.Set<Tour>().Add(obj);
                context.SaveChanges();
                return obj;
            }              
        }

        public static int Update(Tour obj)
        {
            using (var context = new Context())
            {
                context.Set<Tour>().Attach(obj);
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();
            }              
        }

        public static int Delete(Tour obj)
        {
            using (var context = new Context())
            {
                context.Set<Tour>().Attach(obj);
                context.Set<Tour>().Remove(obj);
                return context.SaveChanges();
            }              
        }               
    }
}
