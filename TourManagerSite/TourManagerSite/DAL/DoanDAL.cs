using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManager.Models;

namespace TourManager.DAL
{
    public class DoanDAL
    {
        //static Context context = new Context();

        public static List<Doan> GetAll()
        {
            using (var context = new Context())
            {
                return context.Set<Doan>()
                    .Include("Tour")
                    .ToList();
            }             
        }

        public static List<Doan> GetByTourId(int id)
        {
            using (var context = new Context())
            {
                return context.Set<Doan>()
                    .Where(d => d.MaTour.Equals(id))
                    .Include("Tour")                
                    .ToList();
            }               
        }

        public static Doan GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<Doan>()
                    .Find(id);
            }               
        }

        public static List<Doan> GetAllTk(DateTime ngaybd, DateTime ngaykt)
        {
            using (var context = new Context())
            {
                return context.Set<Doan>()
                    .Where(doan => doan.NgayBd.Date >= ngaybd.Date
                        && doan.NgayKt.Date <= ngaykt.Date)
                    .Include("Tour")                
                    .ToList();
            }
        }

        public static List<Doan> GetAllTkByTourId(int id, DateTime ngaybd, DateTime ngaykt)
        {
            using (var context = new Context())
            {
                return context.Set<Doan>()
                    .Where(doan => doan.NgayBd.Date >= ngaybd.Date
                        && doan.NgayKt.Date <= ngaykt.Date 
                        && doan.MaTour == id)
                    .Include("Tour")                
                    .ToList();
            }
        }

        public static List<Doan> GetAllTkByDoanId(int id, DateTime ngaybd, DateTime ngaykt)
        {
            using (var context = new Context())
            {
                return context.Set<Doan>()
                    .Where(doan => doan.NgayBd.Date >= ngaybd.Date
                        && doan.NgayKt.Date <= ngaykt.Date 
                        && doan.MaDoan == id)
                    .Include("Tour")                
                    .ToList();
            }
        }

        public static List<Doan> GetAllTkBy2Id(int tour, int doan, DateTime ngaybd, DateTime ngaykt)
        {
            using (var context = new Context())
            {
                return context.Set<Doan>()
                    .Where(d => d.NgayBd.Date >= ngaybd.Date
                        && d.NgayKt.Date <= ngaykt.Date 
                        && d.MaTour == tour
                        && d.MaDoan == doan)
                    .Include("Tour")                
                    .ToList();
            }
        }

        public static List<Doan> Search(string search)
        {
            using (var context = new Context())
            {
                return context.Set<Doan>()
                    .Where(doan =>                 
                        doan.TenDoan.Contains(search) || 
                        doan.Tour.TenTour.Contains(search) || 
                        doan.NoiDung.Contains(search))
                    .Include("Tour")                
                    .ToList();
            }
        }

        public static Doan Insert(Doan obj)
        {
            using (var context = new Context())
            {
                context.Set<Doan>().Add(obj);
                context.SaveChanges();
                return obj;
            }            
        }

        public static int Update(Doan obj)
        {
            using (var context = new Context())
            {
                context.Set<Doan>().Attach(obj);
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();
            }             
        }

        public static int Delete(Doan obj)
        {
            using (var context = new Context())
            {
                context.Set<Doan>().Attach(obj);
                context.Set<Doan>().Remove(obj);
                return context.SaveChanges();
            }             
        }
    }
}
