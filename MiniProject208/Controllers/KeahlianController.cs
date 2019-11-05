using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repo.MiniProject208;
using Model.MiniProject208;
using ViewModel;
using ViewModel.MiniProject208;

namespace MiniProject.Controllers
{

    public class KeahlianController : Controller
    {
        // Get Keahlian
        public ActionResult Index()
        {
            List<VMKeahlian> keahlian = KeahlianRepo.getAll();
            return PartialView("_Index", keahlian);
        }

        // Tampil Form Input Keahlian
        public ActionResult Create()
        {
            ViewBag.lstKeahlian = KeahlianRepo.getLevel();
            return PartialView("_Create");
        }

        // Simpan Data Keahlian
        [HttpPost]
        public ActionResult Create(x_keahlian keahlian)
        {
            KeahlianRepo.saveAll(keahlian);
            return RedirectToAction("Index");
        }

        //
        public ActionResult Edit(Int64 id)
        {
            ViewBag.lstKeahlian = KeahlianRepo.getLevel();
            x_keahlian dk = KeahlianRepo.getDatabyId(id);
            return PartialView("_Edit", dk);
        }

        //
        [HttpPost]
        public ActionResult EditPost(x_keahlian k)
        {

            if (KeahlianRepo.SimpanEdit(k))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        //
        [HttpPost]
        public ActionResult hiddenPost(Int64 id)
        {
            if (KeahlianRepo.hapus(id))
            {
                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        //
        public ActionResult getData(String cari2)
        {
            List<VMKeahlian> Keahlian = KeahlianRepo.getAll(cari2);
            return View("Index", Keahlian);
        }
    }
}