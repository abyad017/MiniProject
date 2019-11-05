using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repo.MiniProject208;
using Model.MiniProject208;
using ViewModel.MiniProject208;

namespace MiniProject208.Controllers
{
    public class SendTSController : Controller
    {
        // GET: SendTS
        public ActionResult Index()
        {
            ViewBag.data = SendTSRepo.getData();
            return View();
        }
        public ActionResult Search(int tahun, int bulan)
        {
            List<VMTimesheet> data = SendTSRepo.searchData(tahun, bulan);
            if (data.Count > 0)
            {
                ViewBag.data = data;
                ViewBag.load = "loaded";

            }
            else
            {
                ViewBag.data = data;
                ViewBag.load = "empty";
            }

            return View("Index");
        }

        public ActionResult Email()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmailView()
        {
            return View();
        }
    }
}