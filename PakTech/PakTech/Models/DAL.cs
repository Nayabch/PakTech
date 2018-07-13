using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PakTech.Models
{
    public class DAL:DbContext
    {
        public DbSet<Course> Course { get; set; }
        public DbSet<catagory> catagory { get; set; }
        public DbSet<contact> contact { get; set; }
        public DbSet<Events> Events { get; set; }

       
    }
}