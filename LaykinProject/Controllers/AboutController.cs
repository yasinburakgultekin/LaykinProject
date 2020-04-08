using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaykinProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            ViewBag.Title = "Laykin Danışmanlık Ltd. Şti.";
            return View();
        }
    }
}