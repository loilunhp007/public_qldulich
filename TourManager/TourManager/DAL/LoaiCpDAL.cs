using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManager.Models;

namespace TourManager.DAL
{
    public class LoaiCpDAL
    {
        static Context context = new Context();

        public static List<LoaiCp> GetAll()
        {

                return context.Set<LoaiCp>()
                .ToList();

        }             

        public static LoaiCp Insert(LoaiCp obj)
        {

                context.Set<LoaiCp>().Add(obj);
                context.SaveChanges();
                return obj;
           
        }

        public static int Update(LoaiCp obj)
        {

                context.Set<LoaiCp>().Attach(obj);
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();
           
        }

        public static int Delete(LoaiCp obj)
        {

                context.Set<LoaiCp>().Attach(obj);
                context.Set<LoaiCp>().Remove(obj);
                return context.SaveChanges();
        
        }
    }
}
