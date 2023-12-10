using System;
using System.Collections.Generic;
using System.Text;
using AktasTech.Business.Abstract;
using AktasTech.DataAccess.Abstract;
using AktasTech.Entities.Concrete;

namespace AktasTech.Business.Concrete
{
    public class KategorilerManager: IKategoriService
    {
        private IKategorilerDAL _kategorilerDAL;

        public KategorilerManager(IKategorilerDAL kategorilerDAL)
        {
            _kategorilerDAL = kategorilerDAL;
        }

        public List<Kategoriler> GetAll()
        {
            return _kategorilerDAL.GetList();
        }
    }
}
