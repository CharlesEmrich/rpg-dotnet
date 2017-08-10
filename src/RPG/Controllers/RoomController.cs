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
    public class RoomController : Controller
    {
        private RPGDbContext db = new RPGDbContext();
        public IActionResult Index()
        {
            return View(db.Rooms.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisRoom = db.Rooms.FirstOrDefault(room => room.RoomId == id);

            return View(thisRoom); 
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Room room)
        {
            db.Rooms.Add(room);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            var thisLoc = db.Rooms.FirstOrDefault(room => room.RoomId == id);
            return View(thisLoc);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisLoc = db.Rooms.FirstOrDefault(room => room.RoomId == id);
            db.Rooms.Remove(thisLoc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisLoc = db.Rooms.FirstOrDefault(room => room.RoomId == id);
            return View(thisLoc);
        }

        [HttpPost]
        public IActionResult Edit(Room room)
        {
            db.Entry(room).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
