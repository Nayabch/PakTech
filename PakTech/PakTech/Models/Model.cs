using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PakTech.Models
{
    public class Course
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
       
        [Display(Name ="Image")]
        public string imageUrl { get; set; }
        [Required]
        public string Instructor { get; set; }
        [Required]
        [Display(Name = "Course Duration")]
        public string CourseDuration { get; set; }
        [Required]
        [Display(Name = "Short Description")]
        public string ShortDescription { get; set; }
        [Required]
        [Display(Name = "Long Description")]
        public string LongDescription { get; set; }
        [Required]
        public string Catagory { get; set; }
        [Required]
        public string Fee { get; set; }

    }

}