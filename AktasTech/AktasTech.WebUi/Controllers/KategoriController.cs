using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AktasTech.WebUi.Models;
using System.Linq;
using System.Threading.Tasks;
using AktasTech.Business.Abstract;

namespace AktasTech.WebUi.Controllers
{
    public class KategoriController : Controller
    {
        public IKategoriService _kategoriService;
        public KategoriController(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }
        public ActionResult Index()
        {


            var KategoriListeleme = new KategoriListeleme
            {
                Kategorilers = _kategoriService.GetAll()
            };
            return View(KategoriListeleme);
        }
    }
}
