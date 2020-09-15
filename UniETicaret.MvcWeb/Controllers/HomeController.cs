using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniETicaret.MvcWeb.Entity;
using UniETicaret.MvcWeb.Models;

namespace UniETicaret.MvcWeb.Controllers
{
    public class HomeController : Controller
    {

        DataContext db = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            var urunler = db.Urunler
               .Where(i => i.Anasayfada && i.Satistami)
               .Select(i => new UrunModel()
               {
                   Id = i.Id,
                   Isim = i.Isim.Length > 50 ? i.Isim.Substring(0, 47) + "..." : i.Isim,
                   Aciklama = i.Aciklama.Length > 50 ? i.Aciklama.Substring(0, 47) + "..." : i.Aciklama,
                   Fiyat = i.Fiyat,
                   Stok = i.Stok,
                   Resim = i.Resim,
                   KategoriId = i.KategoriId
               }).ToList();

            return View(urunler);
        }

        public ActionResult Detaylar(int id)
        {
            return View(db.Urunler.Where(i=> i.Id==id).FirstOrDefault());
        }

        public ActionResult Liste(int? id, string AK)
        {
            var urunler = db.Urunler
                .Where(i => i.Satistami)
                .Select(i => new UrunModel()
                {
                    Id = i.Id,
                    Isim = i.Isim.Length > 50 ? i.Isim.Substring(0, 47) + "..." : i.Isim,
                    Aciklama = i.Aciklama.Length > 50 ? i.Aciklama.Substring(0, 47) + "..." : i.Aciklama,
                    Fiyat = i.Fiyat,
                    Stok = i.Stok,
                    Resim = i.Resim ?? "1.jpg",
                    KategoriId = i.KategoriId
                }).AsQueryable();

            if (id != null)
            {
                urunler = urunler.Where(i => i.KategoriId == id);
            }

            if (AK != null)
            {
                urunler = urunler.Where(i => i.Isim.ToLower().Contains(AK));
            }

            return View(urunler.ToList());
        }
        public PartialViewResult GetCategories()
        {
            return PartialView(db.Kategoriler.ToList());
        }
    }
}