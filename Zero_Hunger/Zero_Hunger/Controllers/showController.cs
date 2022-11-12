using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger.Models;

namespace Zero_Hunger.Controllers
{
    public class showController : Controller
    {

        ZhungerEntities db = new ZhungerEntities();

        // GET: ngo
        public ActionResult Index()
        {
            var result = (from r in db.ngoes
                          join c in db.Frestaurents on r.resid equals c.resname

                          select new NgoAvail
                          {
                              id = r.id,
                              resid = r.resid,
                              employeeid = r.employeeid,
                              sdate = r.sdate,
                              edate = r.edate,
                              available = c.available


                          }).ToList();




            return View(result);
        }
    }
}