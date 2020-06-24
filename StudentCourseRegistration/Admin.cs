using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace StudentCourseRegistration
{
    public class Admin
    {
        public static long TrainerId = 1;
        public static long CourseID = 1;
        private string _adminUserName;
        private string _adminPassword;

        public Admin(string adminUserName, string adminPassword)
        {
            _adminUserName = adminUserName;
            _adminPassword = adminPassword;
        }
        public Admin()
        {

        }

        public string AdminUserName
        {
            get => _adminUserName;
            set => _adminUserName = value;
        }
        public string AdminPassword
        {
            get => _adminPassword;
            set => _adminPassword = value;
        }




        internal void DisplayAllTrainers()
        {
            foreach (var faulty in Trainerlist.lstTrainer)
            {
                Console.WriteLine("DISPLAYING TRAINER DETAILS");
                Console.WriteLine("Trainer Name :" + faulty.TrainerName);
                Console.WriteLine("Email :" + faulty.Email);
                Console.WriteLine("PhoneNumber :" + faulty.PhoneNo);
                Console.WriteLine("Country :" + faulty.Country);
                Console.WriteLine("COURSES TAGGED TO");
                foreach (var course in faulty.coursesAssociatedwith)
                {
                    //foreach (var courses in Courselist.lstCourses)
                    //{
                    //if (courses.CourseId == course.Key)
                    //{
                    //Console.WriteLine("DISPLAYING COURSE DETAILS");
                    //Console.WriteLine("Course ID :" + courses.CourseId);
                    //Console.WriteLine("Course Name :" + courses.CourseName);
                    //Console.WriteLine("Course Detail :" + courses.CourseDetail);
                    //Console.WriteLine("Course Duration :" + courses.Duration);
                    //Console.WriteLine("Course Fees :" + courses.Fees);
                    //}
                    //}
                    Connected cons = new Connected();
                    cons.ReadData();
                }

            }

        }

    }
}
