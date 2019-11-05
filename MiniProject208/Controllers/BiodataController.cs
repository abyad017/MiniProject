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
    public class BiodataController : Controller
    {
        // GET: Biodata
        public ActionResult Index()
        {
            VMBiodata dtBio = BiodataRepo.getAll();
            return View(dtBio);
        }
        public ActionResult Edit(long num)
        {
            ViewBag.ListMarital = BiodataRepo.getMarital();
            ViewBag.ListAgama = BiodataRepo.getAgama();
            ViewBag.ListIden = BiodataRepo.getIden();
            ViewBag.Gender = BiodataRepo.getGender();
            VMBiodata bio = BiodataRepo.getDataByID(num);
            return PartialView("_Edit", bio);
        }
        [HttpPost]
        public ActionResult EditPost(VMBiodata bio)
        {


            List<string> biodata = new List<string>();
            if(ModelState.IsValid)
            {
                if(BiodataRepo.cekExistEmailID(bio.email, bio.idBio))
                {
                    biodata.Add("EmailExist");
                }
                if(BiodataRepo.cekEsxistNoHPid(bio.phone_number1, bio.idBio))
                {
                    biodata.Add("NoHPExist");
                }
                if(BiodataRepo.cekIdentitas(bio.identity_type_id, bio.idBio, bio.identity_no))
                {
                    biodata.Add("IdentityExist");
                }
                if(biodata.Count != 0)
                {
                    return Json(new { simpanEdit = biodata }, JsonRequestBehavior.AllowGet);
                }
                if(BiodataRepo.simpanEdit(bio))
                {
                    return Json(new { simpanEdit = "Berhasil" }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { simpanEdit = "Gagal" }, JsonRequestBehavior.AllowGet);


        }


    }
}