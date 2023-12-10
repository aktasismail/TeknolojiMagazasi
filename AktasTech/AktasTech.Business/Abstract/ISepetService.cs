using System;
using System.Collections.Generic;
using System.Text;
using AktasTech.Entities.Concrete;
namespace AktasTech.Business.Abstract
{
    public interface ISepetService
    {
        void SepeteEkle(Sepet sepet, Urunler urunler);
        void SepettenSil(Sepet sepet, int UrunId);
        List<Sepettekiler> List(Sepet sepet);
    }
}
