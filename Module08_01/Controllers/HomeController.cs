using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module08_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //Get:Home/HelloWorld
        //PartialView不能使用layout
        public ActionResult HelloWorld()
        {
            ViewBag.message = "HelloWorld:"+ DateTime.Now.ToString();
            return PartialView();
        }

        public ActionResult HelloWorld2(string username)
        {
            ViewBag.message = "HelloWorld:" + username + ", " + DateTime.Now.ToString();
            return PartialView("HelloWorld");
        }

    }
}