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
    public class CourseControllerTest
    {
        [TestMethod]
        public void CourseModel()
        {
            CourseController controller = new CourseController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
