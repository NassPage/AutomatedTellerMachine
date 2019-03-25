using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    //[Authorize] evety ethod inside class require autrization except wich are tagged by [AllowAnonymous] filter
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "having trouble ? send us a message ";
            //TempData[""]
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your About page.";

            return View();
        }

        //[Authorize] //allow any logged-in user
        //[Authorize(Roles ="adminitstrator",Users ="jsmith")]
        //[ActionName]
        [HttpPost]
        public ActionResult Contact(string message)
        {

            ViewBag.Message = "thanks we got your message!";

            return View();
        }

      

        //fo is a aliace for "about" page
        [HttpGet] //selector
        public ActionResult Foo() {
            return View("About");
        }

    }
}

/*
 create a custom action filter -that run before or after an action executed
- inherit from ActionFilterAttribute class
- override OnActionExcecuting method
- and/or override OnActionExcecuted method
    ** filter can added globaly if added in the registerGlobalFilter inside fliterConfig class
     */
