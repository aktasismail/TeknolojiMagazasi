using AktasTech.Business.Abstract;
using AktasTech.WebUi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AktasTech.WebUi.Controllers
{
    public class UrunlerController : Controller
    {
        IUrunlerService _urunlerService;
        public UrunlerController(IUrunlerService urunlerService)
        {
            _urunlerService = urunlerService;
        }
        public ActionResult Urun(int kategori = 0)
        {
            var urunlers = _urunlerService.GetByCategory(kategori);
            UrunListeleme model = new UrunListeleme
            {
                Urunlers = urunlers.ToList(),
                MevcutKategori = kategori,
            };
            return View(model);
        }
        public IActionResult UrunDetay(int urunId)
        {
            var urun = _urunlerService.GetById(urunId);
            return View(urun);
        }
        
    }
}
