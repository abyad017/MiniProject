using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repo.MiniProject208;
using Model.MiniProject208;
using ViewModel.MiniProject208;
//using MiniProject208.Models;

namespace MiniProject208.Controllers
{
    public class ReligionController : Controller
    {
        // GET: Religion
        public ActionResult Index()
        {
            List<VMReligion> data = ReligionRepo.GetData();
            return View(data);
        }

        // Tampil Form Input Religion
        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        // Simpan Data Religion
        [HttpPost]
        public ActionResult Create(x_religion data)
        {
            ReligionRepo.CreateData(data);
            return RedirectToAction("Index");
        }

        // Delete Data Religion
        public ActionResult Delete(int Kode)
        {
            if (ReligionRepo.DeleteData(Kode))
            {
                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        // Edit Data Religion
        public ActionResult Edit(Int64 Kode)
        {
            x_religion data = ReligionRepo.GetDataById(Kode);
            return PartialView("_Edit", data);
        }

        // Edit Data Religion (Post)
        [HttpPost]
        public ActionResult EditPost(x_religion data)
        {

            if (ReligionRepo.EditData(data))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        // Cari Data Religion
        public ActionResult Search(string cari)
        {
            List<VMReligion> list = ReligionRepo.SearchData(cari);
            return View("Index", list);
        }

        // Order Data By Asc
        public ActionResult OrderDataByAsc()
        {
            List<VMReligion> list = ReligionRepo.OrderByAsc();
            return View("Index", list);
        }

        // Order Data By Desc
        public ActionResult OrderDataByDesc()
        {
            List<VMReligion> list = ReligionRepo.OrderByDesc();
            return View("Index", list);
        }

        // Row Per Page
        public ActionResult RowPerPage(int row)
        {
            List<VMReligion> list = ReligionRepo.Row(row);
            return View("Index", list);
        }
    }
}