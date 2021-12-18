using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourManager.DAL;
using TourManager.Models;

namespace TourManagerSite.Controllers
{
    public class TourController : Controller
    {
        public IActionResult Index()
        {            
            return View(Tour.ThongKe());
        }

        public IActionResult Create()
        {    
            ViewBag.LayLoaiTour = LoaiTour.GetAll();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tour tour)
        { 
            Tour.Insert(tour);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {            
            ViewBag.LayLoaiTour = LoaiTour.GetAll();

            //if(id == null || id == 0)
            //{
            //    return NotFound();
            //}

            var tour = Tour.GetById(id);

            if(tour == null)
            {
                return NotFound();
            }

            return View(tour);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Tour tour)
        {
            tour.Update();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            ViewBag.LayLoaiTour = LoaiTour.GetAll();

            var tour = Tour.GetById(id);

            if(tour == null)
            {
                return NotFound();
            }

            return View(tour);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, bool notUsed)
        {
            var tour = Tour.GetById(id);

            if(tour == null)
            {
                return NotFound();
            }

            tour.Delete();
            return RedirectToAction("Index");
        }
    }
}
