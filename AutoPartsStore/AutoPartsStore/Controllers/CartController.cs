using ASP_DZ.Models;
using AutoPartsStore.Extensions;
using AutoPartsStore.Models;
using AutoPartsStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            Part Part = context.Parts.FirstOrDefault(x => x.PartId == partId);
            if (Part != null)
            {
                var cart = GetCart();
                cart.AddItem(Part, 1);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult ClearCart(string returnUrl)
        {
            var cart = GetCart();
            cart.Clear();
            HttpContext.Session.SetObjectAsJson("Cart", cart);
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult AddQuantity(int partId, string returnUrl)
        {
            Part Part = context.Parts.FirstOrDefault(x => x.PartId == partId);
            if (Part != null)
            {
                var cart = GetCart();
                cart.AddItem(Part, 1);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult ReduceQuantity(int partId, string returnUrl)
        {
            Part Part = context.Parts.FirstOrDefault(x => x.PartId == partId);
            if (Part != null)
            {
                var cart = GetCart();
                cart.RemoveItem(Part, 1);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult RemoveFromCart(int partId, string returnUrl)
        {
            Part Part = context.Parts.FirstOrDefault(x => x.PartId == partId);
            if (Part != null)
            {
                var cart = GetCart();
                cart.RemoveLine(Part);
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

        public IActionResult MakeOrder()
        {
            var cart = GetCart();
            if (!cart.IsEmpty())
            {
                string x = JsonConvert.SerializeObject(cart);
                return View(new Order
                {
                    Cart = JsonConvert.SerializeObject(cart),
                    VisualCart = cart
                });
            }
            return RedirectToAction("Index", "Cart");
        }


        public IActionResult ConfirmOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                context.Orders.Add(order);
                context.SaveChanges();

                ClearCart("/Home/Index");


                try
                {
                    MailAddress from = new MailAddress("vsmirnov116@gmail.com", "Part Shop");
                    MailAddress to = new MailAddress($"{order.Email}");
                    MailMessage m = new MailMessage(from, to);
                    m.Subject = "Спасибо за покупку";
                    m.Body = "<h4>Добрый день, запсибо за покупку в нашем магазине</h4>";
                    m.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential("vsmirnov116@gmail.com", "rxjtladqnkbrazod");
                    smtp.EnableSsl = true;
                    smtp.Send(m);


                }
                catch (Exception e)
                {

                }

                return RedirectToAction("Index", "Home", new { thx = true });
            }
            else
            {
                var cart = GetCart();
                order.VisualCart = cart;
                return View("MakeOrder", order);
            }
        }
    }
}
