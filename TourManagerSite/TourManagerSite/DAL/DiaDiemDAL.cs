using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManager.Models;

namespace TourManager.DAL
{
    public class DiaDiemDAL
    {
        //static Context context = new Context();

        public static List<DiaDiem> GetAll()
        {
            using (var context = new Context())
            {
                return context.Set<DiaDiem>()
                    .ToList();
            }               
        }

        public static DiaDiem GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<DiaDiem>()
                    .Find(id);
            }               
        }

        public static DiaDiem Insert(DiaDiem obj)
        {
            using (var context = new Context())
            {
                context.Set<DiaDiem>().Add(obj);
                context.SaveChanges();
                return obj;
            }               
        }

        public static int Update(DiaDiem obj)
        {
            using (var context = new Context())
            {
                context.Set<DiaDiem>().Attach(obj);
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();
            }              
        }

        public static int Delete(DiaDiem obj)
        {
            using (var context = new Context())
            {
                context.Set<DiaDiem>().Attach(obj);
                context.Set<DiaDiem>().Remove(obj);
                return context.SaveChanges();
            }              
        }
    }
}
