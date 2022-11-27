using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    
    public class UserController : Controller
    {
        List<User> users = new List<User>()
        { 
        new User(){userName="Yavuz", passWord="123"},
        new User(){userName="Faruk", passWord="1234"},
        new User(){userName="Kayra", passWord="12345"},
        new User(){userName="Fatih", passWord="selim"},
        new User(){userName="Yasin", passWord="1441"},
        };

        public IActionResult ListUsers()
        {
            return View(users);
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            users.Add(user);
            return View("ListUsers",users);
        }

    }
    
}
