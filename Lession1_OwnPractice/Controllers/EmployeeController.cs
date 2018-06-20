using Lession1_OwnPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lession1_OwnPractice.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HttpGet]
        public ActionResult Index()
        {
            DAL.DataContext db = new DAL.DataContext();            
            ViewBag.employee = (from d in db.Employees select d).ToList();                        
            return View();
        }
        [HttpPost]
        public ActionResult Employee(Employee employee)
        { 

            DAL.DataContext db = new DAL.DataContext();
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}