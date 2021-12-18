using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourManager.Models;

namespace TourManagerSite.Controllers
{
    public class CtKhachController : Controller
    {
        public IActionResult Index()
        {
            return View(CtDoan.GetAll());
        }

        public IActionResult Create()
        {    
            ViewBag.LayDoan = Doan.GetAll();
            ViewBag.LayKhach = Khach.GetAll();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CtDoan ct)
        { 
            CtDoan.Insert(ct);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {            
            ViewBag.LayDoan = Doan.GetAll();
            ViewBag.LayKhach = Khach.GetAll();           

            var ct = CtDoan.GetById(id);

            if(ct == null)
            {
                return NotFound();
            }

            return View(ct);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CtDoan ct)
        {
            ct.Update();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            ViewBag.LayDoan = Doan.GetAll();
            ViewBag.LayKhach = Khach.GetAll(); 

            var ct = CtDoan.GetById(id);

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
            var ct = CtDoan.GetById(id);

            if(ct == null)
            {
                return NotFound();
            }

            ct.Delete();
            return RedirectToAction("Index");
        }
    }
}
