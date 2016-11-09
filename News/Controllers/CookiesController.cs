using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Controllers
{
    public class CookiesController : Controller
    {
        // GET: Cookies
        public ActionResult Index()
        {
            int count = 1;
            var cookies = Request.Cookies["count"];
            if(cookies == null)
            {
                Response.Cookies.Add(new HttpCookie("count","1"));
            }
            else
            {
                count = int.Parse(cookies.Value) + 1;
                var newcookies = new HttpCookie("count",count.ToString());
                newcookies.Expires = DateTime.Now.AddMinutes(20);
                Response.Cookies.Add(newcookies);
            }
            ViewBag.count = count;
            return View();
        }
    }
}