using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCKamp.Controllers
{
    public class StatisticController : Controller
    {
        Context c = new Context();
        // GET: Statistic
        public ActionResult Index()
        {
            var deger1 = c.Categories.Count();
            ViewBag.d1 = deger1;

            //Başlık tablosunda "yazılım" kategorisine ait başlık sayısı
            var categoryıd = c.Categories.Where(x => x.CategoryName == "Yazılım").Select(x => x.CategoryID).FirstOrDefault();

            var deger2 = c.Headings.Where(x=> x.CategoryID == categoryıd).Count();
            ViewBag.d2 = deger2;

            //Kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki sayısal fark

            var statusTrue = c.Categories.Count(c => c.CategoryStatus == true);
            var statusFalse = c.Categories.Count(c => c.CategoryStatus == false);
            var deger3 = statusTrue - statusFalse;
            
            ViewBag.d3 = deger3;

            //En fazla başlığa sahip kategori adı
            var deg4 = c.Headings
                          .GroupBy(x => x.CategoryID)  
                          .Select(g => new
                          {
                              KategoriAdı = g.Key,  
                              BaslikSayisi = g.Count() 
                          })
                          .OrderByDescending(x => x.BaslikSayisi)  
                          .FirstOrDefault();

            var deger4 = c.Categories
                   .Where(x => x.CategoryID == deg4.KategoriAdı)
                   .Select(x => x.CategoryName)  
                   .FirstOrDefault();
            ViewBag.d4 = deger4;

            // Yazar adında 'a' harfi geçen yazar sayısı

            var deger5 = c.Writers.Count(x=> x.WriterName.Contains("a") || x.WriterName.Contains("A"));
            ViewBag.d5 = deger5;

            return View();

            
        }
    }
}