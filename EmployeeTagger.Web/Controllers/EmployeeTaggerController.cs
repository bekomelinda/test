using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;
using System.Data.Entity;

using EmployeeTagger.Data;
using EmployeeTagger.Model;


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
        public ActionResult EmployeeTags(int id)
        {
            ViewBag.EmployeeId = id;
            EmployeeTagsDetailsRepository e = EmployeeTagsDetailsRepository.Instance;
            var employeeList = e.GetAll();
            return View(employeeList);
        }

        public ActionResult RemoveTag(int id, int employeeId)
        {

            EmployeeTagsDetailsRepository e = EmployeeTagsDetailsRepository.Instance;
            var employeeList = e.GetAll();
            EmployeeTagsDetails employee = employeeList.FirstOrDefault(x => x.Id == employeeId);
            employee.TagList.Remove(employee.TagList.FirstOrDefault(x => x.Id == id));
            return View(employeeList);
        }
    }
}
