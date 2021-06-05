using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AktasTech.Business.Abstract;
using AktasTech.Entities.Concrete;

namespace AktasTech.Business.Concrete
{
    public class SepetService:ISepetService
    {
        public void SepeteEkle(Sepet sepet, Urunler urunler)
        {
            Sepettekiler sepettekiler = sepet.sepettekilers.FirstOrDefault(c => c.Urunler.UrunId == urunler.UrunId);
            if (sepettekiler != null)
            {
                sepettekiler.Miktar++;
                return;
            }
            sepet.sepettekilers.Add(new Sepettekiler { Urunler = urunler, Miktar = 1 });
        }

        public List<Sepettekiler> List(Sepet sepet)
        {
            return sepet.sepettekilers;
        }

        public void SepettenSil(Sepet sepet, int urunid)
        {
            sepet.sepettekilers.Remove(sepet.sepettekilers.FirstOrDefault(c => c.Urunler.UrunId == urunid));
        }
    }
}
