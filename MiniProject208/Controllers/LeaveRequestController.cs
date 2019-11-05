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
    public class LeaveRequestController : Controller
    {
        // GET: LeaveRequest
        public ActionResult Index()
        {
            List<VMLeaveRequest> dtleave = LeaveRequestRepo.getAll();
            return View(dtleave);
        }
        public ActionResult Search(string Key)
        {
            List<x_leave_name> dt = LeaveRequestRepo.Search(Key);
            return View("Index", dt);
        }

        //menampilkan data berdasarkan id
        public ActionResult getdata(long leaveid)
        {
            List<VMLeaveRequest> dtleave = LeaveRequestRepo.getAll(leaveid);
            return View("Index", dtleave);
        }

        public ActionResult Create(string leave_type)
        {
            
            ViewBag.Listx_leave_name = LeaveRequestRepo.getdataleave();
            
            return PartialView("_Create");
        }
        [HttpPost]

        public ActionResult Create(x_leave_request lvr)
        {
            lvr.is_delete = false;
            LeaveRequestRepo.saveAll(lvr);
            return RedirectToAction("Index");
        }
        
        public ActionResult Edit(long editid3)
        {

            ViewBag.Listx_leave_name = LeaveRequestRepo.getdataleave();
            VMLeaveRequest dtleave = LeaveRequestRepo.getDataByID(editid3);
            
            return PartialView("_Edit", dtleave);
        }

        [HttpPost]
        public ActionResult EditPost(x_leave_request lrv)
        {
            if (ModelState.IsValid)
            {
                if (LeaveRequestRepo.SimpanEdit(lrv))
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
        [HttpPost]
        public ActionResult Deleted(long delid3)
        {


            if (LeaveRequestRepo.Deleted(delid3))
            {

                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }

        }
        public JsonResult ListNama()
        {
            string leave_type = "Cuti Khusus";
            return Json(LeaveRequestRepo.getnamacuti(leave_type), JsonRequestBehavior.AllowGet);
        }


    }

}