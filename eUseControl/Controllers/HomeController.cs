using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.Web.Controllers;
using eUseControl.Web.Extension;
using eUseControl.Web.Models;

namespace eUseControl.Web.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            SessionStatus();

           /* if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            } */
            var user = "guest"; /*System.Web.HttpContext.Current.GetMySessionObject();*/
            UserData u = new UserData
            {
                Username = user,
                Products = new List<string> { "Product #1", "Product #2", "Product #3", "Product #4" }
            };

            return View(u);
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

        public ActionResult CourseEnglish()
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