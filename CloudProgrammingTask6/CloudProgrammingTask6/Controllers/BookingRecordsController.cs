using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CloudProgrammingTask6.Models;

namespace CloudProgrammingTask6.Controllers
{
    public class BookingRecordsController : Controller
    {
        private ContactDBContext db = new ContactDBContext();

        [Authorize]
        // GET: BookingRecords
        public ActionResult Index()
        {
            return View(db.Bookings.ToList());
        }

        // GET: BookingRecords/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingRecord bookingRecord = db.Bookings.Find(id);
            if (bookingRecord == null)
            {
                return HttpNotFound();
            }
            return View(bookingRecord);
        }

        // GET: BookingRecords/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookingRecords/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,Age,Gender,Departure,Arrival,DepartureTime,ArrivalTime,FlightNumber,Price,FareClass,PromoCode,State,Note")] BookingRecord bookingRecord)
        {
            if (ModelState.IsValid)
            {
                db.Bookings.Add(bookingRecord);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookingRecord);
        }

        // GET: BookingRecords/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingRecord bookingRecord = db.Bookings.Find(id);
            if (bookingRecord == null)
            {
                return HttpNotFound();
            }
            return View(bookingRecord);
        }

        // POST: BookingRecords/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,Age,Gender,Departure,Arrival,DepartureTime,ArrivalTime,FlightNumber,Price,FareClass,PromoCode,State,Note")] BookingRecord bookingRecord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookingRecord).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookingRecord);
        }

        // GET: BookingRecords/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingRecord bookingRecord = db.Bookings.Find(id);
            if (bookingRecord == null)
            {
                return HttpNotFound();
            }
            return View(bookingRecord);
        }

        // POST: BookingRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookingRecord bookingRecord = db.Bookings.Find(id);
            db.Bookings.Remove(bookingRecord);
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
