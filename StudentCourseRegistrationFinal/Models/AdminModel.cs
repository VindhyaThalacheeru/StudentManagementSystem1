using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentCourseRegistrationFinal.Models
{
    public class AdminModel
    {
        [Key]
        [Display(Name = "User Name")]
        [StringLength(30)]
        [Required(ErrorMessage = "Please Enter Correct UserName")]
        public string UserName { get; set; }
        [Display(Name = "Password")]
        [StringLength(30)]
        [Required(ErrorMessage = "Please Enter Correct Password")]
        public string Password { get; set; }
        
    } 
}