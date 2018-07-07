using PakTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PakTech.Controllers
{
    public class HomeController : Controller

    {
        DAL db = new DAL();
        public ActionResult Index()
        {

            return View(db.Course.ToList());
        }
        public ActionResult Courses(string SrchQry,string cat)
        {
            ViewBag.Categories = db.catagory.ToList();
            var courses = from m in db.Course select m;
            if (!String.IsNullOrEmpty(SrchQry))
            {
                courses = courses.Where(i => i.Title.Contains(SrchQry));
            }
            if (!String.IsNullOrEmpty(cat))
            {
                courses = courses.Where(i => i.Catagory.Contains(cat));
            }
            return View(courses);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(contact cnct)
        {
            if (ModelState.IsValid)
            {
                db.contact.Add(cnct);
                db.SaveChanges();
            }


            return View();
        }
        public ActionResult course(int id)
        {
            Course crs = db.Course.Find(id);
            
            return View(crs);
        }
    }
}