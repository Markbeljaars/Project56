using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MemoryController : Controller
    {
        private MainDBContext db = new MainDBContext();

        // GET: Memory
        public ActionResult Index()
        {
            return View(db.Memory.ToList());
        }

        // GET: Memory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Memory memory = db.Memory.Find(id);
            if (memory == null)
            {
                return HttpNotFound();
            }
            return View(memory);
        }

        // GET: Memory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Memory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,name,speed,type,cas,modules,size,price")] Memory memory)
        {
            if (ModelState.IsValid)
            {
                db.Memory.Add(memory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(memory);
        }

        // GET: Memory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Memory memory = db.Memory.Find(id);
            if (memory == null)
            {
                return HttpNotFound();
            }
            return View(memory);
        }

        // POST: Memory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,name,speed,type,cas,modules,size,price")] Memory memory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(memory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(memory);
        }

        // GET: Memory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Memory memory = db.Memory.Find(id);
            if (memory == null)
            {
                return HttpNotFound();
            }
            return View(memory);
        }

        // POST: Memory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Memory memory = db.Memory.Find(id);
            db.Memory.Remove(memory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
