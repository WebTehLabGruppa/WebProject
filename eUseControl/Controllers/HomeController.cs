using eUseControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            UserData u = new UserData();
            u.Username = "customer";
            u.Products = new List<string> { "Product #1", "Product #2", "Product #3", "Product #4" };

           return View();
        }

        public ActionResult IndexAdmin()
        {
            UserData u = new UserData();
            u.Username = "admin";
            u.Products = new List<string> { "Product #1", "Product #2", "Product #3", "Product #4" };

            return View();
        }

        public ActionResult CoursesPage()
        {
            return View();
        }

        public ActionResult CourseSingle()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult BlogSingle() 
        {
            return View();
        }
        public ActionResult Instructors() 
        {
            return View();
        }
        public ActionResult Regular()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult LoginForm()
        {
            return View();
        }
    }
}