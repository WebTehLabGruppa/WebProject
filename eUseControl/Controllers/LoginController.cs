using eUseControl.BusinessLogic;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.User;
using System;
using System.Web.Mvc;
using eUseControl.Web.Models;
using System.Web.UI.WebControls;
using AutoMapper;
using System.Web;

namespace eUseControl.Web.Controllers
{
    public class LoginController : Controller
    { 
            private readonly ISession _session;
            private readonly IMapper _mapper;

            public LoginController()
            {
                var bl = new BussinesLogic();
                _session = bl.GetSessionBL();

                // Инициализация конфигурации Automapper
                var mapperConfig = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<UserLogin, ULoginData>();
                });
                _mapper = mapperConfig.CreateMapper();
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
            UserLogin u = new UserLogin();
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
        [ValidateAntiForgeryToken]
            public ActionResult SignIn(UserLogin login)
            {
                if (ModelState.IsValid)
                {
                    var data = _mapper.Map<ULoginData>(login);

                    data.LoginIp = Request.UserHostAddress;
                    data.LoginDate = DateTime.Now;

                    var userLogin = _session.UserLogin(data);
                    if (userLogin.Status)
                    {
                        HttpCookie cookie = _session.GenCookie(login.Credential);
                        ControllerContext.HttpContext.Response.Cookies.Add(cookie);

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


        // GET: Login

      

    




   