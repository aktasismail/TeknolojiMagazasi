using System;
using System.Collections.Generic;
using System.Text;
using AktasTech.Business.Abstract;
using AktasTech.DataAccess.Abstract;
using AktasTech.Entities.Concrete;

namespace AktasTech.Business.Concrete
{
    public class UrunlerManager : IUrunlerService
    {
        private IUrunlerDAL _urunlerDAL;

        public UrunlerManager(IUrunlerDAL urunlerDAL)
        {
            _urunlerDAL = urunlerDAL;
        }

        public void Add(Urunler urunler)
        {
            _urunlerDAL.Add(urunler);
        }

        public void Delete(int urunId)
        {
            _urunlerDAL.Delete(new Urunler { UrunId = urunId });
        }

        public List<Urunler> GetAll()
        {
            return _urunlerDAL.GetList();
        }

        public List<Urunler> GetByCategory(int kategoriId)
        {
            return _urunlerDAL.GetList(p => p.KategoriId == kategoriId || kategoriId == 0);
        }

        public Urunler GetById(int urunId)
        {
            return _urunlerDAL.Get(p => p.UrunId == urunId);

        }

        public void Update(Urunler urunler)
        {
            _urunlerDAL.Update(urunler);
        }
    }
}
