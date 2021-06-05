using AktasTech.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AktasTech.WebUi.Models
{
    public class KategoriListeleme
    {
        public List<Kategoriler> Kategorilers { get; internal set; }
        public int MevcutKategori { get; internal set; }
    }
}
