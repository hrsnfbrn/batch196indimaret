using Indimaret.Model;
using Indimaret.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Indimaret.Web.Controllers
{
    public class BarangController : Controller
    {
        //
        // GET: /Barang/
        public ActionResult Index()
        {
            return View(clBarangRepo.GetAll());
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult Save(clBarang barang)
        {
            if (clBarangRepo.Createbarang(barang))
            {
                return Json(new { Simpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            return View();
        }

        //clBarangRepo barangrepo = new clBarangRepo(); //kalo non static harus di inisialisasi
        public ActionResult Delete(int ID)
        {
            if (clBarangRepo.Deletebarang(ID))
            {
                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Edit(int ID)
        {
            return PartialView("_Edit",clBarangRepo.GetByID(ID));
        }

        public ActionResult Update(clBarang barang)
        {
            if (clBarangRepo.UpdateBarang(barang))
            {
                return Json(new { Update = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Update = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }
	}
}