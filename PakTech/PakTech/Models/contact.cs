﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PakTech.Models
{
    public class contact
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name ="Phone No.")]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }

    }
}