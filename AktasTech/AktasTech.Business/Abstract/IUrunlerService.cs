using System;
using System.Collections.Generic;
using System.Text;
using AktasTech.Entities.Concrete;

namespace AktasTech.Business.Abstract
{
    public interface IUrunlerService
    {
        List<Urunler> GetAll();
        List<Urunler> GetByCategory(int KategoriId);
        void Add(Urunler urunler);
        void Update(Urunler urunler);
        void Delete(int UrunId);
        Urunler GetById(int UrunId);
       


    }
}
