using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week7CodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // GET: About
        [HttpGet]
        public ActionResult About()
        {
            return View();
        }

        // GET: Work
        [HttpGet]
        public ActionResult Work()
        {
            return View();
        }

        // GET: Careers
        [HttpGet]
        public ActionResult Careers()
        {
            return View();
        }
    }
}