using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebNoVi.Models;

namespace WebNoVi.Controllers
{
    public class DonationsAPIController : ApiController
    {
        private CenoviContext db = new CenoviContext();

        // GET: api/DonationsAPI
        public IQueryable<Donation> GetDonations()
        {
            return db.Donations;
        }

        // GET: api/DonationsAPI/5
        [ResponseType(typeof(Donation))]
        public IHttpActionResult GetDonation(int id)
        {
            Donation donation = db.Donations.Find(id);
            if (donation == null)
            {
                return NotFound();
            }

            return Ok(donation);
        }

        // PUT: api/DonationsAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDonation(int id, Donation donation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != donation.DonationId)
            {
                return BadRequest();
            }

            db.Entry(donation).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/DonationsAPI
        [ResponseType(typeof(Donation))]
        public IHttpActionResult PostDonation(Donation donation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            donation.Date = DateTime.Now;
            db.Donations.Add(donation);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = donation.DonationId }, donation);
        }

        // DELETE: api/DonationsAPI/5
        [ResponseType(typeof(Donation))]
        public IHttpActionResult DeleteDonation(int id)
        {
            Donation donation = db.Donations.Find(id);
            if (donation == null)
            {
                return NotFound();
            }

            db.Donations.Remove(donation);
            db.SaveChanges();

            return Ok(donation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DonationExists(int id)
        {
            return db.Donations.Count(e => e.DonationId == id) > 0;
        }
    }
}