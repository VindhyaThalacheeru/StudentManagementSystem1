using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using StudentCourseTestRegistration;
using System.Security.AccessControl;
using StudentCourseRegistration;

namespace StudentCourseTestRegistration
{
    public class TrainerTest
    {


        [TestCase(1)]
        public void TestDisplayTrainerDetails(long trainerId)
        {
            Trainer t1 = new Trainer(1, "Netra", "Netra125@gmail.com", "9789456971", "India", "Netra", "PasswordNetra1");

            Assert.AreEqual(t1.TrainerId, 1);
            Assert.AreEqual(t1.TrainerName, "Netra");
            Assert.AreEqual(t1.Email, "Netra125@gmail.com");
            Assert.AreEqual(t1.PhoneNo, "9789456971");
            Assert.AreEqual(t1.Country, "India");
            Assert.AreEqual(t1.TrainerUserName, "Netra");
            Assert.AreEqual(t1.TrainerPassword, "PasswordNetra1");
        }
    }
}
