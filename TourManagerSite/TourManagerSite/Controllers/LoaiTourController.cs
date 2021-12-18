using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourManager.Models;

namespace TourManagerSite.Controllers
{
    public class LoaiTourController : Controller
    {
        public IActionResult Index()
        {
            return View(LoaiTour.GetAll());
        }

        public IActionResult Create()
        {    
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LoaiTour loai)
        { 
            LoaiTour.Insert(loai);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {            
            var loai = LoaiTour.GetById(id);

            if(loai == null)
            {
                return NotFound();
            }

            return View(loai);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(LoaiTour loai)
        {
            loai.Update();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var loai = LoaiTour.GetById(id);

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
            var loai = LoaiTour.GetById(id);

            if(loai == null)
            {
                return NotFound();
            }

            loai.Delete();
            return RedirectToAction("Index");
        }
    }
}
