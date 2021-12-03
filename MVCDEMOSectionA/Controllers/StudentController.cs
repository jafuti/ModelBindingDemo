using MVCDEMOSectionA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDEMOSectionA.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var student = new List<Student>()
            {
                new Student {ID = 101, Name="Abebe", Grade = 3},
                new Student {ID = 102, Name="kebede", Grade = 3},
                new Student {ID = 103, Name="taso", Grade = 3},
            };
           // ViewBag.student = student;
            return View(student);
        }
        public ActionResult StudentData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StudentData(Student student)
        {
            return View();
        }


    }
}