using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult PostLogin(string username,string password)
        {
            if (username =="abc" && password =="123")
            {
                var cookie = new HttpCookie("isAuth", "true");
                Response.Cookies.Add(cookie);
                return RedirectToAction("AddArticle","Blog");
            }
            return View();
        }
    }
}