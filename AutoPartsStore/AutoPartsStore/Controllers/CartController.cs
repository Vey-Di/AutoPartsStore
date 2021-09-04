using AutoPartsStore.Extensions;
using AutoPartsStore.Models;
using AutoPartsStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Controllers
{
    public class CartController : Controller
    {
        PartContext context;
        public CartController(PartContext context)
        {
            this.context = context;
        }
        public IActionResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }

        public IActionResult AddToCart(int partId, string returnUrl)
        {
            Part part = context.Parts.FirstOrDefault(x => x.PartId == partId);
            if (part != null)
            {
                var cart = GetCart();
                cart.AddItem(part, 1);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult RemoveFromCart(int partId, string returnUrl)
        {
            Part part = context.Parts.FirstOrDefault(x => x.PartId == partId);
            if (part != null)
            {
                var cart = GetCart();
                cart.RemoveLine(part);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }

            return RedirectToAction("Index", new { returnUrl });
        }
        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetObjectFromJson<Cart>("Cart");
            if (cart == null)
            {
                cart = new Cart();
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return cart;
        }
    }
}
