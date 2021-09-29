using AutoPartsStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Controllers
{
    [Authorize/*(Roles ="Admin")*/]
    public class AdminController : Controller
    {
        PartContext context;
        public AdminController(PartContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Parts.ToList());
        }

        public IActionResult Create(int? id)
        {
            if (id == null)
            {
                return View(new Part());
            }
            else
            {
                var partToEdit = context.Parts.Find(id);
                var part = new Part { };
                part = partToEdit;
                return View(part);
            }

        }

        [HttpPost]
        public IActionResult Create(Part part)
        {
            if (ModelState.IsValid)
            {
                if (part.PartId == 0)
                {
                    context.Parts.Add(part);
                }
                else
                {
                    var partToEdit = context.Parts.Find(part.PartId);
                    partToEdit.Title = part.Title;
                    partToEdit.Quantity = part.Quantity;
                    partToEdit.Price = part.Price;
                }
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(part);
            }
        }

        //[HttpPost]
        //public IActionResult RemoveFeatureLine(int partId, string FeatureName)
        //{
        //    if (FeatureName !=null)
        //    {
        //        var partFind = context.Parts.Find(partId);
        //        List<Feature> newFeatureLsit = JsonConvert.DeserializeObject<List<Feature>>(partFind.Feature);
        //        foreach (var item in newFeatureLsit)
        //        {
        //            if (item.Name == FeatureName)
        //            {
        //                newFeatureLsit.Remove(item);
        //                break;
        //            }
        //        }
        //        var part = new Part { };
        //        part = partFind;
        //        part.VisualFeature = newFeatureLsit;
        //        part.Feature = JsonConvert.SerializeObject(newFeatureLsit);

        //        partFind.Manufacturer = part.Manufacturer;
        //        partFind.Model = part.Model;
        //        partFind.Image = part.Image;
        //        partFind.Price = part.Price;
        //        partFind.Feature = part.Feature;
        //        partFind.VisualFeature = part.VisualFeature;
        //        context.SaveChanges();
        //    }
        //    return RedirectToAction("Create",new { id = partId });
        //}

        //[HttpPost]
        //public IActionResult ChangeFeatureLine(int partId, string featureName, string featureValue, string newFeatureName, string newFeatureValue)
        //{
        //    if (featureName == null)
        //    {
        //        if (newFeatureName != null && newFeatureValue != null)
        //        {
        //            var partFind = context.Parts.Find(partId);
        //            List<Feature> newFeatureLsit = JsonConvert.DeserializeObject<List<Feature>>(partFind.Feature);

        //            newFeatureLsit.Add(new Feature
        //            {
        //                Name = newFeatureName,
        //                Value = newFeatureValue
        //            });

        //            var part = new Part { };
        //            part = partFind;
        //            part.VisualFeature = newFeatureLsit;
        //            part.Feature = JsonConvert.SerializeObject(newFeatureLsit);
        //            partFind.Manufacturer = part.Manufacturer;
        //            partFind.Model = part.Model;
        //            partFind.Image = part.Image;
        //            partFind.Price = part.Price;
        //            partFind.Feature = part.Feature;
        //            partFind.VisualFeature = part.VisualFeature;
        //            context.SaveChanges();
        //        }
        //    }
        //    else
        //    {
        //        if (newFeatureName != null && newFeatureValue != null)
        //        {
        //            var partFind = context.Parts.Find(partId);
        //            List<Feature> newFeatureLsit = JsonConvert.DeserializeObject<List<Feature>>(partFind.Feature);
        //            for (int i = 0; i < newFeatureLsit.Count; i++)
        //            {
        //                if (newFeatureLsit[i].Name == featureName)
        //                {
        //                    newFeatureLsit[i].Name = newFeatureName;
        //                    newFeatureLsit[i].Value = newFeatureValue;
        //                }
        //            }
        //            var part = new Part { };
        //            part = partFind;
        //            part.VisualFeature = newFeatureLsit;
        //            part.Feature = JsonConvert.SerializeObject(newFeatureLsit);

        //            partFind.Manufacturer = part.Manufacturer;
        //            partFind.Model = part.Model;
        //            partFind.Image = part.Image;
        //            partFind.Price = part.Price;
        //            partFind.Feature = part.Feature;
        //            partFind.VisualFeature = part.VisualFeature;
        //            context.SaveChanges();
        //        }
        //    }
        //    return RedirectToAction("Create", new { id = partId });
        //}

        [HttpPost]
        public IActionResult Delete(int partId)
        {
            var partToDelete = context.Parts.Find(partId);
            context.Parts.Remove(partToDelete);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}