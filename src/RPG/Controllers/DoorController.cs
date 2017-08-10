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
    public class DoorController : Controller
    {
        private RPGDbContext db = new RPGDbContext();
        public IActionResult Index()
        {
            return View(db.Doors.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisDoor = db.Doors.FirstOrDefault(door => door.DoorId == id);

            return View(thisDoor);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Door door)
        {
            db.Doors.Add(door);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            var thisLoc = db.Doors.FirstOrDefault(door => door.DoorId == id);
            return View(thisLoc);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisLoc = db.Doors.FirstOrDefault(door => door.DoorId == id);
            db.Doors.Remove(thisLoc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisLoc = db.Doors.FirstOrDefault(door => door.DoorId == id);
            return View(thisLoc);
        }

        [HttpPost]
        public IActionResult Edit(Door door)
        {
            db.Entry(door).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
