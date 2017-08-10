using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RPG.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RPG.Controllers
{
    public class KeyController : Controller
    {
        private RPGDbContext db = new RPGDbContext();
        public IActionResult Index()
        {
            return View(db.Keys.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisKey = db.Keys.FirstOrDefault(key => key.KeyId == id);

            return View(thisKey); 
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Key key)
        {
            db.Keys.Add(key);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            var thisLoc = db.Keys.FirstOrDefault(key => key.KeyId == id);
            return View(thisLoc);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisLoc = db.Keys.FirstOrDefault(key => key.KeyId == id);
            db.Keys.Remove(thisLoc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisLoc = db.Keys.FirstOrDefault(key => key.KeyId == id);
            return View(thisLoc);
        }

        [HttpPost]
        public IActionResult Edit(Key key)
        {
            db.Entry(key).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
