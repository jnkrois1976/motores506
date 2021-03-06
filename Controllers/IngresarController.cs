﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Motores506.Models;

namespace Motores506.Controllers
{
    public class IngresarController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Message for login page.";
            return View();
        }

        [Route("Ingresar/Recuperar")]
        public IActionResult ForgotPassword()
        {
            ViewData["Message"] = "Message for forgot password page.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}