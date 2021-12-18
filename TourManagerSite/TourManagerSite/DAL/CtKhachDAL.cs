using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManager.Models;

namespace TourManager.DAL
{
    public static class CtKhachDAL
    {
        //static Context context = new Context();

        public static List<CtDoan> GetAll()
        {
            using (var context = new Context())
            {
                return context.Set<CtDoan>()
                    .Include("Doan")
                    .Include("Khach")
                    .ToList();
            }            
        }

        public static List<CtDoan> GetByDoanId(int id)
        {
            using (var context = new Context())
            {
                return context.Set<CtDoan>()
                    .Where(ct => ct.MaDoan.Equals(id))
                    .Include("Doan")
                    .Include("Khach")
                    .ToList();
            }            
        }

        public static CtDoan GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<CtDoan>()
                    .Find(id);
            }            
        }

        public static CtDoan Insert(CtDoan obj)
        {
            using (var context = new Context())
            {
                context.Set<CtDoan>().Add(obj);
                context.SaveChanges();
                return obj;
            }               
        }

        public static int Update(CtDoan obj)
        {
            using (var context = new Context())
            {
                context.Set<CtDoan>().Attach(obj);
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();
            }               
        }

        public static int Delete(CtDoan obj)
        {
            using (var context = new Context())
            {
                context.Set<CtDoan>().Attach(obj);
                context.Set<CtDoan>().Remove(obj);
                return context.SaveChanges();
            }               
        }
    }
}
