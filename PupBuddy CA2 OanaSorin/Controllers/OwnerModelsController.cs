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
    public class OwnerModelsController : Controller
    {
        private PuppyContext db = new PuppyContext();

        // GET: OwnerModels
        public ActionResult Index()
        {
            return View(db.PuppyOwner.ToList());
        }

        // GET: OwnerModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnerModel ownerModel = db.PuppyOwner.Find(id);
            if (ownerModel == null)
            {
                return HttpNotFound();
            }
            return View(ownerModel);
        }

        // GET: OwnerModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OwnerModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OwnerID,OwnerName,OwnerPhoneNumber")] OwnerModel ownerModel)
        {
            if (ModelState.IsValid)
            {
                db.PuppyOwner.Add(ownerModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ownerModel);
        }

        // GET: OwnerModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnerModel ownerModel = db.PuppyOwner.Find(id);
            if (ownerModel == null)
            {
                return HttpNotFound();
            }
            return View(ownerModel);
        }

        // POST: OwnerModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OwnerID,OwnerName,OwnerPhoneNumber")] OwnerModel ownerModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ownerModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ownerModel);
        }

        // GET: OwnerModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnerModel ownerModel = db.PuppyOwner.Find(id);
            if (ownerModel == null)
            {
                return HttpNotFound();
            }
            return View(ownerModel);
        }

        // POST: OwnerModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OwnerModel ownerModel = db.PuppyOwner.Find(id);
            db.PuppyOwner.Remove(ownerModel);
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
