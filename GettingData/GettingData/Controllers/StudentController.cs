using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>()
        {
            new Student(){FirstName="Yavuz" , LastName="Emrem"},
            new Student(){FirstName="İnci" ,  LastName="Emrem"},
            new Student(){FirstName="Kayra" , LastName="Şahin"},
            new Student(){FirstName="Murat" , LastName="Çiçekçi"},
        };
        public IActionResult ListStudent()
        {
            return View(students);
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            students.Add(student);
            return View("ListStudent",students);
        }
    }
}
