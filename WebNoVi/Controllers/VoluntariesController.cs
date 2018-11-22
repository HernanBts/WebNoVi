using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebNoVi.Models;

namespace WebNoVi.Controllers
{
    public class VoluntariesController : Controller
    {
        private CenoviContext db = new CenoviContext();

        // GET: Voluntaries
        public ActionResult Index()
        {
            return View(db.Voluntaries.ToList());
        }

        // GET: Voluntaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Voluntary voluntary = db.Voluntaries.Find(id);
            if (voluntary == null)
            {
                return HttpNotFound();
            }
            return View(voluntary);
        }

        // GET: Voluntaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Voluntaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VoluntaryId,Date,Name,Email,Phone,Message")] Voluntary voluntary)
        {
            if (ModelState.IsValid)
            {
                db.Voluntaries.Add(voluntary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(voluntary);
        }

        // GET: Voluntaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Voluntary voluntary = db.Voluntaries.Find(id);
            if (voluntary == null)
            {
                return HttpNotFound();
            }
            return View(voluntary);
        }

        // POST: Voluntaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VoluntaryId,Date,Name,Email,Phone,Message")] Voluntary voluntary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(voluntary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(voluntary);
        }

        // GET: Voluntaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Voluntary voluntary = db.Voluntaries.Find(id);
            if (voluntary == null)
            {
                return HttpNotFound();
            }
            return View(voluntary);
        }

        // POST: Voluntaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Voluntary voluntary = db.Voluntaries.Find(id);
            db.Voluntaries.Remove(voluntary);
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
