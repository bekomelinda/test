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
        private EmployeeTagsDetailsRepository e = EmployeeTagsDetailsRepository.Instance;
        //
        // GET: /EmployeeTagger/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmployeeTags(int id)
        {
            ViewBag.EmployeeId = id;
            var employeeList = e.GetAll();
            return View(employeeList);
        }

        public ActionResult RemoveTag(int id, int employeeId)
        {
            e.DeleteEmployeeTagById(employeeId, id);
            //return RedirectToAction("EmployeeTags", "EmployeeTagger", employeeId);
            return View(e.EmployeeTagsDetailsListInstance);
        }
    }
}
