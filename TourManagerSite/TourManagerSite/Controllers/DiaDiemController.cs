using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourManager.Models;

namespace TourManagerSite.Controllers
{
    public class DiaDiemController : Controller
    {
        public IActionResult Index()
        {
            return View(DiaDiem.GetAll());
        }

        public IActionResult Create()
        {    
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DiaDiem dd)
        { 
            DiaDiem.Insert(dd);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {            
            var dd = DiaDiem.GetById(id);

            if(dd == null)
            {
                return NotFound();
            }

            return View(dd);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(DiaDiem dd)
        {
            dd.Update();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var dd = DiaDiem.GetById(id);

            if(dd == null)
            {
                return NotFound();
            }

            return View(dd);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, bool notUsed)
        {
            var dd = DiaDiem.GetById(id);

            if(dd == null)
            {
                return NotFound();
            }

            dd.Delete();
            return RedirectToAction("Index");
        }
    }
}
