using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace furni.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult About()
		{
			return View();
		}

		public ActionResult Contact()
		{
			// Redirect to the 'Create' action of 'UserInformationsController'
			return RedirectToAction("Create", "UserInformations");
		}
		public ActionResult Services()
		{
			return View();
		}
		
	}
}