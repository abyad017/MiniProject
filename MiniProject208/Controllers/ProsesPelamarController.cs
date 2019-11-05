using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repo.MiniProject208;
using ViewModel.MiniProject208;
using Model.MiniProject208;

namespace MiniProject208.Controllers
{
    public class ProsesPelamarController : Controller
    {
        // GET: ProsesPelamar
        public ActionResult Index()
        {
            List<VMPelamar> data = ProsesPelamarRepo.GetData();
            return View(data);
        }

        // Proses Pelamar
        public ActionResult Proses(int Kode)
        {
            if (ProsesPelamarRepo.ProsesData(Kode))
            {
                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        // Tampil Detail Proses Pelamar
        public ActionResult Detail()
        {
            List<VMDetailRencanaJadwal> data = ProsesPelamarRepo.GetDataPenjadwalan();
            //List<VMDetailUndangan> data = ProsesPelamarRepo.GetDataUndangan();
            return View("_Detail", data);
            //return PartialView("_Detail");
        }
    }
}