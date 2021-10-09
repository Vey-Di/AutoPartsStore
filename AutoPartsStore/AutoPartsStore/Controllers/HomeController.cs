using AutoPartsStore.Models;
using AutoPartsStore.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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

        public IActionResult PartsList (string search="")
        {
            List<Part> parts = partContext.Parts.ToList();

            if (!string.IsNullOrEmpty(search))
            {
                parts = parts.Where(x => x.Title.ToLower().Contains(search.ToLower())).ToList();
            }

            return PartialView(new PartListViewModel {
                Parts = parts
            });
        }

        public IActionResult PartShow(int? partId)
        {
            var part = partContext.Parts.Find(partId);

            List<Feature> featureList = null;

            if (part.Feature != null)
            {
                featureList = JsonConvert.DeserializeObject<List<Feature>>(part.Feature);
            }

            var partToShow = new PartShowViewModel
            {
                PartId = part.PartId,
                Title = part.Title,
                Image = part.Image,
                Price = part.Price,
                Feature = featureList
            };
            return View(partToShow);
        }
    }
}
