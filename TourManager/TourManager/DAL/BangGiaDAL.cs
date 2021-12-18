using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManager.Models;

namespace TourManager.DAL
{
    public class BangGiaDAL
    {
        static Context context = new Context();

        public static List<BangGia> GetByTourId(int TourId)
        {

                return context.Set<BangGia>()
                    .Include("Tour")
                    .Where(gia => gia.MaTour.Equals(TourId))
                    .OrderByDescending(gia => gia.Tgkt)
                    .ToList();
          
        }

        public static BangGia Insert(BangGia obj)
        {

                context.Set<BangGia>().Add(obj);
                context.SaveChanges();
                return obj;
        
        }

        public static int Update(BangGia obj)
        {

                context.Set<BangGia>().Attach(obj);
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();
              
        }

        public static int Delete(BangGia obj)
        {

                context.Set<BangGia>().Attach(obj);
                context.Set<BangGia>().Remove(obj);
                return context.SaveChanges();
                     
        }
    }
}
