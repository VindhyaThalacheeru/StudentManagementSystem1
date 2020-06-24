using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseRegistration
{
    public class Student
    {
        private long _studentId;
        private string _studentName;
        private string _email;
        private string _phoneNo;
        private string _country;
        private string _userName;
        private string _password;

        public Student(long studentId, string studentName, string email, string phoneNo, string country, string userName, string password)
        {
            _studentId = studentId;
            _studentName = studentName;
            _email = email;
            _phoneNo = phoneNo;
            _country = country;
            _userName = userName;
            _password = password;

        }
        public Student()
        {

        }

        public long StudentId
        {
            get => _studentId;
            set => _studentId = value;
        }
        public string StudentName
        {
            get => _studentName;
            set => _studentName = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }
        public string PhoneNo
        {
            get => _phoneNo;
            set => _phoneNo = value;
        }
        public string Country
        {
            get => _country;
            set => _country = value;
        }
        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }
        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public Dictionary<long, long> coursesOptedfor = new Dictionary<long, long>();

        public void DisplayStudentDetails(long id)
        {
            foreach (var objstudent in Studentlist.lststudent)
            {
                if (objstudent.StudentId == id)
                {
                    Console.WriteLine("Name :" + objstudent.StudentId);
                    Console.WriteLine("Email :" + objstudent.Email);
                    Console.WriteLine("PhoneNumber :" + objstudent.PhoneNo);
                    Console.WriteLine("Country :" + objstudent.Country);
                    DisplayCoursesAssociatedwithStudents(objstudent.coursesOptedfor);

                    Console.WriteLine("DU YOU WANT TO ENROLL FOR COURSES :\n");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    long choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        Courselist cl2 = new Courselist();
                        cl2.EnrollCourse(objstudent.StudentId);
                    }

                }
            }
        }
        private void DisplayCoursesAssociatedwithStudents(Dictionary<long, long> coursesOptedfor)
        {
            foreach (var key in coursesOptedfor.Keys)
            {
                foreach (var courses in Courselist.lstCourses)
                {
                    if (courses.CourseId == key)
                    {
                        Console.WriteLine("Course ID :" + courses.CourseId);
                        Console.WriteLine("Course Name :" + courses.CourseName);
                        Console.WriteLine("Course Detail :" + courses.CourseDetail);
                        Console.WriteLine("Course Duration :" + courses.Duration);
                        Console.WriteLine("Course Fees :" + courses.Fees);
                    }
                }
            }
        }


    }

}