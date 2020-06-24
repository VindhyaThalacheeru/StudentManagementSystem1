using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentCourseRegistrationFinal.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using StudentCourseRegistrationFinalTest;

namespace StudentCourseRegistrationFinalTest
{
    [TestClass]
    public class AdminLoginTest
    {
        [TestMethod]
        public void AdminModel()
        {
            AdminController controller = new AdminController();
            ViewResult result = controller.AdminLogin() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
