using AktasTech.WebUi.Models;
using AktasTech.WebUi.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AktasTech.WebUi.ViewComponents
{
    public class SepetOzetiViewComponent: ViewComponent
    {
        private ISepetSessionService _sepetSessionService;

        public SepetOzetiViewComponent(ISepetSessionService sepetSessionService)
        {
            _sepetSessionService = sepetSessionService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new SepetOzeti
            {
                Sepet = _sepetSessionService.GetSepet()
            };
            return View(model);
        }
    }
}
