using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using PhanQuyenAuthenAuthor.Filter;
namespace PhanQuyenAuthenAuthor.Controllers
{
    public class HomeController : Controller
    {
        [MyAuthen]
        public ActionResult Index()
        {
            return View();
        }
        [MyAuthorization]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [MyAuthen]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}