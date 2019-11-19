using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrnekProje.Models;

namespace OrnekProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjeContext db;
        public HomeController(ProjeContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FaturaOlustur(FaturaModelView modelView)
        {
            db.musteris.Add(modelView.musteri);
            db.faturas.Add(modelView.fatura);
            db.SaveChanges();
            var musteriIdBulma = db.musteris.FirstOrDefault(x => x.ad == modelView.musteri.ad && x.soyad == modelView.musteri.soyad);
            var faturaIdBulma = db.faturas.FirstOrDefault(x => x.faturaNo == modelView.fatura.faturaNo);
            for (int i = 0; i < 3; i++)
            {
                AlinanUrun alinanUrun = new AlinanUrun();
                alinanUrun.urunAdi = modelView.alinanUruns[i].urunAdi;
                alinanUrun.musteri = new Musteri();
                alinanUrun.musteri.musteriId = musteriIdBulma.musteriId;
                alinanUrun.fatura = new Fatura();
                alinanUrun.fatura.faturaId = faturaIdBulma.faturaId;
                alinanUrun.adet = modelView.alinanUruns[i].adet;
                alinanUrun.birimFiyat = modelView.alinanUruns[i].birimFiyat;
                alinanUrun.toplam = modelView.alinanUruns[i].toplam;
                db.alinanUruns.Add(alinanUrun);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}