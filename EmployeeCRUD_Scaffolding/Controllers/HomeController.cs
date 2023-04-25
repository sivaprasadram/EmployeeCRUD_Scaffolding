using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeCRUD_Scaffolding.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            tutoralsCS _context = new tutoralsCS();
            var listofData = _context.Employees.ToList();
            return View(listofData);
        }
    }
}