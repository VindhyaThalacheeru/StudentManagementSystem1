using System;
using System.Text;
using System.Collections.Generic;
using StudentCourseTestRegistration;
using StudentCourseRegistration;
using NUnit.Framework;
using System.Security.AccessControl;

namespace StudentCourseTestRegistration
{
    [TestFixture]
    public class CourseTest
    {
        [Test]
        public void TestCourse1()
        {
            Course1 cr1 = new Course1(1, "Java", "CoreJava", "120 hours", "6000");
            Assert.AreEqual(cr1.CourseId, 1);
            Assert.AreEqual(cr1.CourseName, "Java");
            Assert.AreEqual(cr1.CourseDetail, "CoreJava");
            Assert.AreEqual(cr1.Duration, "120 hours");
            Assert.AreEqual(cr1.Fees, "6000");
        }
    }
}
