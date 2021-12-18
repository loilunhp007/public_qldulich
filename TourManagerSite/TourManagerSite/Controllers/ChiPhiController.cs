using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourManager.Models;

namespace TourManagerSite.Controllers
{
    public class ChiPhiController : Controller
    {
        public IActionResult Index()
        {
            return View(ChiPhi.GetAll());
        }

        public IActionResult Create()
        {    
            ViewBag.LayDoan = Doan.GetAll();
            ViewBag.LayLoaiCp = LoaiCp.GetAll();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ChiPhi cp)
        { 
            ChiPhi.Insert(cp);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {            
            ViewBag.LayDoan = Doan.GetAll();
            ViewBag.LayLoaiCp = LoaiCp.GetAll();          

            var cp = ChiPhi.GetById(id);

            if(cp == null)
            {
                return NotFound();
            }

            return View(cp);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ChiPhi cp)
        {
            cp.Update();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            ViewBag.LayDoan = Doan.GetAll();
            ViewBag.LayLoaiCp = LoaiCp.GetAll();  

            var cp = ChiPhi.GetById(id);

            if(cp == null)
            {
                return NotFound();
            }

            return View(cp);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, bool notUsed)
        {
            var cp = ChiPhi.GetById(id);

            if(cp == null)
            {
                return NotFound();
            }

            cp.Delete();
            return RedirectToAction("Index");
        }
    }
}
