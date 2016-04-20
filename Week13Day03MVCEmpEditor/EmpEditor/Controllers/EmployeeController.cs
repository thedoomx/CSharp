using EmpEditor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace EmpEditor.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _repository = new EmployeeRepository();

        public ActionResult Index(int? page)
        {
            EmployeeViewModel vm = new EmployeeViewModel()
            {
                Employees = _repository.GetEmployees().Select(e => new EmpModel() { Id = e.ID, Name = e.Name })
                                                      .ToList()
            };



            if (Request.HttpMethod != "GET")
            {
                page = 1;
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);

            return View(vm.Employees.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Details(int id = 0)
        {

            var employee = _repository.GetEmployeeById(id);

            if (employee == null)
            {
                return HttpNotFound();
            }

            return View(new EmpModel() { Name = employee.Name, Id = employee.ID });
        }

        [HttpGet]
        public ActionResult Delete(int id = 0)
        {
            Employee emp = _repository.GetEmployeeById(id);

            if (emp == null)
            {
                return HttpNotFound();
            }

            return View(new EmpModel() { Name = emp.Name, Id = emp.ID });
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _repository.DeleteEmployee(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpModel employee)
        {
            if (ModelState.IsValid)
            {
                _repository.AddEmployee(employee);

                return RedirectToAction("Index");
            }

            return View(employee);
        }

        [HttpGet]
        public ActionResult Update(int id = 0)
        {
            Employee emp = _repository.GetEmployeeById(id);

            if (emp == null) return HttpNotFound();

            return View(new EmpModel() { Id = emp.ID, Name = emp.Name });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(EmpModel employee)
        {
            if (ModelState.IsValid)
            {
                Employee emp = _repository.GetEmployeeById(employee.Id);
                emp.Name = employee.Name;

                _repository.UpdateEmployee(emp);

                return RedirectToAction("Index");
            }

            return View(employee);
        }

        public PartialViewResult AllEmployees()
        {
            return PartialView("_allEmployees", _repository.GetEmployees());
        }

        public PartialViewResult Hide()
        {
            return PartialView("_hide", new List<Employee>());
        }

        public PartialViewResult JustBoss()
        {
            return PartialView("_boss", _repository.GetEmployees().FirstOrDefault());
        }

        [HttpGet]
        public ActionResult Search()
        {
            return View(_repository.GetEmployees());
        }

        [HttpPost]
        public ActionResult Search(Employee emp)
        {
            if (emp.Name == null)
            {
                return PartialView("_searchEmployees", _repository.GetEmployees());
            }
            else
            {
                return PartialView("_searchEmployees",
                                    _repository.GetEmployees()
                                    .Where(e => e.Name.ToLower()
                                    .Contains(emp.Name.ToLower())));
            }
        }

        [HttpGet]
        public ActionResult AutoComplete()
        {
            return View(_repository.GetEmployees());
        }

        [HttpPost]
        public ActionResult AutoComplete(string searchTerm)
        {
            if(String.IsNullOrEmpty(searchTerm))
            {
                return View(_repository.GetEmployees());
            }
            else
            {
                return View(_repository.GetEmployees().Where(e => e.Name.ToLower().Contains(searchTerm.ToLower())));
            }
        }

        public JsonResult GetEmployees(string term)
        {
            List<string> names = _repository.GetEmployees()
                .Where(e => e.Name.ToLower().Contains(term.ToLower())).Select(n => n.Name)
                .ToList();

            return Json(names, JsonRequestBehavior.AllowGet);
        }
    }
}