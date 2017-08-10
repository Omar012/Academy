using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
using System.Data.Entity;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private EmpDBContext db = new EmpDBContext();
        // GET: Employee a
        public ActionResult Index()
        {
            var employees = from e in db.Employees
                            orderby e.Id
                            select e;

            return View(employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {


                // TODO: Add insert logic here
                //Employee emp = new Employee();
                //emp.Name = collection["Name"];
                //DateTime jDate;
                //DateTime.TryParse(collection["JoiningDate"], out jDate);
                //emp.JoiningDate = jDate;
                //string age = collection["Age"];
                //emp.Age= Int32.Parse(age);
                //empList.Add(emp);
                db.Employees.Add(emp);
                 db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            //List<Employee> empList = GetEmployeeList();
            //var employee = empList.Single(x => x.Id == id);

            var employee = db.Employees.Single(x => x.Id == id);
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                //var employee = empList.Single(x => x.Id == id);
                var employee = db.Employees.Single(x => x.Id == id);
                if (TryUpdateModel(employee))
                {
                    //to do:- database code
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(employee);
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
        public static List<Employee> empList = new List<Employee>()
        {
             
                new Employee
                {
                    Id = 1,
                    Name = "Paco",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 30
                },
                new Employee
                {
                    Id = 2,
                    Name = "Marcial",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 15
                },

                new Employee
                {
                    Id = 3,
                    Name = "Lili",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 40
                }
            };
        public List<Employee> GetEmployeeList()
        {
            return empList;
        }
        
    }
}
