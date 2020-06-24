using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentCourseRegistrationFinal.Models
{
    public class Course1Context : DbContext
    {
        public Course1Context() : base("Mvc")
        {

        }
        public DbSet<CourseModel> CourseModels { get; set; }
        public DbSet<AdminModel> AdminModels { get; set; }

    }
}