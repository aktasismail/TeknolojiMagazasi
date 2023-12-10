using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AktasTech.Entities.Concrete
{
    public class TeslimatDetay
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Sehir { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        [Range(17, 85)]
        public string Yas { get; set; }
    }
}
