using Microsoft.Ajax.Utilities;
using StudentCourseRegistrationFinal.Migrations;
using StudentCourseRegistrationFinal.Models;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace StudentCourseRegistrationFinal.Controllers
{
    public class CourseController : Controller
    {
        private Course1Context _con;
        public CourseController()
        {
        _con = new Course1Context();
        }
        //Disposal method of dispose object after completion of use.
        protected override void Dispose(bool disposing)
        {
            _con.Dispose();
        }

        // GET: Course
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        
        //To display all available courses.
        public ActionResult DisplayCourses()
        {
            var clist = _con.CourseModels.ToList();
            return View(clist);
        }

        //To add a new course.
        public ActionResult Add()
        {
            return View();
        }

        //To create a new course.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseModel cm)
        {
            if(cm != null)
            {
                if(ModelState.IsValid)
                {
                    _con.CourseModels.Add(cm);
                    _con.SaveChanges();
                    return RedirectToAction("DisplayCourses");
                }
            }
            return RedirectToAction("Add");
        }

        //To get the details of Course.
        [HttpGet]
        public ActionResult Detail(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseModel cm2 = _con.CourseModels.Find(Id);
            if (cm2 == null)
            {
                return HttpNotFound();
            }
            return View(cm2);
        }
        [HttpPost]
        public ActionResult Detail(CourseModel cm1)
        {
            if (cm1 != null)
            {
                if (ModelState.IsValid)
                {
                    var ed = _con.CourseModels.SingleOrDefault(x => x.CourseId == cm1.CourseId);
                    return View(ed);
                    //return RedirectToAction("DisplayCourses");
                }
            }
            return RedirectToAction("Edit");
        }

        //To edit the fees of Course.
        [HttpGet]
        public ActionResult Edit(int? Id)
        {
            if(Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseModel cm2 = _con.CourseModels.Find(Id);
            if(cm2 == null)
            {
                return HttpNotFound();
            }
            return View(cm2);
        }
        [HttpPost]
        public ActionResult Edit(CourseModel cm1)
        {
            if (cm1 != null)
            {
                
                    var ed = _con.CourseModels.SingleOrDefault(x=>x.CourseId == cm1.CourseId);
                    ed.Fees = cm1.Fees;
                    _con.SaveChanges();
                    return RedirectToAction("DisplayCourses");
                
            }
            return RedirectToAction("Edit");
        }
         
        //To delete the particular course.
        [HttpGet]
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseModel cm2 = _con.CourseModels.Find(Id);
            if (cm2 == null)
            {
                return HttpNotFound();
            }
            return View(cm2);
        }
        [HttpPost]
        public ActionResult Delete(CourseModel cm1)
        {
            if (cm1 != null)
            {
                
                    var ed = _con.CourseModels.SingleOrDefault(x => x.CourseId == cm1.CourseId);
                    _con.CourseModels.Remove(ed);
                    _con.SaveChanges();
                    return RedirectToAction("DisplayCourses");
                
            }
            return RedirectToAction("Edit");
        }


    }
}