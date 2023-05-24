using eUseControl.BusinessLogic;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using eUseControl.Models;
using System.Web.UI.WebControls;

namespace eUseControl.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _session;
        public LoginController()
        {
            var bl =new BussinesLogic();
            _session = bl.GetSessionBL();
        }

        // GET: Login

        [HttpGet]
        public ActionResult Index()
        {
            return RedirectToAction("SignIn", "Login");
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            UserData u = new UserData();
            ULoginData data = new ULoginData
            {
                Credential = "Login123",
                Password = "wasd2345600",
                LoginIp = Request.UserHostAddress,
                LoginDate = DateTime.Now
            };
            var userLogin = _session.UserLogin(data);
            return View(u); 
        }



        [HttpPost]
        public ActionResult SignIn(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                ULoginData data = new ULoginData
                {
                    Credential = login.Credential,
                    Password = login.Password,
                    LoginIp = Request.UserHostAddress,
                    LoginDate = DateTime.Now
                };
                var userLogin = _session.UserLogin(data);
                if (userLogin.Status)
                {
                    //add cookie
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    ModelState.AddModelError("", userLogin.StatusMsg);
                    return View();
                }

            }
            return View();
        }


    }
}