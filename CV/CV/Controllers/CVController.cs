using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public ActionResult Index()
        {
            ViewBag.Name = "Md. Musfiqur Rahman";
            ViewData["Nationality"] = "Bangladeshi";
            ViewBag.PermanentAddress = "Dinajpur, Bangladesh";
            ViewData["Email"] = "mushfiqur.abir@gmail.com";
            return View();
            
        }

        public ActionResult Education()
        {
            return View();
        }

        public ActionResult CCA()
        {
            ViewBag.name1 = "1. Assistant Rover Mate, BAF SHAHEEN AIR ROVER";
            ViewBag.name2 = "2. Event Manager, AIUB Computer Club";
            ViewData["extra1"] = "3. CO-OP, AIUB Photography Club";
            ViewData["extra2"] = "4. Member, AIUB Shomoy Club";
            return View();
        }

        public ActionResult Reference()
        {
            return View();
        }

        public ActionResult Intro()
        {
            return View();
        }

    }
}