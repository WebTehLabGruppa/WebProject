using Microsoft.Ajax.Utilities;
using System;
using System.Net;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace eUseControl.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _session;

        public LoginController()
        {
            var bl = new BusinessLogic();
            _session = bl.GetSession();

        }

        //GET: Login

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Index(UserLogin login)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}

/*  
        public ActionResult Index(UserLogin login)
            if (ModelState.IsValid)
            {
                ULoginData data = new ULoginData
                {
                    Credential = Login.Credential,
                    Password = Login.Password,
                    LoginIp = Request.UserHostAdress,
                    LoginDateTime = DateTime.Now
                };

                Var userLogin = _session.UserLogin(data);
                if(userLogin.Status)
                {
                    //ADD COCKIE
                    return RedirectToAction("Index","Home");
                }
                else 
                {
                   ModelState.AddModelError("",userLogin.StatusMsg);
                    return View;
                }

return View();
  
}
 */