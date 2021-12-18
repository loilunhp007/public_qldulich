using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourManager.Models;

namespace TourManagerSite.Controllers
{
    public class LoaiCpController : Controller
    {
        public IActionResult Index()
        {
            return View(LoaiCp.GetAll());
        }

        public IActionResult Create()
        {    
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LoaiCp loai)
        { 
            LoaiCp.Insert(loai);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {            
            var loai = LoaiCp.GetById(id);

            if(loai == null)
            {
                return NotFound();
            }

            return View(loai);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(LoaiCp loai)
        {
            loai.Update();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var loai = LoaiCp.GetById(id);

            if(loai == null)
            {
                return NotFound();
            }

            return View(loai);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, bool notUsed)
        {
            var loai = LoaiCp.GetById(id);

            if(loai == null)
            {
                return NotFound();
            }

            loai.Delete();
            return RedirectToAction("Index");
        }
    }
}
