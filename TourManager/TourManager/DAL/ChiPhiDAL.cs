using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManager.Models;

namespace TourManager.DAL
{
    public static class ChiPhiDAL
    {
        static Context context = new Context();

        public static List<ChiPhi> GetAll()
        {

                return context.Set<ChiPhi>()
                    .Include("Doan")
                    .Include("LoaiCp")
                    .ToList();
            
        }

        public static List<ChiPhi> GetByDoanId(int id)
        {

                return context.Set<ChiPhi>()
                    .Where(cp => cp.MaDoan.Equals(id))
                    .Include("Doan")
                    .Include("LoaiCp")
                    .ToList();
             
        }

        public static List<ChiPhi> GetByLoaiId(int id)
        {

                return context.Set<ChiPhi>()
                    .Where(cp => cp.MaLoaiCp.Equals(id))
                    .Include("Doan")
                    .Include("LoaiCp")
                    .ToList();
            
        }

        public static List<ChiPhi> GetBy2Id(int doan, int loaicp)
        {

                return context.Set<ChiPhi>()
                    .Where(cp => cp.MaDoan == doan && cp.MaLoaiCp == loaicp)
                    .Include("Doan")
                    .Include("LoaiCp")
                    .ToList();
              
        }

        public static ChiPhi Insert(ChiPhi obj)
        {

                context.Set<ChiPhi>().Add(obj);
                context.SaveChanges();
                return obj;
           
        }

        public static int Update(ChiPhi obj)
        {

                context.Set<ChiPhi>().Attach(obj);
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();
            
        }

        public static int Delete(ChiPhi obj)
        {

                context.Set<ChiPhi>().Attach(obj);
                context.Set<ChiPhi>().Remove(obj);
                return context.SaveChanges();
          
        }
    }
}
