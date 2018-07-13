using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PakTech.Models
{
    public class Events
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Display(Name ="Short Description")]
        public string shortdescription { get; set; }
        [Required]
        [Display(Name = "Date Of Seminar")]
        public string dateofseminar { get; set; }
        [Required]
        public string Image { get; set; }
    }
}