using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentCourseRegistration
{
    public class Studentlist
    {
        public static List<Student> lststudent = new List<Student>();

        public void AddStudent(Student s1)
        {
            lststudent.Add(s1);
        }



    }
}