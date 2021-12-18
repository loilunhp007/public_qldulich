using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourManager.Models;

namespace TourManagerSite.Controllers
{
    public class KhachController : Controller
    {
        public IActionResult Index()
        {
            return View(Khach.GetAll());
        }

        public IActionResult Create()
        {    
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Khach k)
        { 
            Khach.Insert(k);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {            
            var k = Khach.GetById(id);

            if(k == null)
            {
                return NotFound();
            }

            return View(k);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Khach k)
        {
            k.Update();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var k = Khach.GetById(id);

            if(k == null)
            {
                return NotFound();
            }

            return View(k);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, bool notUsed)
        {
            var k = Khach.GetById(id);

            if(k == null)
            {
                return NotFound();
            }

            k.Delete();
            return RedirectToAction("Index");
        }
    }
}
