using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AktasTech.Entities.Concrete
{
    public class Sepet
    {
        public Sepet()
        {
            sepettekilers = new List<Sepettekiler>();
        }
        public List<Sepettekiler> sepettekilers { get; set; }
        public decimal Total
        {
            get
            {
                return sepettekilers.Sum(c => c.Urunler.Fiyat * c.Miktar);
            }
        }
    }
}
