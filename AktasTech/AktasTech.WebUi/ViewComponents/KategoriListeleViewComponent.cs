using AktasTech.Business.Abstract;
using AktasTech.WebUi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AktasTech.WebUi.ViewComponents
{
    public class KategoriListeleViewComponent:ViewComponent
    {
        private IKategoriService _kategoriService;
        public KategoriListeleViewComponent(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new KategoriListeleme
            {
                Kategorilers = _kategoriService.GetAll(),
                MevcutKategori = Convert.ToInt32(HttpContext.Request.Query["kategori"])

            };
            return View(model);
        }
    }
}
