using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentCourseRegistrationFinal.Models
{

    public class CourseModel
    {
        [Key]
        public int CourseId { get; set; }
        [Display(Name = "Course Name")]
         [StringLength(30)]
        [Required(ErrorMessage ="Please Enter Course Name")]
        public string CourseName { get; set; }
        [Display(Name = "Course Detail")]
        [StringLength(30)]
        [Required(ErrorMessage = "Please Enter Course Detail")]
        public string CourseDetail { get; set; }
        [Display(Name = "Course Duration")]
        [StringLength(30)]
        [Required(ErrorMessage = "Please Enter Course Duration")]
        public string Duration { get; set; }
        [Display(Name = "Course Fees")]
        [StringLength(30)]
        [Required(ErrorMessage = "Please Enter Course Fees")]
        public string Fees { get; set; }
        //  public string courseTrainer { get; set; }
    }
}