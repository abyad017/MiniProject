using Model.MiniProject208;
using Repo.MiniProject208;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.MiniProject208;

namespace MiniProject208.Controllers
{
    public class UndanganController : Controller
    {
        public ActionResult Index()
        {
            List<VMPelamar> dtPelamar = UndanganRepo.getAll();
            return View(dtPelamar);
        }

        public ActionResult Create()
        {
            ViewBag.ListSchedule = UndanganRepo.getSchedule();
            ViewBag.ListBiodata = UndanganRepo.getBiodata();

            return PartialView("_Create");
        }

        [HttpPost]

        public ActionResult Create(VMPelamar Plmr)
        {
            UndanganRepo.saveAll(Plmr);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            ViewBag.ListUndangan = UndanganRepo.getUndangan();
            ViewBag.ListDetUndangan = UndanganRepo.getDetUndangan();
            ViewBag.ListSchedule = UndanganRepo.getSchedule();
            ViewBag.ListBiodata = UndanganRepo.getBiodata();
            VMPelamar dataUndangan = UndanganRepo.getDataByKode(id);

            String dt = Convert.ToDateTime(dataUndangan.invitation_date).ToString("yyyy-MM-dd");
            ViewBag.dt = dt;

            //ViewBag.ListKota = PegawaiRepo.getKota(dataPegawai.Kode_Provinsi);
            //ViewBag.ListKecamatan = PegawaiRepo.getKecamatan(dataPegawai.Kode_Kota);
            //ViewBag.ListKelurahan = PegawaiRepo.getKelurahan(dataPegawai.Kode_Kecamatan);
            return PartialView("_Edit", dataUndangan);

        }

        [HttpPost]
        public ActionResult EditPost(VMPelamar udg)
        {


            if (UndanganRepo.SimpanEdit(udg))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit");
            }

        }

        public ActionResult Detail(long id)
        {
            VMPelamar detailv = UndanganRepo.getDetail(id);
            return PartialView("_Detail", detailv);
        }

        public ActionResult Search(string KeyWord)
        {
            List<VMPelamar> dt = UndanganRepo.Search(KeyWord);
            return View("Index", dt);
        }
    }
}