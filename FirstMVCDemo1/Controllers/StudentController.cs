using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstMVCDemo1.Models;
using System.Collections.Generic;

namespace FirstMVCDemo1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudList()
        {
            List<Student> s = new List<Student>()
            {
                new Student{RollNo=101,Name="Riya",Percentage=89},
                new Student {RollNo=102,Name="Amita",Percentage=78},
                new Student {RollNo=103,Name="Sarvesh",Percentage=92},
                new Student {RollNo=104,Name="Meera",Percentage=90},
                new Student {RollNo=105,Name="Nitin",Percentage=84},
            };
            ViewData["StudList"] = s;

            ViewBag.Student = s;
            return View();

            return View();
        }
    }
}
