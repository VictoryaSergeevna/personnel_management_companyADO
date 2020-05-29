using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       

        public HomeController()
        {
           
        }

        public ActionResult Index()
        {
            //IEnumerable<Person> people = db.GetAll();
            return View(/*people*/);
        }
    }
}