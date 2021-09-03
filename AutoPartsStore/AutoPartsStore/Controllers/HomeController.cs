using AutoPartsStore.Models;
using AutoPartsStore.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Controllers
{
    public class HomeController : Controller
    {
        PartContext partContext;


        public HomeController(PartContext context)
        {
            this.partContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
