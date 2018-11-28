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
    public class VoluntariesAPIController : ApiController
    {
        private CenoviContext db = new CenoviContext();

        // GET: api/VoluntariesAPI
        public IQueryable<Voluntary> GetVoluntaries()
        {
            return db.Voluntaries;
        }

        // GET: api/VoluntariesAPI/5
        [ResponseType(typeof(Voluntary))]
        public IHttpActionResult GetVoluntary(int id)
        {
            Voluntary voluntary = db.Voluntaries.Find(id);
            if (voluntary == null)
            {
                return NotFound();
            }

            return Ok(voluntary);
        }

        // PUT: api/VoluntariesAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVoluntary(int id, Voluntary voluntary)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != voluntary.VoluntaryId)
            {
                return BadRequest();
            }

            db.Entry(voluntary).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VoluntaryExists(id))
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

        // POST: api/VoluntariesAPI
        [ResponseType(typeof(Voluntary))]
        public IHttpActionResult PostVoluntary(Voluntary voluntary)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            voluntary.Date = DateTime.Now;
            db.Voluntaries.Add(voluntary);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = voluntary.VoluntaryId }, voluntary);
        }

        // DELETE: api/VoluntariesAPI/5
        [ResponseType(typeof(Voluntary))]
        public IHttpActionResult DeleteVoluntary(int id)
        {
            Voluntary voluntary = db.Voluntaries.Find(id);
            if (voluntary == null)
            {
                return NotFound();
            }

            db.Voluntaries.Remove(voluntary);
            db.SaveChanges();

            return Ok(voluntary);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VoluntaryExists(int id)
        {
            return db.Voluntaries.Count(e => e.VoluntaryId == id) > 0;
        }
    }
}