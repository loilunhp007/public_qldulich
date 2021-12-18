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
        static Context context = new Context();

        public static List<CtTour> GetByTourId(int TourId)
        {

                return context.Set<CtTour>()
                    .Where(ct => ct.MaTour.Equals(TourId))
                    .OrderBy(ct => ct.ThuTu)
                    .Include("Tour")
                    .Include("DiaDiem")
                    .ToList();

        }

        public static CtTour Insert(CtTour obj)
        {

                context.Set<CtTour>().Add(obj);
                context.SaveChanges();
                return obj;

        }

        public static int Update(CtTour obj)
        {

                context.Set<CtTour>().Attach(obj);
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();

        }

        public static int Delete(CtTour obj)
        {

                context.Set<CtTour>().Attach(obj);
                context.Set<CtTour>().Remove(obj);
                return context.SaveChanges();

        }
    }
}
