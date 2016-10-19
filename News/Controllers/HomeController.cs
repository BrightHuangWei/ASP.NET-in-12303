using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult NewsList()
        {
            string[] data = new string[] { "中纪委纪录片第二集：“老虎”万庆良谷春立出镜(图)",
                "杜特尔特：执行“南海仲裁”决定或引第三次世界大战",
                "武汉造“防洪神器”亮相 拦水高度可达30米(图)",
                "伊拉克军继续挺进摩苏尔 发现多条IS地道" };
            ViewBag.data = data;
            return View();
        }

    }
}