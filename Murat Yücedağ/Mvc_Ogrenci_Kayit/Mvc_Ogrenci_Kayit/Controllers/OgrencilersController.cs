using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mvc_Ogrenci_Kayit.Models;

namespace Mvc_Ogrenci_Kayit.Controllers
{
    public class OgrencilersController : Controller
    {
        private Database1Entities db = new Database1Entities();

        // GET: Ogrencilers
        public ActionResult Index()
        {
            return View(db.Ogrenciler.ToList());
        }

        // GET: Ogrencilers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenciler ogrenciler = db.Ogrenciler.Find(id);
            if (ogrenciler == null)
            {
                return HttpNotFound();
            }
            return View(ogrenciler);
        }

        // GET: Ogrencilers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ogrencilers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ad,Soyad,Mail,Fotograf,Adres")] Ogrenciler ogrenciler)
        {
            if (ModelState.IsValid)
            {
                db.Ogrenciler.Add(ogrenciler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ogrenciler);
        }

        // GET: Ogrencilers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenciler ogrenciler = db.Ogrenciler.Find(id);
            if (ogrenciler == null)
            {
                return HttpNotFound();
            }
            return View(ogrenciler);
        }

        // POST: Ogrencilers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ad,Soyad,Mail,Fotograf,Adres")] Ogrenciler ogrenciler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ogrenciler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ogrenciler);
        }

        // GET: Ogrencilers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenciler ogrenciler = db.Ogrenciler.Find(id);
            if (ogrenciler == null)
            {
                return HttpNotFound();
            }
            return View(ogrenciler);
        }

        // POST: Ogrencilers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ogrenciler ogrenciler = db.Ogrenciler.Find(id);
            db.Ogrenciler.Remove(ogrenciler);
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
