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
    public class QueriesAPIController : ApiController
    {
        private CenoviContext db = new CenoviContext();

        // GET: api/QueriesAPI
        public IQueryable<Query> GetQueries()
        {
            return db.Queries;
        }

        // GET: api/QueriesAPI/5
        [ResponseType(typeof(Query))]
        public IHttpActionResult GetQuery(int id)
        {
            Query query = db.Queries.Find(id);
            if (query == null)
            {
                return NotFound();
            }

            return Ok(query);
        }

        // PUT: api/QueriesAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutQuery(int id, Query query)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != query.QueryId)
            {
                return BadRequest();
            }

            db.Entry(query).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QueryExists(id))
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

        // POST: api/QueriesAPI
        [ResponseType(typeof(Query))]
        public IHttpActionResult PostQuery(Query query)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            query.Date = DateTime.Now;
            db.Queries.Add(query);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = query.QueryId }, query);
        }

        // DELETE: api/QueriesAPI/5
        [ResponseType(typeof(Query))]
        public IHttpActionResult DeleteQuery(int id)
        {
            Query query = db.Queries.Find(id);
            if (query == null)
            {
                return NotFound();
            }

            db.Queries.Remove(query);
            db.SaveChanges();

            return Ok(query);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool QueryExists(int id)
        {
            return db.Queries.Count(e => e.QueryId == id) > 0;
        }
    }
}