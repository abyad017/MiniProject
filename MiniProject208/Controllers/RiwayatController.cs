using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.MiniProject208;
using Repo.MiniProject208;

namespace MiniProject208.Controllers
{
    public class RiwayatController : Controller
    {
        // GET: Riwayat
        public ActionResult Index()
        {
            List<x_riwayat_pekerjaan> prj = RiwayatRepo.getAll();
            return View(prj);
        }

        public ActionResult Create()
        {
            ViewBag.join_month = RiwayatRepo.getJoinBulan();
            ViewBag.join_year = RiwayatRepo.getJoinTahun();
            ViewBag.resign_month = RiwayatRepo.getResignBulan();
            ViewBag.resign_year = RiwayatRepo.getResignTahun();

            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(x_riwayat_pekerjaan prj)
        {
            prj.is_delete = false;
            RiwayatRepo.saveAll(prj);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long editid)
        {
            ViewBag.join_month = RiwayatRepo.getJoinBulan();
            ViewBag.join_year = RiwayatRepo.getJoinTahun();
            ViewBag.resign_month = RiwayatRepo.getResignBulan();
            ViewBag.resign_year = RiwayatRepo.getResignTahun();
            x_riwayat_pekerjaan prj = RiwayatRepo.getDataByID(editid);
            return PartialView("_Edit", prj);
        }
        [HttpPost]
        public ActionResult EditPost(x_riwayat_pekerjaan prj)
        {
            if (RiwayatRepo.simpanEdit(prj))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("_Edit");
            }
        }

        [HttpPost]
        public ActionResult Delete(long delid)
        {
            if (RiwayatRepo.Delete(delid))
            {
                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);

            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }



    }

}