﻿using Microsoft.AspNetCore.Mvc;

namespace RaythosAerospace.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            
            return View(); 
        
        }

        public IActionResult Registration()
        {

            return View();

        }
    }
}