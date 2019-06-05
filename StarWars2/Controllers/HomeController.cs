﻿using StarWars2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarWars2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Person(int i)
        {
            Person person = StarWarsDAL.GetPerson(i);
            return View(person);
        }
        public ActionResult Planet(int i)
        {
            Planet planet = StarWarsDAL.GetPlanet(i);
            return View(planet);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}