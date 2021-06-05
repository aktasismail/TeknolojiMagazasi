using AktasTech.Business.Abstract;
using AktasTech.Entities.Concrete;
using AktasTech.WebUi.Models;
using AktasTech.WebUi.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AktasTech.WebUi.Controllers
{
    public class SepetController : Controller
    {
        private ISepetSessionService _sepetSessionService;
        private ISepetService _sepetService;
        private IUrunlerService _urunlerService;

        public SepetController(ISepetSessionService sepetSessionService, ISepetService sepetService, IUrunlerService urunlerService)
        {
            _sepetSessionService = sepetSessionService;
            _sepetService = sepetService;
            _urunlerService = urunlerService;
        }
     
        public ActionResult SepeteEkleme(int UrunId)
        {
            var UrunEkle = _urunlerService.GetById(UrunId);
            var sepet = _sepetSessionService.GetSepet();
            _sepetService.SepeteEkle(sepet, UrunEkle);
            _sepetSessionService.SetSepet(sepet);
            TempData.Add("message", String.Format("{0}, Sepete Eklendi!", UrunEkle.UrunAd));
            return RedirectToAction("Urun", "Urunler");
        }
        public ActionResult Listeleme()
        {
            var sepet = _sepetSessionService.GetSepet();
            SepetListeleme sepetListeleme = new SepetListeleme
            {
                Sepet = sepet
            };
            return View(sepetListeleme);
        }
        public ActionResult Silme(int urunId)
        {

            var sepet = _sepetSessionService.GetSepet();
            _sepetService.SepettenSil(sepet, urunId);
            _sepetSessionService.SetSepet(sepet);

            return RedirectToAction("Listeleme");
        }
        public ActionResult Tamamla()
        {
            var TeslimatDetaymodel = new TeslimatDetayModel()
            {
                TeslimatDetay = new TeslimatDetay()
            };
            return View();
        }
        [HttpPost]
        public ActionResult Tamamla(TeslimatDetay teslimatDetay)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", string.Format("Siparişiniz Alındı"));
            return View();
        }
    }
}
