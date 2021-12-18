using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManager.Models;

namespace TourManager.DAL
{
    public class NhanVienDAL
    {
        static Context context = new Context();

        public static List<NhanVien> GetAll()
        {

                return context.Set<NhanVien>()
                    .ToList();
             
        }

        public static List<NhanVien> GetById(int id)
        {

                return context.Set<NhanVien>()
                    .Where(nv => nv.MaNv == id)
                    .ToList();
           
        }

        public static List<NhanVien> Search(string search)
        {

                return context.Set<NhanVien>()
                .Where(nv =>  
                    nv.TenNv.Contains(search) ||
                    nv.GioiTinh.Contains(search) ||
                    nv.Sdt.Contains(search))
                .ToList();
                         
        }

        public static NhanVien Insert(NhanVien obj)
        {

                context.Set<NhanVien>().Add(obj);
                context.SaveChanges();
                return obj;
                       
        }

        public static int Update(NhanVien obj)
        {

                context.Set<NhanVien>().Attach(obj);
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();
                         
        }

        public static int Delete(NhanVien obj)
        {

                context.Set<NhanVien>().Attach(obj);
                context.Set<NhanVien>().Remove(obj);
                return context.SaveChanges();
                          
        }
    }
}
