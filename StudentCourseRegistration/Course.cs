using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseRegistration
{
    public class Course1
    {
        private long _courseId;
        private string _courseName;
        private string _courseDetail;
        private string _duration;
        private string _fees;
        public Course1()
        {

        }

        public Course1(long courseId, string courseName, string courseDetail, string duration, string fees)
        {
            _courseId = courseId;
            _courseName = courseName;
            _courseDetail = courseDetail;
            _duration = duration;
            _fees = fees;

        }

        public long CourseId
        {
            get => _courseId;
            set => _courseId = value;
        }
        public string CourseName
        {
            get => _courseName;
            set => _courseName = value;
        }
        public string CourseDetail
        {
            get => _courseDetail;
            set => _courseDetail = value;
        }
        public string Duration
        {
            get => _duration;
            set => _duration = value;
        }
        public string Fees
        {
            get => _fees;
            set => _fees = value;
        }
    }
}