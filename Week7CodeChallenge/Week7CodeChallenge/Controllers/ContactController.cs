using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week7CodeChallenge.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Models.AJAXContactForm inputData)
        {
            // Dump the inputted data into the database
            Models.ContactFormEntities db = new Models.ContactFormEntities();
            db.AJAXContactForms.Add(inputData);
            db.SaveChanges();
            return Content("Thanks");
        }
    }
}