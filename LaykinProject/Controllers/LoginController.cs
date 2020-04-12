using LaykinProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaykinProject.Controllers
{   
    public class LoginController : Controller
    {
        LaykinProjectDBEntities db = new LaykinProjectDBEntities();
        public ActionResult Index()
        {
            return View();
        }
    }
}