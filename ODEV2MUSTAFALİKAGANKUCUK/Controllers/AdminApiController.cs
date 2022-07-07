using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ODEV2MUSTAFALİKAGANKUCUK.Models;
using ODEV2MUSTAFALİKAGANKUCUK.Repository;


namespace ODEV2MUSTAFALİKAGANKUCUK.Controllers
{
    public class AdminApiController : Controller
    {
        EmployeeRepository rep = new EmployeeRepository();
        // GET: AdminApi
        public ActionResult Index()
        {
            return View();
        }
        //
        // GET: /Employee/Edit/5
        public ActionResult Edit(int id)
        {
            Employee obj = rep.SelectEmployeeById(id);
            return View(obj);
        }

        //
        // POST: /Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                rep.UpdateEmployee(emp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employee/Delete/5
        public ActionResult Delete(int id)
        {
            Employee obj = rep.SelectEmployeeById(id);
            return View(obj);
        }

        //
        // POST: /Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                rep.DeleteEmployee(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}