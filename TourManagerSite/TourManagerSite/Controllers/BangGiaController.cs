using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourManager.Models;

namespace TourManagerSite.Controllers
{
    public class BangGiaController : Controller
    {
        public IActionResult Index()
        {
            return View(BangGia.GetAll());
        }

        public IActionResult Create()
        {    
            ViewBag.LayTour = Tour.GetAll();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BangGia bangGia)
        { 
            BangGia.Insert(bangGia);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {            
            ViewBag.LayTour = Tour.GetAll();            

            var bangGia = BangGia.GetById(id);

            if(bangGia == null)
            {
                return NotFound();
            }

            return View(bangGia);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BangGia bangGia)
        {
            bangGia.Update();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            ViewBag.LayTour = Tour.GetAll();

            var bangGia = BangGia.GetById(id);

            if(bangGia == null)
            {
                return NotFound();
            }

            return View(bangGia);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, bool notUsed)
        {
            var bangGia = BangGia.GetById(id);

            if(bangGia == null)
            {
                return NotFound();
            }

            bangGia.Delete();
            return RedirectToAction("Index");
        }
    }
}
