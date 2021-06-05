using AktasTech.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace AktasTech.Entities.Concrete
{
    public class Urunler:IEntity
    {
        [Key]
        [Required]
        public int UrunId { get; set; }
        [Required]
        public string UrunAd { get; set; }
        [Required]
        public int KategoriId { get; set; }
        [Required]
        public decimal Fiyat { get; set; }
        [Required]
        public short Stok { get; set; }
        
        public string Gorsel { get; set; }

        public Kategoriler kategoriler { get; set; }
    }
}
