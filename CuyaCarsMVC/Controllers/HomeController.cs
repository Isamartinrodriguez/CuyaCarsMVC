using CuyaCarsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuyaCarsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Coche()
        {
            
            Coche elcoche = new Coche();
            elcoche.Matricula = "12345";
            ViewBag.Coche = elcoche ;
            return View("Coche", elcoche);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}