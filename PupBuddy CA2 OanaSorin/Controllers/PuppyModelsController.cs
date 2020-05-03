using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PupBuddy_CA2_OanaSorin.DAL;
using PupBuddy_CA2_OanaSorin.Models;

namespace PupBuddy_CA2_OanaSorin.Controllers
{
    public class PuppyModelsController : Controller
    {
        private PuppyContext db = new PuppyContext();

        // GET: PuppyModels
        public ActionResult Index()
        {
            return View(db.Puppy.ToList());
        }

        // GET: PuppyModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PuppyModel puppyModel = db.Puppy.Find(id);
            if (puppyModel == null)
            {
                return HttpNotFound();
            }
            return View(puppyModel);
        }

        // GET: PuppyModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PuppyModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PuppyID,OwnerID,Breed,PupName,PupSize,PupDateOfBirth")] PuppyModel puppyModel)
        {
            if (ModelState.IsValid)
            {
                db.Puppy.Add(puppyModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(puppyModel);
        }

        // GET: PuppyModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PuppyModel puppyModel = db.Puppy.Find(id);
            if (puppyModel == null)
            {
                return HttpNotFound();
            }
            return View(puppyModel);
        }

        // POST: PuppyModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PuppyID,OwnerID,Breed,PupName,PupSize,PupDateOfBirth")] PuppyModel puppyModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(puppyModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(puppyModel);
        }

        // GET: PuppyModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PuppyModel puppyModel = db.Puppy.Find(id);
            if (puppyModel == null)
            {
                return HttpNotFound();
            }
            return View(puppyModel);
        }

        // POST: PuppyModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PuppyModel puppyModel = db.Puppy.Find(id);
            db.Puppy.Remove(puppyModel);
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
