using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger.Models;

namespace Zero_Hunger.Controllers
{
    public class NgoController : Controller
    {
        zerohungerEntities db = new zerohungerEntities();

        // GET: Ngo
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Getres()
        {
           var restaurant = db.restaurants.ToList();


            return Json(restaurant, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Getid(int id)
        {
            var employee = (from s in db.employees where s.id == id select s.empname).ToList();


            return Json(employee, JsonRequestBehavior.AllowGet);
        }
    }
}