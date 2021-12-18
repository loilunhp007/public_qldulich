using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourManager.Models;

namespace TourManagerSite.Controllers
{
    public class DoanController : Controller
    {
        public IActionResult Index()
        {
            //return View(Doan.GetAll());
            return View(Doan.ThongKeDoan());
        }

        public IActionResult Create()
        {    
            ViewBag.LayTour = Tour.GetAll();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Doan doan)
        { 
            Doan.Insert(doan);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {            
            ViewBag.LayTour = Tour.GetAll();   
            
            var doan = Doan.GetById(id);

            if(doan == null)
            {
                return NotFound();
            }

            return View(doan);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Doan doan)
        {
            doan.Update();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            ViewBag.LayTour = Tour.GetAll();

            var doan = Doan.GetById(id);

            if(doan == null)
            {
                return NotFound();
            }

            return View(doan);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, bool notUsed)
        {
            var doan = Doan.GetById(id);

            if(doan == null)
            {
                return NotFound();
            }

            doan.Delete();
            return RedirectToAction("Index");
        }
    }
}
