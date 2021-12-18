using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManager.DAL;

namespace TourManager.Models
{
    public class Khach
    {
        public Khach() { }

        [Key]
        public int MaKhach { get; set; }

        public string Ten { get; set; }

        public string Sdt { get; set; }

        public string Cmnd { get; set; }

        public string GioiTinh { get; set; }

        public string DiaChi { get; set; }

        public string QuocTich { get; set; }

        public List<CtDoan> CtDoans { get; set; }


        public static List<Khach> GetAll()
        {
            return KhachDAL.GetAll();
        }

        public static Khach GetById(int id)
        {
            return KhachDAL.GetById(id);
        }

        public static List<Khach> Search(string search)
        {
            return KhachDAL.Search(search);
        }

        public static Khach Insert(Khach obj)
        {
            return KhachDAL.Insert(obj);
        }

        public int Update()
        {
            return KhachDAL.Update(this);
        }

        public int Delete()
        {
            return KhachDAL.Delete(this);
        }
    }
}
