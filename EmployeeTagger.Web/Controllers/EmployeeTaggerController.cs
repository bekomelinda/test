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
        private TagRepository tag = new TagRepository();
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
            ViewBag.EmployeeId = employeeId;
            return RedirectToAction("EmployeeTags", "EmployeeTagger", new { id = employeeId });
        }

        public JsonResult TagsAutocomplete(string term)
        {
            var allTags = tag.GetAll();
            var result = (from r in allTags
                          where r.Name.ToLower().Contains(term.ToLower())
                          select new { r.Name }).Distinct();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
