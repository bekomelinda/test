using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;
using System.Data.Entity;

using EmployeeTagger.Data;


namespace EmployeeTagger.Web.Controllers
{
    public class EmployeeTaggerController : Controller
    {
        //
        // GET: /EmployeeTagger/

        public ActionResult Index()
        {
            return View();
        }   
        public ActionResult EmployeeTags(int? id)        
        {
            ViewBag.EmployeeId = id;
            var e = new EmployeeTagsRepository();
            var employeeList = e.GetEmployeeTags();
            return View(employeeList);
        }

        public ActionResult EmployeeTagList()
        {
            var e = new EmployeeTagsRepository();
            var employeeList = e.GetEmployeeTags();
            return View(employeeList[1]);
        }
    }
}
