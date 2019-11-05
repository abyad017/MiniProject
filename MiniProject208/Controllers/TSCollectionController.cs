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
    public class TSCollectionController : Controller
    {
        // GET: TSCollection
        public ActionResult Index()
        {
            ViewBag.nama = TSCollectionRepo.getNamaPgw();
            ViewBag.client = TSCollectionRepo.getClient();
            ViewBag.data = TSCollectionRepo.getData();
            return View();
        }
        public ActionResult Search(int tahun, int bulan, string namaPgw, string client)
        {
            List<VMTimesheet> data = TSCollectionRepo.searchData(tahun, bulan, namaPgw, client);
            if (data.Count > 0)
            {
                ViewBag.nama = TSCollectionRepo.getNamaPgw();
                ViewBag.client = TSCollectionRepo.getClient();
                ViewBag.data = data;
                ViewBag.load = "loaded";

            }
            else
            {
                ViewBag.nama = TSCollectionRepo.getNamaPgw();
                ViewBag.client = TSCollectionRepo.getClient();
                ViewBag.data = data;
                ViewBag.load = "empty";
            }

            return View("Index");
        }
    }
}