using System;
using System.Collections.Generic;
using System.Text;
using AktasTech.Entities.Concrete;

namespace AktasTech.Business.Abstract
{
    public interface IKategoriService
    {
        List<Kategoriler> GetAll();
    }
}
