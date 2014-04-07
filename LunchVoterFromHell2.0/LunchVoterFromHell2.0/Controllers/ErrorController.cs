using System.Web.Mvc;

namespace LunchVoterFromHell2.Controllers
{
    public class ErrorController : Controller
    {
        // GET: /Error/
        public ActionResult Index()
        {
            return this.View();
        }

        // UserNotExits: /Error/
        public ActionResult UserNotExits()
        {
            return this.View();
        }
    }
}
