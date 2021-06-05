using AktasTech.Entities.Concrete;
using AktasTech.WebUi.ExtensionMethods;
using AktasTech.WebUi.Services.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AktasTech.WebUi.Services.Concrete
{
    public class SepetSessionService : ISepetSessionService
    {
        private IHttpContextAccessor _httpContextAccessor;

        public SepetSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public Sepet GetSepet()
        {
            Sepet sepetkontrol = _httpContextAccessor.HttpContext.Session.GetObject<Sepet>("sepet");
            if (sepetkontrol == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("sepet", new Sepet());
                sepetkontrol = _httpContextAccessor.HttpContext.Session.GetObject<Sepet>("sepet");
            }
            return sepetkontrol;

        }

        public void SetSepet(Sepet sepet)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("sepet", sepet);
        }
    }
}
