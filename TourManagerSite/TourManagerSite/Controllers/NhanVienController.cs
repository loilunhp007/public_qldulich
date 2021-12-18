using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourManager.Models;

namespace TourManagerSite.Controllers
{
    public class NhanVienController : Controller
    {
        public IActionResult Index()
        {
            return View(NhanVien.ThongKeNv());
        }

        public IActionResult Create()
        {    
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NhanVien nv)
        { 
            NhanVien.Insert(nv);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {            
            var nv = NhanVien.GetById(id);

            if(nv == null)
            {
                return NotFound();
            }

            return View(nv);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(NhanVien nv)
        {
            nv.Update();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var nv = NhanVien.GetById(id);

            if(nv == null)
            {
                return NotFound();
            }

            return View(nv);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, bool notUsed)
        {
            var nv = NhanVien.GetById(id);

            if(nv == null)
            {
                return NotFound();
            }

            nv.Delete();
            return RedirectToAction("Index");
        }
    }
}
