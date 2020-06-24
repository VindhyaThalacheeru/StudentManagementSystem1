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
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        //To Login the admin.
        public ActionResult AdminLogin()
        {
            return View();
        }

        //Entering admin credentials.
        [HttpPost]
        public ActionResult AdminLogin(AdminModel adminModel)
        {
            if (adminModel.UserName.Equals("Admin") && adminModel.Password.Equals("Admin123"))
            {
                ViewBag.Message = "Admin Login Successful";
                return RedirectToAction("DisplayCourses","Course");
            }
            else
            {
                ModelState.AddModelError("", "Invalid Credentials");
            }
            return View();
        }
    }
}