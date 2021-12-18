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
        //static Context context = new Context();

        public static List<LoaiCp> GetAll()
        {
            using (var context = new Context())
            {
                return context.Set<LoaiCp>()
                .ToList();
            }
        }    
        
        public static LoaiCp GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<LoaiCp>()
                .Find(id);
            }
        }  

        public static LoaiCp Insert(LoaiCp obj)
        {
            using (var context = new Context())
            {
                context.Set<LoaiCp>().Add(obj);
                context.SaveChanges();
                return obj;
            }            
        }

        public static int Update(LoaiCp obj)
        {
            using (var context = new Context())
            {
                context.Set<LoaiCp>().Attach(obj);
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();
            }             
        }

        public static int Delete(LoaiCp obj)
        {
            using (var context = new Context())
            {
                context.Set<LoaiCp>().Attach(obj);
                context.Set<LoaiCp>().Remove(obj);
                return context.SaveChanges();
            }            
        }
    }
}
