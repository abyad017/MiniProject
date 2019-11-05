using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.MiniProject208;
using System.Data.Entity;
using Repo.MiniProject208;
using ViewModel.MiniProject208;

namespace MiniProject208.Controllers
{
    public class TimeSheetController : Controller
    {
        // GET: TimeSheet
        string[] status = { "Masuk", "Cuti", "Sakit", "Libur", "Alpha" };
        string[] overtime = { "true", "false" };
        public ActionResult Index()
        {
            List<VMTimesheet> data = TimeSheetRepo.getData();
            return View(data);
        }

        public ActionResult Create()
        {
            
            ViewBag.status = status;
            ViewBag.overtime = overtime;
            ViewBag.client = TimeSheetRepo.getClient();
            return PartialView("_Create");
        }
        [HttpPost]
        public ActionResult CreatePost(x_timesheet data)
        {
            long ids = Convert.ToInt64(Session["id"]);
            DateTime date = DateTime.Now;
            data.created_by = ids;
            data.created_on = date;
            data.is_delete = false;
            data.submitted_on = date;
            TimeSheetRepo.Save(data);
            return RedirectToAction("Index");
        }
        public ActionResult EditGet(long id)
        {
            
            ViewBag.status = status;
            ViewBag.overtime = overtime;
            ViewBag.client = TimeSheetRepo.getClient();
            ViewBag.timesheet = TimeSheetRepo.getDataEdit(id);
            DateTime date = ViewBag.timesheet.timesheet_date;
            string str = date.ToString("yyyy-MM-dd");
            ViewBag.date = str;
            if (ViewBag.timesheet.overtime == true)
            {
                ViewBag.x = "Ya";
                ViewBag.y = "true";
                ViewBag.z = "false";
            }
            else
            {
                ViewBag.x = "Tidak";
                ViewBag.y = "false";
                ViewBag.z = "true";
            }
            return PartialView("_Edit");
        }
        [HttpPost]
        public ActionResult EditPost(x_timesheet timesheet)
        {
            long id = Convert.ToInt64(Session["id"]);
            DateTime date = DateTime.Now;
            timesheet.modified_by = id;
            timesheet.modified_on = date;
            TimeSheetRepo.Update(timesheet);
            return RedirectToAction("Index");
        }

        public ActionResult DetailGet(long id)
        {     
            ViewBag.client = TimeSheetRepo.getDetail(id);
            if (ViewBag.client.overtime == true)
            {
                ViewBag.x = "Ya";               
            }
            else
            {
                ViewBag.x = "Tidak";              
            }
            return PartialView("_Detail");
        }

        public ActionResult DeleteGet(long id)
        {
            ViewBag.timesheet = TimeSheetRepo.getDetail(id);
            DateTime date = ViewBag.timesheet.timesheet_date;
            string str = date.ToString("dd MMMM yyyy");
            ViewBag.date = str;
            return PartialView("_Delete");
        }
        public ActionResult DeletePost(x_timesheet timesheet)
        {
            long id = Convert.ToInt64(Session["id"]);
            DateTime date = DateTime.Now;
            timesheet.deleted_by = id;
            timesheet.deleted_on = date;
            timesheet.is_delete = true;
            TimeSheetRepo.Update(timesheet);
            return RedirectToAction("Index");
        }
        public ActionResult Search(DateTime dateFrom, DateTime dateTo)
        {
            List<VMTimesheet> data = TimeSheetRepo.Search(dateFrom, dateTo);
            return View("Index",data);
        }

        public ActionResult Sorting(string sort)
        {
            List<VMTimesheet> data = TimeSheetRepo.sortData(sort);
            return View("Index",data);
        }

    }
}