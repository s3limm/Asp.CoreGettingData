﻿using GettingData.Models;
using Microsoft.AspNetCore.Mvc;

namespace GettingData.Controllers
{
    public class HomeController : Controller
    {
        public string Index(Products products)
        {
            return "Uygulama çalışıyor";
        }
    }
}
