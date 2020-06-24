using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentCourseRegistration
{
    public class Courselist
    {

        public static List<Course1> lstCourses = new List<Course1>();

        public int CheckForCourse(long courseId)
        {
            int check = lstCourses.Where(c => c.CourseId == courseId).Count();
            return check;
        }

        public void DisplayAllCourses()
        {
            foreach (var course in lstCourses)
            {
                Console.WriteLine("DISPLAYING ALL COURSES");
                Console.WriteLine("Course ID :" + course.CourseId);
                Console.WriteLine("Course Name :" + course.CourseName);
                Console.WriteLine("Course Detail :" + course.CourseDetail);
                Console.WriteLine("Course Duration :" + course.Duration);
                Console.WriteLine("Course Fees :" + course.Fees);
            }
        }

        public void EnrollCourse(long studentid)
        {
            Console.WriteLine("Enter Valid course id that you want to enroll");
            DisplayAllCourses();
            int CourseID = Convert.ToInt32(Console.ReadLine());
            int check = CheckForCourse(CourseID);
            if (check == 1)
            {
                foreach (var obj in Studentlist.lststudent)
                {
                    if (obj.StudentId == studentid)
                    {
                        obj.coursesOptedfor.Add(CourseID, studentid);
                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid Course ID");
                EnrollCourse(studentid);
            }
            Console.WriteLine("Press any key to exit the process...");
            Console.Read();

        }



    }
}