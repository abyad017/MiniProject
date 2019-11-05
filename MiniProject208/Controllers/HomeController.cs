using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repo.MiniProject208;
using ViewModel.MiniProject208;

namespace MiniProject208.Controllers
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
        public ActionResult Index2(long role)
        {
            Session["role"] = role;
            return View("Index");
        }

        public ActionResult Access()
        {
            Session["id"] = 1;
            long id = Convert.ToInt64(Session["id"]);
            List<VMAccess> data = AccessMenuRepo.getRole(id);
            return View("Access", data);
        }


        public static List<VMAccess> getAccess()
        {
            long ids = Convert.ToInt64(System.Web.HttpContext.Current.Session["id"]);
            long role = Convert.ToInt64(System.Web.HttpContext.Current.Session["role"]);
            
            List<VMAccess> data = AccessMenuRepo.getAccess(ids, role);
            return data;
        }

        public ActionResult changeAccess(long role)
        {
            System.Web.HttpContext.Current.Session["role"] = role;
            return RedirectToAction("Index", "Home");
        }

    }
}