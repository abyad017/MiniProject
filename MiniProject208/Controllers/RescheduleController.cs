//using Model.MiniProject208;
//using Repo.MiniProject208;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using ViewModel.MiniProject208;


//namespace MiniProject208.Controllers
//{
//    public class RescheduleController : Controller
//    {
//        public ActionResult Index()
//        {
//            List<VMPelamar> dtPelamar = RescheduleRepo.getAll();
//            return View(dtPelamar);
//        }

//        public ActionResult Create()
//        {
//            ViewBag.ListSchedule = RescheduleRepo.getSchedule();
//            ViewBag.ListBiodata = RescheduleRepo.getBiodata();

//            return PartialView("_Create");
//        }

//        [HttpPost]

//        public ActionResult Create(VMPelamar Plmr)
//        {
//            RescheduleRepo.saveAll(Plmr);
//            return RedirectToAction("Index");
//        }
//        public ActionResult Edit(long id)
//        {
//            ViewBag.ListUndangan = RescheduleRepo.getUndangan();
//            ViewBag.ListDetUndangan = RescheduleRepo.getDetUndangan();
//            ViewBag.ListSchedule = RescheduleRepo.getSchedule();
//            ViewBag.ListBiodata = RescheduleRepo.getBiodata();
//            VMPelamar dataUndangan = RescheduleRepo.getDataByKode(id);

//            String dt = Convert.ToDateTime(dataUndangan.invitation_date).ToString("yyyy-MM-dd");
//            ViewBag.dt = dt;

//            //String dw = Convert.ToDateTime(dataUndangan.time).ToString("HH:mm:ss");
//            //ViewBag.dw = dw;


//            return PartialView("_Create", dataUndangan);

//        }
//        public ActionResult Search(string KeyWord)
//        {
//            List<VMPelamar> dt = RescheduleRepo.Search(KeyWord);
//            if (dt.Count>0)
//            {
//                ViewBag.cari = "Ada";
//            }
//            else
//            {
//                ViewBag.cari = "Loh Kok Ilang?";
//            }
//            return View("Index", dt);
//        }
//    }
//}