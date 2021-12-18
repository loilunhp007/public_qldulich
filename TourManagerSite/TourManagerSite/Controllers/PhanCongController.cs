using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourManager.Models;

namespace TourManagerSite.Controllers
{
    public class PhanCongController : Controller
    {
        public IActionResult Index()
        {
            return View(PhanCong.GetAll());
        }

        public IActionResult Create()
        {    
            ViewBag.LayDoan = Doan.GetAll();
            ViewBag.LayNv = NhanVien.GetAll();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PhanCong pc)
        { 
            PhanCong.Insert(pc);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {            
            ViewBag.LayDoan = Doan.GetAll();
            ViewBag.LayNv = NhanVien.GetAll();           

            var pc = PhanCong.GetById(id);

            if(pc == null)
            {
                return NotFound();
            }

            return View(pc);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PhanCong pc)
        {
            pc.Update();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            ViewBag.LayDoan = Doan.GetAll();
            ViewBag.LayNv = NhanVien.GetAll();  

            var pc = PhanCong.GetById(id);

            if(pc == null)
            {
                return NotFound();
            }

            return View(pc);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, bool notUsed)
        {
            var pc = PhanCong.GetById(id);

            if(pc == null)
            {
                return NotFound();
            }

            pc.Delete();
            return RedirectToAction("Index");
        }
    }
}
