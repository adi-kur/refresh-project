using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.Covid;
using Repo.Covid;


namespace refresh_project.Controllers
{
    public class CovidController : Controller
    {
        // GET: Covid
        public ActionResult Index()
        {
            List<VMCovid> data = RepoCovid.GetListAll();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(VMCovid Covid)
        {
            string result = RepoCovid.savedata(Covid);

            if (result == "ok")
            {
                //return Json(new { message = "Berhasil" }, JsonRequestBehavior.AllowGet);
                return RedirectToAction("Index", "Covid");
            }
            else
            {
                return Json(new { message = "Gagal", data = result }, JsonRequestBehavior.AllowGet);
                //return RedirectToAction("Index", "Covid");
            }
        }

        [HttpPost]
        public ActionResult Delete(int Covid)
        {
            string result = RepoCovid.HapusData(Covid);
            if (result == "ok")
            {
                return RedirectToAction("Index", "Covid");
            }
            else
            {
                return Json(new { message = "Gagal", data = result }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Edit(int Covid)
        {
            VMCovid data = RepoCovid.GetDetailsById(Covid);

            return View("Edit", data);
        }

        [HttpPost]
        public ActionResult Edit(VMCovid Covid)
        {
            string result = RepoCovid.edit(Covid);
            if (result == "ok")
            {
                return RedirectToAction("Index", "Covid");
            }
            else
            {
                return Json(new { message = "Gagal", data = result }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}