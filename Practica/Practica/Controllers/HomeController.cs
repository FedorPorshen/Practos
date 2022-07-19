using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Practica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Practica.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class HomeController : Controller
    {
        MobileContext db;
        public HomeController(MobileContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(db.Players.ToList());
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Video(int? id)
        {
            ViewBag.PlayerId = id;
            if (id == null)
            {
                return RedirectToAction("Index");
            } 
            else if (id == 1)
            {
                Console.WriteLine(ViewBag.PlayerId);
                return View("Video");
            }
            else if (id == 2)
            {
                return View("Video2");
            }
            else
            {
                return View("Video3");
            } 
        }
        [HttpPost]
        public string Video(Order order)
        {
            db.Orders.Add(order);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо, " + order.Name + ", за заказ наших услуг.";
        }
    }
}
