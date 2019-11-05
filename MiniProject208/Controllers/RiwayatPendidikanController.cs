//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using Model.MiniProject208;
//using Repo.MiniProject208;
//using ViewModel;
//using ViewModel.MiniProject208;

//namespace MiniProject208.Controllers
//{
//    public class RiwayatPendidikanController : Controller
//    {
//        public ActionResult index()
//        {
//            List<VM_Riwayat_Pendidikan> riwayatpendidikan = RiwayatPendidikanRepo.getAll();
//            return View(riwayatpendidikan);
//        }

//        public ActionResult getdata(long biodataid)
//        {
//            List<VM_Riwayat_Pendidikan> riwayatpendidikan = RiwayatPendidikanRepo.getAll(biodataid);
//            return View("index", riwayatpendidikan);
//        }

//        public ActionResult Create()
//        {
//            ViewBag.lsteducationlevel = RiwayatPendidikanRepo.geteducationlevel();
//            //ViewBag.ListBulan = RiwayatPendidikanRepo.GetMonthList();
//            ViewBag.ListTahun = RiwayatPendidikanRepo.GetYear();
//            return PartialView("_Create");
//        }

//        [HttpPost]
//        public ActionResult Create(x_riwayat_pendidikan riwayatpendidikan)
//        {

//            RiwayatPendidikanRepo.saveAll(riwayatpendidikan);
//            return RedirectToAction("Index");
//        }

//        public ActionResult Edit(long id)
//        {

//            ViewBag.ListTahun = RiwayatPendidikanRepo.GetYear();
//            ViewBag.lsteducationlevel = RiwayatPendidikanRepo.geteducationlevel();
//            x_riwayat_pendidikan dk = RiwayatPendidikanRepo.getDatabyId(id);
//            return PartialView("_Edit", dk);
//        }

//        [HttpPost]
//        public ActionResult EditPost(x_riwayat_pendidikan k)
//        {

//            if (RiwayatPendidikanRepo.SimpanEdit(k))
//            {
//                return RedirectToAction("Index");
//            }
//            else
//            {
//                return RedirectToAction("Index");
//            }
//        }

//        [HttpPost]
//        public ActionResult hiddenPost(long id)
//        {
//            if (RiwayatPendidikanRepo.hapus(id))
//            {
//                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
//            }
//            else
//            {
//                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
//            }
//        }

//        //public ActionResult filter(long id)
//        //{

//        //    x_riwayat_pendidikan dk = RiwayatPendidikanRepo.getDatabyId(id);
//        //    int aa1 = int.Parse(dk.entry_year);
//        //    int aa2 = int.Parse(dk.gradution_year);
//        //    if (aa1 >= aa2)
//        //    {
//        //        ViewBag.ListTahun = RiwayatPendidikanRepo.GetYear();
//        //        ViewBag.lsteducationlevel = RiwayatPendidikanRepo.geteducationlevel();
//        //        return PartialView("_Edit", dk);
//        //    } else
//        //    {

//        //    }

//            //ViewBag.ListTahun = RiwayatPendidikanRepo.GetYear();
//            //ViewBag.lsteducationlevel = RiwayatPendidikanRepo.geteducationlevel();
//            //return PartialView("_Edit", dk);
//        //}

//    }
//}