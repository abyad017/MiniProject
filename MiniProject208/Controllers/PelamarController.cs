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
    public class PelamarController : Controller
    {
        // GET: Pelamar
        public ActionResult Index()
        {
            List<VMPelamar> data = PelamarRepo.GetData();
            return View(data);
        }

        // Tampil Form Input Pelamar

        public ActionResult Create()
        {
            ViewBag.ListReligion = PelamarRepo.GetReligion();
            ViewBag.ListIdentity = PelamarRepo.GetIdentity();
            ViewBag.ListMarital = PelamarRepo.GetMarital();
            return PartialView("_Create");
        }

        //Simpan Data Pelamar
        [HttpPost]
        public ActionResult Create(VMPelamar data)
        {
            List<string> list = new List<string>();
            if (ModelState.IsValid)
            {
                if (PelamarRepo.CheckExistEmail(data.email))
                {
                    list.Add("emailExist");
                }

                if (PelamarRepo.CheckExistNoHP(data.phone_number1))
                {
                    list.Add("nohpExist");
                }

                if (list.Count != 0)
                {
                    return Json(new { saveAll = list }, JsonRequestBehavior.AllowGet);
                }

                if (PelamarRepo.CreateData(data))
                {
                    return Json(new { saveAll = "Berhasil" }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { saveAll = "Gagal" }, JsonRequestBehavior.AllowGet);
        }

        // Cari Data Pelamar
        public ActionResult Search(string cari)
        {
            List<VMPelamar> data = PelamarRepo.SearchData(cari);
            return View("Index", data);
        }

        // Tampil Detail Pelamar
        public ActionResult Detail()
        {
            return PartialView("_Detail");
        }

        // GET: Pelamar Catatan
        public ActionResult Catatan(string Kode)
        {
            long Kd = Convert.ToInt64(Kode);
            List<VMCatatan> data = CatatanRepo.GetData(Kd);
            return PartialView("_Catatan", data);
        }

        // Tampil Form Input Catatan
        public ActionResult CatatanCreate()
        {
            ViewBag.ListNoteType = CatatanRepo.GetNoteType();
            return PartialView("_CatatanCreate");
        }

        // Simpan Data Catatan
        [HttpPost]
        public ActionResult CatatanCreate(x_catatan data)
        {
            long id = Convert.ToInt64(Session["id"]);
            data.created_by = id;

            if (ModelState.IsValid)
            {
                if (CatatanRepo.CreateData(data, id))
                {
                    return Json(new { Simpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
                }

            }
            return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
        }

        // Delete Data Catatan
        public ActionResult CatatanDelete(int Kode)
        {
            if (CatatanRepo.DeleteData(Kode))
            {
                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        // Edit Data Catatan
        public ActionResult CatatanEdit(Int64 Kode)
        {
            ViewBag.ListNoteType = CatatanRepo.GetNoteType();
            x_catatan data = CatatanRepo.GetDataById(Kode);
            return PartialView("_CatatanEdit", data);
        }

        // Edit Data Catatan (Post)
        [HttpPost]
        public ActionResult CatatanEditPost(x_catatan data)
        {
            long sid = Convert.ToInt64(Session["id"]);
            data.modified_by = sid;

            if (ModelState.IsValid)
            {
                if (CatatanRepo.EditData(data))
                {
                    return Json(new { Simpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
                }

            }
            return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
        }
    }
}