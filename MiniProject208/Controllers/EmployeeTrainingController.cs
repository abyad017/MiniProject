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
//    public class EmployeeTrainingController : Controller
//    {
//        public ActionResult Index()
//        {
//            ViewBag.lsttraining = EmployeeTrainingRepo.gettraining();
//            List<VMEmployeeTraining> employee_training = EmployeeTrainingRepo.getAll();
//            return View(employee_training);
//        }

//        public ActionResult Create()
//        {
//            ViewBag.lstbiodata = EmployeeTrainingRepo.getbiodata();
//            ViewBag.lsttraining = EmployeeTrainingRepo.gettraining();
//            ViewBag.lsttrainingorganizer = EmployeeTrainingRepo.gettrainingorganizer();
//            ViewBag.lsttrainingtype = EmployeeTrainingRepo.gettrainingtype();
//            ViewBag.lstcertificationtype = EmployeeTrainingRepo.getcertificationtype();
//            return PartialView("_Create");
//        }

//        [HttpPost]
//        public ActionResult Create(x_employee_training emtraining)
//        {
//            EmployeeTrainingRepo.saveAll(emtraining);
//            return RedirectToAction("Index");
//        }

//        public ActionResult Edit(long id)
//        {
//            ViewBag.lstbiodata = EmployeeTrainingRepo.getbiodata();
//            ViewBag.lsttraining = EmployeeTrainingRepo.gettraining();
//            ViewBag.lsttrainingorganizer = EmployeeTrainingRepo.gettrainingorganizer();
//            ViewBag.lsttrainingtype = EmployeeTrainingRepo.gettrainingtype();
//            ViewBag.lstcertificationtype = EmployeeTrainingRepo.getcertificationtype();
//            x_employee_training dk = EmployeeTrainingRepo.getDatabyId(id);
//            String dt = Convert.ToDateTime(dk.training_date).ToString("yyyy-MM-dd");
//            ViewBag.dt = dt;
//            return PartialView("_Edit", dk);
//        }

//        [HttpPost]
//        public ActionResult EditPost(x_employee_training k)
//        {

//            if (EmployeeTrainingRepo.Edit(k))
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
//            if (EmployeeTrainingRepo.hapus(id))
//            {
//                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
//            }
//            else
//            {
//                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
//            }
//        }

//        [HttpPost]
//        public ActionResult hiddenPost2(long id)
//        {
//            if (EmployeeTrainingRepo.hapus2(id))
//            {
//                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
//            }
//            else
//            {
//                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
//            }
//        }

//        [HttpPost]
//        public ActionResult hiddenPost3(long id)
//        {
//            if (EmployeeTrainingRepo.hapus3(id))
//            {
//                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
//            }
//            else
//            {
//                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
//            }
//        }

//        [HttpPost]
//        public ActionResult hiddenPost4(long id)
//        {
//            if (EmployeeTrainingRepo.hapus4(id))
//            {
//                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
//            }
//            else
//            {
//                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
//            }
//        }


//    }
//  }