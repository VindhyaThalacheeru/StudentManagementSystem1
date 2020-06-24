using System;
using System.Text;
using System.Collections.Generic;
using StudentCourseTestRegistration;
using NUnit.Framework;
using StudentCourseRegistration;

namespace StudentCourseTestRegistration
{
    [TestFixture]
    public class AdminTest
    {
        Admin ad = new Admin()
        {
            AdminUserName = "MainAdmin",
            AdminPassword = "Password1!"
        };
        [TestCase("MainAdmin1", "Password1")]
        public void When_username_passwordnotsatisfies(string userName, string password)
        {
            //ad.AdminUserName = "MainAdmin1";
            //ad.AdminPassword = "Password1";
            Assert.AreNotEqual("MainAdmin1", ad.AdminUserName);
            Assert.AreNotEqual("Password1", ad.AdminPassword);
        }

    }
}
