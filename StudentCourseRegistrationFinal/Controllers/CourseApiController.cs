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
using StudentCourseRegistrationFinal.Models;

namespace StudentCourseRegistrationFinal.Controllers
{
    public class CourseApiController : ApiController
    {
        private Course1Context db = new Course1Context();

        // GET: api/CourseApi
        [HttpGet]
        public IQueryable<CourseModel> GetCourseModels()
        {
            return db.CourseModels;
        }

        // GET: api/CourseApi/5
        [HttpGet]
        [ResponseType(typeof(CourseModel))]
        public IHttpActionResult GetCourseModel(int id)
        {
            CourseModel courseModel = db.CourseModels.Find(id);
            if (courseModel == null)
            {
                return NotFound();
            }

            return Ok(courseModel);
        }

        // PUT: api/CourseApi/5
        [HttpPut]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCourseModel(int id, CourseModel courseModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != courseModel.CourseId)
            {
                return BadRequest();
            }

            db.Entry(courseModel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseModelExists(id))
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

        // POST: api/CourseApi
        [HttpPost]
        [ResponseType(typeof(CourseModel))]
        public IHttpActionResult PostCourseModel(CourseModel courseModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CourseModels.Add(courseModel);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = courseModel.CourseId }, courseModel);
        }

        // DELETE: api/CourseApi/5
        [HttpDelete]
        [ResponseType(typeof(CourseModel))]
        public IHttpActionResult DeleteCourseModel(int id)
        {
            CourseModel courseModel = db.CourseModels.Find(id);
            if (courseModel == null)
            {
                return NotFound();
            }

            db.CourseModels.Remove(courseModel);
            db.SaveChanges();

            return Ok(courseModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CourseModelExists(int id)
        {
            return db.CourseModels.Count(e => e.CourseId == id) > 0;
        }
    }
}