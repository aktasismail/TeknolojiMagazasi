using AktasTech.Business.Abstract;
using AktasTech.WebUi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AktasTech.WebUi.Controllers
{
    public class UrunlerController : Controller
    {
        IUrunlerService _urunlerService;
        


        public UrunlerController(IUrunlerService urunlerService)
        {
            _urunlerService = urunlerService;
           
        }


        public ActionResult Urun(int sayfa = 1, int kategori = 0)
        {
            int Sayfadakiler = 10;
            var urunlers = _urunlerService.GetByCategory(kategori);
            UrunListeleme model = new UrunListeleme
            {
                Urunlers = urunlers.Skip((sayfa - 1) * Sayfadakiler).Take(Sayfadakiler).ToList(),
                SayfaSayisi = (int)Math.Ceiling(urunlers.Count / (double)Sayfadakiler),
                Sayfadakiler = Sayfadakiler,
                MevcutKategori = kategori,
                MevcutSayfa = sayfa
            };
            return View(model);

        }
        
    }
}
