using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServic3w;
namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        IBizService _ibizSvc;
        public HomeController(IBizService ibizSvc)
        {
            _ibizSvc = ibizSvc;
        }
        public ActionResult Index()
        {
            ViewBag.Message = _ibizSvc.ShowMessage();
       
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Message = _ibizSvc.ShowMessage();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}