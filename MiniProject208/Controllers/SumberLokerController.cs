using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repo.MiniProject208;
using Model.MiniProject208;
using ViewModel;
using ViewModel.MiniProject208;
namespace MiniProject208.Controllers
{
    public class SumberLokerController : Controller
    {
        public ActionResult Index()
        {
            List<x_sumber_loker> dtLoker = SumberLokerRepo.getAll();
            return View(dtLoker);
        }


        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(x_sumber_loker loker)
        {
            SumberLokerRepo.saveAll(loker);
            return RedirectToAction("Index");
        }
    }
}