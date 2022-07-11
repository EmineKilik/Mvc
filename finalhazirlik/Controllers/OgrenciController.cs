using finalhazirlik.Models;
using finalhazirlik.Models.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalhazirlik.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OgrenciEkle()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult OgrenciEkle(Ogrenci ogrenci)
        {
            using (var db = new OgrenciContext())
            {
                ogrenci.OgrenciOrtalama = ogrenci.OgrenciVize * 0.4F + ogrenci.OgrenciFinal * 0.6F;
                db.Ogrenciler.Add(ogrenci);
                db.SaveChanges();
               
            }
            return RedirectToAction("OgrenciListele");
        }


        public IActionResult OgrenciListele()
        {
            using(var db = new OgrenciContext())
            {
                var ogrenciler = db.Ogrenciler.ToList();
                
                    return View(ogrenciler);
                
               
            }
        }

        public IActionResult OgrenciSil(int id)
        {
            using(var db = new OgrenciContext())
            {
                var ogrenci = db.Ogrenciler.Find(id);
                db.Ogrenciler.Remove(ogrenci);
                db.SaveChanges();  
            }
            return RedirectToAction("OgrenciListele");
        }

        public IActionResult OgrenciGuncelle(int id)
        {
            using(var db = new OgrenciContext())
            {
                var ogrenci = db.Ogrenciler.Find(id);
                return View(ogrenci);
            }
        }

        [HttpPost]
        public IActionResult OgrenciGuncelle(Ogrenci ogrenci)
        {
            using(var db = new OgrenciContext())
            {
                ogrenci.OgrenciOrtalama = ogrenci.OgrenciVize * 0.4F + ogrenci.OgrenciFinal * 0.6F;
                db.Ogrenciler.Update(ogrenci);
                db.SaveChanges();
            }
            return RedirectToAction("OgrenciListele");
        }


    }
}
