using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["username"] == "123")
                return View();
            else
            {
                Response.Redirect("/Home/Login");
                return Content("");
            }
        }
        [HttpPost]
        public ActionResult Index(int a,int b)
        {
            int c = a + b;
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;
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
        public ActionResult ServerDemo()
        {
            return Content("");
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.LoginViewModel user)
        {
            if (ModelState.IsValid)
            {
                if (user.username == "123" && user.password == "123")
                {
                    Session.Add("username", "123");
                    Response.Redirect("/Home/Index");
                    return Content("");
                }
                else return Content("No");
            }
            else
                return Content("Error");
        }
        public void Log_out()
        {
            Session.Clear();
            Response.Redirect("/Home/Index");
        }
    }
}