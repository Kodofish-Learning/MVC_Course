using _03.ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03.ModelBinding.Controllers
{
    public class ModelBindingController : Controller
    {
        // GET: ModelBinding
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SimpleModelBinding(string name)
        {
            ViewBag.Name = name;
            return View();
        }

        public ActionResult FormCollection(FormCollection form)
        {
            ViewBag.Name = form["name"];
            ViewBag.Age = form["age"];
            return View();
        }

        public ActionResult PersonModelBinding(Person person)
        {
            return View(person);
        }

    }
}