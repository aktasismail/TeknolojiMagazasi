using System;
using System.Collections.Generic;
using System.Text;
using AktasTech.Core.DataAccess.EntityFramework;
using AktasTech.DataAccess.Abstract;
using AktasTech.Entities.Concrete;

namespace AktasTech.DataAccess.Concrete
{
    public class EfUrunlerDAL: EfEntityRepositoryBase<Urunler, EfContext>, IUrunlerDAL
    {
    }
}
