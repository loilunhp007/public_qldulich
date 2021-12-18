using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManager.Models;

namespace TourManager.DAL
{
    public class KhachDAL
    {
        //static Context context = new Context();

        public static List<Khach> GetAll()
        {
            using (var context = new Context())
            {
                return context.Set<Khach>()
                    .ToList();
            }             
        }

        public static Khach GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<Khach>()
                    .Find(id);
            }             
        }

        public static List<Khach> Search(string search)
        {
            using (var context = new Context())
            {
                return context.Set<Khach>()
                .Where(k =>
                    k.Ten.Contains(search) ||
                    k.Cmnd.Contains(search) ||
                    k.GioiTinh.Contains(search) ||
                    k.DiaChi.Contains(search) ||
                    k.QuocTich.Contains(search) ||
                    k.Sdt.Contains(search))
                .ToList();
            }               
        }

        public static Khach Insert(Khach obj)
        {
            using (var context = new Context())
            {
                context.Set<Khach>().Add(obj);
                context.SaveChanges();
                return obj;
            }              
        }

        public static int Update(Khach obj)
        {
            using (var context = new Context())
            {
                context.Set<Khach>().Attach(obj);
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();
            }            
        }

        public static int Delete(Khach obj)
        {
            using (var context = new Context())
            {
                context.Set<Khach>().Attach(obj);
                context.Set<Khach>().Remove(obj);
                return context.SaveChanges();
            }             
        }
    }
}
