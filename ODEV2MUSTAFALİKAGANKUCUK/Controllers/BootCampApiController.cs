using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ODEV2MUSTAFALİKAGANKUCUK.Models;
using ODEV2MUSTAFALİKAGANKUCUK.Repository;

namespace ODEV2MUSTAFALİKAGANKUCUK.Controllers
{
    public class BootCampApiController : Controller
    {
        EmployeeRepository rep = new EmployeeRepository();
        //
        // GET: /Employee/
        public ActionResult Index()
        {
            IEnumerable<Employee> obj = rep.SelectAllEmployees();
            return View(obj);
        }

        //
        // GET: /Employee/Details/5
        public ActionResult Details(int id)
        {
            Employee obj = rep.SelectEmployeeById(id);
            return View(obj);
        }

        //
        // GET: /Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                rep.InsertEmployee(emp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

      

    }
}