using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaykinProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            ViewBag.Title = "Laykin Danışmanlık Ltd. Şti.";
            return View();
        }

        public ActionResult Category()
        {
            return View();
        }

        public ActionResult LatestNews()
        {
            return View();
        }

        public ActionResult Tags()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }

    }
}