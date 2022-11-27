using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class TeacherController : Controller
    {
        List<Branches> branches= new List<Branches>()
        { 
        new Branches() {ID=1,BranchName="Matematik"},
        new Branches() {ID=2,BranchName="Edebiyat"},
        new Branches() {ID=3,BranchName="Tarih"},
        new Branches() {ID=4,BranchName="Coğrafya"},
        };

        public IActionResult AddTeacher()
        {
            ViewBag.Branches = branches;
            return View();
        }

        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            ViewBag.Branches = branches;
            return View();
        }
    }
}
