using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkında()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    
        public ActionResult KullanıcıGirisi()
        {

            return View();
        }

        public ActionResult Randevu()
        {

            return View();
        }

        public ActionResult BizeUlasın()
        {

            return View();
        }

        public ActionResult BizeUlas()
        {

            return View();
        }

        public ActionResult Doktorlar()
        {

            return View();
        }

        public ActionResult RandevuAl()
        {

            return View();
        }
    }
}