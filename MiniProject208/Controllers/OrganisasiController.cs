using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.MiniProject208;
using Repo.MiniProject208;
using ViewModel.MiniProject208;

namespace MiniProject208.Controllers
{
    public class OrganisasiController : Controller
    {
        // GET: Organisasi
        public ActionResult Index()
        {
            List<x_organisasi> dtorganisasi = OrganisasiRepo.getAll();
            return View(dtorganisasi);
        }
        public ActionResult getdata(long bioid)
        {
            List<x_organisasi> dtorganisasi = OrganisasiRepo.getAll(bioid);
            return View("index", dtorganisasi);
        }
        public ActionResult Create()
        {
            
            return PartialView("_Create");
        }

        [HttpPost]

        public ActionResult Create(x_organisasi org)
        {
            org.is_deleted = false;
            OrganisasiRepo.saveAll(org);
            return RedirectToAction("Index");
        }


        public ActionResult Edit(long editid)
        {
            
            x_organisasi dtorganisasi = OrganisasiRepo.getDataByID(editid);
            return PartialView("_Edit", dtorganisasi);
        }

        [HttpPost]
        public ActionResult EditPost(x_organisasi org)
        {

            if (ModelState.IsValid)
            {
                if (OrganisasiRepo.SimpanEdit(org))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Edit");
                }
            }
            return RedirectToAction("Index");

        }
        //public ActionResult Deleteget(long delid)
        //{
        //    x_organisasi dtorganisasi = OrganisasiRepo.getDataByID(delid);
        //    return PartialView("_Delete", dtorganisasi);
        //}
        [HttpPost]
        public ActionResult Delete(long delid)
        {


            if (OrganisasiRepo.Delete(delid))
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