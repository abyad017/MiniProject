using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.MiniProject208;
using System.Data.Entity;
using Repo.MiniProject208;
using ViewModel.MiniProject208;

namespace MiniProject208.Controllers
{
    public class TimeSheetSubmitController : Controller
    {
        // GET: TimeSheetSubmit
        public ActionResult Index()
        {
            ViewBag.data = TimeSheetSubmitRepo.getDdata();
            return View();
        }
        public ActionResult Search(int tahun, int bulan )
        {
            List<VMTimesheet> data = TimeSheetSubmitRepo.SearchData(tahun,bulan);
            if(data.Count > 0)
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
        public ActionResult Submtited()
        {
            ViewBag.data = TimeSheetSubmitRepo.getDdata();
            return View();
        }
    }
}