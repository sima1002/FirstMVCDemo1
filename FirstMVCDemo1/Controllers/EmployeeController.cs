using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstMVCDemo1.Models;
using System.Collections.Generic;
namespace FirstMVCDemo1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {

            List<Employee> e = new List<Employee>()
            {
                new Employee{Id=1,Name="Ojasvi",Salary=45000},
                new Employee{Id=2,Name="Vaibhav",Salary=38000},
                new Employee{Id=3,Name="Dinesh",Salary=39000},
                new Employee{Id=4,Name="Rohini",Salary=34000},
                new Employee{Id=5,Name="Diya",Salary=40000},
            };
            ViewData["Employeelist"] = e;

            ViewBag.Employee = e;
            return View();

            
            return View();
        }
    }
}
