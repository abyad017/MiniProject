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
    public class PelatihanController : Controller
    {
        // GET: Pelatihan
        public ActionResult Index()
        {
            List<VMPelatihan> dtpelatihan = PelatihanRepo.getPelatihan();
            return View(dtpelatihan);
        }
        public ActionResult getdata(long bioid)
        {
            List<VMPelatihan> dtpelatihan = PelatihanRepo.getPelatihan(bioid);
            return View("index", dtpelatihan);
        }

        public ActionResult Create()
        {
            
            ViewBag.Listx_time_period = PelatihanRepo.getdataperiod();
            return PartialView("_Create");
        }

        [HttpPost]

        public ActionResult Create(x_riwayat_pelatihan plt)
        {
            plt.is_delete = false;
            PelatihanRepo.saveAll(plt);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long editid1)
        {
            
            ViewBag.Listx_time_period = PelatihanRepo.getdataperiod();
            x_riwayat_pelatihan dtpelatihan = PelatihanRepo.getDataByID(editid1);
            return PartialView("_Edit", dtpelatihan);
        }

        [HttpPost]
        public ActionResult EditPost(x_riwayat_pelatihan plt)
        {
            
                if (PelatihanRepo.SimpanEdit(plt))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Edit");
                }
            
        }
        [HttpPost]
        public ActionResult Delete(long delid1)
        {


            if (PelatihanRepo.Delete(delid1))
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





