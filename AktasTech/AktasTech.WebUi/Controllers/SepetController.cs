using AktasTech.Business.Abstract;
using AktasTech.Entities.Concrete;
using AktasTech.WebUi.Models;
using AktasTech.WebUi.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;

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
            return View();
        }
        public ActionResult Olmadi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([FromForm]string UrunKodu)
        {
            var domain = "https://localhost:7143";
            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
                {            
                  new SessionLineItemOptions
                  {
                    Price = $"{UrunKodu}",
                    Quantity = 1,
                  },
                },
                Mode = "payment",
                ShippingAddressCollection = new Stripe.Checkout.SessionShippingAddressCollectionOptions
                {
                    AllowedCountries = new List<string> { "TR" },
                },
                CustomText = new Stripe.Checkout.SessionCustomTextOptions
                {
                    ShippingAddress = new Stripe.Checkout.SessionCustomTextShippingAddressOptions
                    {
                        Message = "Please note that we can't guarantee 2-day delivery for PO boxes at this time.",
                    },
                    Submit = new Stripe.Checkout.SessionCustomTextSubmitOptions
                    {
                        Message = "We'll email you instructions on how to get started.",
                    },
                },
                SuccessUrl = domain + "/Sepet/Tamamla",
                CancelUrl = domain + "/Sepet/Olmadi",
            };
            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }
        
    }
}
