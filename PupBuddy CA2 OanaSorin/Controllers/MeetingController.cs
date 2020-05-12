using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PupBuddy_CA2_OanaSorin.DAL;
using PupBuddy_CA2_OanaSorin.Models;

namespace PupBuddy_CA2_OanaSorin.Controllers
{
    public class MeetingController : Controller
    {
        private PuppyContext db = new PuppyContext();

       /* public ActionResult GetPuppies()
        {
            string puppies = @"select PupName from PupBuddyDB.dbo.PuppyModel";
            Console.WriteLine(puppies);
            return View(db.Meetings.ToList());
        }*/

        // GET: Meeting
        public ActionResult Index()
        {

           
            return View(db.Meetings.ToList());
        }

        // GET: Meeting/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeetingModel meetingModel = db.Meetings.Find(long.Parse(id));
            if (meetingModel == null)
            {
                return HttpNotFound();
            }
            return View(meetingModel);
        }

        // GET: Meeting/Create
        [HttpGet]
        public ActionResult Create()
        {
            /*SqlConnection sqlCon = new SqlConnection(db.ToString());*//*
            private PuppyContext dbc = new PuppyContext();

        string puppies = @"select PupName from PupBuddyDB.dbo.PuppyModel";
            Console.WriteLine(puppies);

            SqlDataAdapter adaptor = new SqlDataAdapter(puppies, dbc);

            if (ModelState.IsValid)
            {
                string pup = @"select PupName from PupBuddyDB.dbo.PuppyModel";
                Console.WriteLine(pup, puppies);
                DataSet dataset = new DataSet();
                adaptor.Fill(dataset);

                Console.WriteLine(puppies, adaptor);
                if (dataset.Tables.Count > 0)
                {
                    foreach (DataRow row in dataset.Tables[0].Rows)
                    { Console.WriteLine(puppies); }
                }

                
            }*/





            MeetingModel stockModel = new MeetingModel();
            using (PuppyContext db = new PuppyContext())
                stockModel.PuppyCollection = db.Puppy.ToList<PuppyModel>();
            return View(stockModel);




            /*return View();*/
        }

        // POST: Meeting/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MeetingID,OrganiserPuppyID,AttendeePuppyID,PuppyID,OwnerID,OutForWalk,Location")] MeetingModel meetingModel)
        {

           
            if (ModelState.IsValid)
            {
                string SelectedValue = meetingModel.AttendeePuppyID;

                db.Meetings.Add(meetingModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(meetingModel);
        }

        // GET: Meeting/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeetingModel meetingModel = db.Meetings.Find(long.Parse(id));
            if (meetingModel == null)
            {
                return HttpNotFound();
            }
            return View(meetingModel);
        }

        // POST: Meeting/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MeetingID,OrganiserPuppyID,AttendeePuppyID,PuppyID,OwnerID,OutForWalk,Location")] MeetingModel meetingModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(meetingModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(meetingModel);
        }

        // GET: Meeting/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeetingModel meetingModel = db.Meetings.Find(long.Parse(id));
            if (meetingModel == null)
            {
                return HttpNotFound();
            }
            return View(meetingModel);
        }

        // POST: Meeting/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MeetingModel meetingModel = db.Meetings.Find(long.Parse(id));
            db.Meetings.Remove(meetingModel);
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
