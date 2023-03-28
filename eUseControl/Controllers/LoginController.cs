using System.Web.Mvc;

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


    }

  
}