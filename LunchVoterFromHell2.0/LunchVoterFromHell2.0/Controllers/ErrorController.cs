using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LunchVoterFromHell2.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/

        public ActionResult Index()
        {
            return View();
        }

        //
        // UserNotExits: /Error/
        public ActionResult UserNotExits()
        {
            return View();
        }
    }
}
