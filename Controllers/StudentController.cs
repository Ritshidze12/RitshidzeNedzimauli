using RitshidzeNedzimauliStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RitshidzeNedzimauliStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentsView()
        {
            List<Models.MyStudents> students = new List<Models.MyStudents>();

            students.Add(new Models.MyStudents { StudentNumber = "u24717739", FirstName = "Ritshidze", surname = "Nedzimauli", email = "u24717739@tuks.co.za" });
            students.Add(new Models.MyStudents { StudentNumber = "u24784606", FirstName = "Msizi", surname = "Gumede", email = "u24784606@tuks.co.za" });
            students.Add(new Models.MyStudents { StudentNumber = "u24634400", FirstName = "Boitshoko", surname = "Mphahlele", email = "u24634400@tuks.co.za" });
            students.Add(new Models.MyStudents { StudentNumber = "u24724918", FirstName = "Gundo", surname = "Ndou", email = "u24724918@tuks.co.za" });
            students.Add(new Models.MyStudents { StudentNumber = "u24924142", FirstName = "Walter", surname = "Marimi", email = "u24924142@tuks.co.za" });

            return View(students);
        }
    }
}