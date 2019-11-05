//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using Model.MiniProject208;
//using Repo.MiniProject208;


//namespace MiniProject208.Controllers
//{
//    public class SertifikasiController : Controller
//    {

        

//        public ActionResult Index()
//        {
//            List<x_sertifikasi> sertifikasi = SertifikasiRepo.GetData();
//            return View(sertifikasi);
//        }

//        public ActionResult Create()
//        {
//            ViewBag.ListBulan = SertifikasiRepo.GetMonthList();
//            ViewBag.ListTahun = SertifikasiRepo.GetYear();
//            return PartialView("_Create");
//        }

//        [HttpPost]
//        public ActionResult Create(x_sertifikasi keahlian)
//        {
//            SertifikasiRepo.simpan(keahlian);
//            return RedirectToAction("Index");
//        }

//        public ActionResult Edit(Int64 id)
//        {
//            ViewBag.ListBulan = SertifikasiRepo.GetMonthList();
//            ViewBag.ListTahun = SertifikasiRepo.GetYear();
//            x_sertifikasi dk = SertifikasiRepo.getDatabyId(id);
//            return PartialView("_Edit", dk);
//        }

//        [HttpPost]
//        public ActionResult EditPost(x_sertifikasi k)
//        {

//            if (SertifikasiRepo.ubah(k))
//            {
//                return RedirectToAction("Index");
//            }
//            else
//            {
//                return RedirectToAction("Index");
//            }
//        }

//        [HttpPost]
//        public ActionResult hiddenPost(Int64 id)
//        {
//            if (SertifikasiRepo.hapus(id))
//            {
//                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
//            }
//            else
//            {
//                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
//            }
//        }

//        public JsonResult tahun()
//        {
//            return Json(SertifikasiRepo.GetYear(), JsonRequestBehavior.AllowGet);
//        }



//    }
//}