using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ancestry.Survey.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string origin = "none")
        {
            Session["Origin"] = origin;
            return View();
        }


        public ActionResult Final()
        {
            return View();
        }
    }
}