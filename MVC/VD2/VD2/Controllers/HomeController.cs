using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VD2.Models;

namespace VD2.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDbContext _dbContext;
        public HomeController(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var _employees = _dbContext.Employees.Select(e => new EmployeeViewModel()
            {
                EmployeeId = e.EmployeeId,
                Name = e.Name,
                Address =e.Address,
                CompanyName = e.CompanyName,
                Designation = e.Designation,
                Salary = e.Salary

            }).ToList();
            return View(_employees);                
            
        }
        public IActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeCreateModel model)
        {
            var employee = new Employee()
            {
               EmployeeId = model.EmployeeId,
               Name = model.Name,
               Address =model.Address,
               CompanyName = model.CompanyName,
               Designation = model.Designation,
               Salary = model.Salary
            };
            _dbContext.Employees.Add(employee);
            if (_dbContext.SaveChanges() > 0)
            {
                TempData["Message"] = "Employee has been added successfully.";
            }
            else
            {
                TempData["Message"] = "Something went wrong, please contact administrator.";
            }
           
            return View(new EmployeeCreateModel());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = _dbContext.Employees.Find(id);
            _dbContext.Remove(employee);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var _employees = _dbContext.Employees.Select(e => new EmployeeViewModel()
            {
                EmployeeId = e.EmployeeId,
                Name = e.Name,
                Address = e.Address,
                CompanyName = e.CompanyName,
                Designation = e.Designation,
                Salary = e.Salary
            }).Where(e => e.EmployeeId == id).FirstOrDefault();
            return View(_employees);          
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var _employees = _dbContext.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
            var employeeEdit = new EmployeeEditModel()
            {
                EmployeeId = _employees.EmployeeId,
                Name = _employees.Name,
                Address = _employees.Address,
                CompanyName = _employees.CompanyName,
                Designation = _employees.Designation,
                Salary = _employees.Salary
            };
           
            return View(employeeEdit);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeEditModel model)
        {
            var employee = _dbContext.Employees.Find(model.EmployeeId);
            employee.Name = model.Name;
            employee.Address = model.Address;
            employee.CompanyName = model.CompanyName;
            employee.Designation = model.Designation;
            employee.Salary = model.Salary;
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
