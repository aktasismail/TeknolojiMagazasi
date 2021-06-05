using AktasTech.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AktasTech.WebUi.Services.Abstract
{
    public interface ISepetSessionService
    {
        Sepet GetSepet();
        void SetSepet(Sepet sepet);
    }
}
