using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDEMOSectionA.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult AboutUs(int userid)
        {
            return Content("ID:"+ userid);
        }
        [Route("student/students/{year}/{month}")]
        public ActionResult ByAdmissionDate(int year, int month)
        {
            return Content ("Year" + year + "Month" + month);
        }
       
        public ActionResult ContactUs()
        {
            return View("Contact");
        }

        public ActionResult StudentName(int stdId)
        {
            var Students = new[]
            {
              new{stdId=101, Name="Abebe"},
              new{stdId = 102, Name="Kebede"}
            };
            string name = null;
            foreach(var item in Students) {
                if (item.stdId == stdId)
                {
                     name = item.Name;
                }
            }

            return Content(name, "text/plain");
        }
         
    }
}