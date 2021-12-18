using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManager.Models;

namespace TourManager.DAL
{
    public static class CtTourDAL
    {
        //static Context context = new Context();

        public static List<CtTour> GetAll()
        {
            using (var context = new Context())
            {
                return context.Set<CtTour>()
                    .OrderBy(ct => ct.ThuTu)
                    .Include("Tour")
                    .Include("DiaDiem")
                    .ToList();
            }            
        }

        public static List<CtTour> GetByTourId(int id)
        {
            using (var context = new Context())
            {
                return context.Set<CtTour>()
                    .Where(ct => ct.MaTour.Equals(id))
                    .OrderBy(ct => ct.ThuTu)
                    .Include("Tour")
                    .Include("DiaDiem")
                    .ToList();
            }            
        }

        public static CtTour GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<CtTour>()
                    .Find(id);
            }            
        }

        public static CtTour Insert(CtTour obj)
        {
            using (var context = new Context())
            {
                context.Set<CtTour>().Add(obj);
                context.SaveChanges();
                return obj;
            }            
        }

        public static int Update(CtTour obj)
        {
            using (var context = new Context())
            {
                context.Set<CtTour>().Attach(obj);
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();
            }               
        }

        public static int Delete(CtTour obj)
        {
            using (var context = new Context())
            {
                context.Set<CtTour>().Attach(obj);
                context.Set<CtTour>().Remove(obj);
                return context.SaveChanges();
            }           
        }
    }
}
