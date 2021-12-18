using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourManager.Models;

namespace TourManagerSite.Controllers
{
    public class CtTourController : Controller
    {
        public IActionResult Index()
        {
            return View(CtTour.GetAll());
        }

        public IActionResult Create()
        {    
            ViewBag.LayTour = Tour.GetAll();
            ViewBag.LayDiaDiem = DiaDiem.GetAll();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CtTour ct)
        { 
            CtTour.Insert(ct);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {            
            ViewBag.LayTour = Tour.GetAll();   
            ViewBag.LayDiaDiem = DiaDiem.GetAll();
            
            var ct = CtTour.GetById(id);

            if(ct == null)
            {
                return NotFound();
            }

            return View(ct);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CtTour ct)
        {
            ct.Update();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            ViewBag.LayTour = Tour.GetAll();
            ViewBag.LayDiaDiem = DiaDiem.GetAll();

            var ct = CtTour.GetById(id);

            if(ct == null)
            {
                return NotFound();
            }

            return View(ct);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, bool notUsed)
        {
            var ct = CtTour.GetById(id);

            if(ct == null)
            {
                return NotFound();
            }

            ct.Delete();
            return RedirectToAction("Index");
        }
    }
}
