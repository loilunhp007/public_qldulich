using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManager.Models;

namespace TourManager.DAL
{
    public static class PhanCongDAL
    {
        //static Context context = new Context();

        public static List<PhanCong> GetAll()
        {
            using (var context = new Context())
            {
                return context.Set<PhanCong>()
                    .Include("Doan")
                    .Include("NhanVien")
                    .ToList();
            }             
        }

        public static List<PhanCong> GetByDoanId(int id)
        {
            using (var context = new Context())
            {
                return context.Set<PhanCong>()
                    .Where(pc => pc.MaDoan.Equals(id))
                    .Include("Doan")
                    .Include("NhanVien")
                    .ToList();
            }             
        }

        public static PhanCong GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<PhanCong>()
                    .Find(id);
            }             
        }

        public static List<PhanCong> GetByNvId(int id)
        {
            using (var context = new Context())
            {
                return context.Set<PhanCong>()
                    .Where(pc => pc.MaNv.Equals(id))
                    .Include("Doan")
                    .Include("NhanVien")
                    .ToList();
            }            
        }

        public static PhanCong Insert(PhanCong obj)
        {
            using (var context = new Context())
            {
                context.Set<PhanCong>().Add(obj);
                context.SaveChanges();
                return obj;
            }              
        }

        public static int Update(PhanCong obj)
        {
            using (var context = new Context())
            {
                context.Set<PhanCong>().Attach(obj);
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();
            }             
        }

        public static int Delete(PhanCong obj)
        {
            using (var context = new Context())
            {
                context.Set<PhanCong>().Attach(obj);
                context.Set<PhanCong>().Remove(obj);
                return context.SaveChanges();
            }              
        }
    }
}
