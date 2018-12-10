using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNoVi.Models;
using WebNoVi.ModelView;

namespace WebNoVi.Controllers
{
    public class MessageController : Controller
    {
        private CenoviContext db = new CenoviContext();

        // GET: Message
        public ActionResult Index()
        {
            MessageViewModel messagesView = new MessageViewModel();
            
            List<Query> queryList = new List<Query>();
            var queryes = db.Queries.ToList();
            foreach (var query in queryes)
            {
                var queryView = new Query
                {
                    QueryId = query.QueryId,
                    Date = query.Date,
                    Name = query.Name,
                    Subject = query.Subject,
                    Email = query.Email,
                    Message = query.Message
                };
                queryList.Add(queryView);
            }

            List<Voluntary> voluntariesList = new List<Voluntary>();
            var voluntaries = db.Voluntaries.ToList();
            foreach (var item in voluntaries)
            {
                var voluntaryView = new Voluntary
                {
                    VoluntaryId = item.VoluntaryId,
                    Date = item.Date,
                    Name = item.Name,
                    Email = item.Email,
                    Phone = item.Phone,
                    Message = item.Message
                };
                voluntariesList.Add(voluntaryView);
            }

            List<Donation> onationList = new List<Donation>();
            var onations = db.Donations.ToList();
            foreach (var item in onations)
            {
                var onationView = new Donation
                {
                    DonationId = item.DonationId,
                    Date = item.Date,
                    Name = item.Name,
                    Email = item.Email,
                    Message = item.Message,
                    Amount = item.Amount
                };
                onationList.Add(onationView);
            }
            messagesView.Queries = queryList;
            messagesView.Voluntaries = voluntariesList;
            messagesView.Donations = onationList;
            
            return View(messagesView);
        }
        /*
        // GET: Message/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Message/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Message/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Message/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Message/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Message/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Message/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        */

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
