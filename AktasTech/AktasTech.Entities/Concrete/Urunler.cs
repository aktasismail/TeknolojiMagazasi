﻿using AktasTech.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AktasTech.Entities.Concrete
{
    public class Urunler:IEntity
    {
        [Key]
        [Required]
        public int UrunId { get; set; }
        [Required]
        public string? UrunAd { get; set; }
        public string? UrunKodu { get; set; }
        public string? Detay { get; set; }
        
        [Required]
        public decimal Fiyat { get; set; }
        [Required]
        public short? Stok { get; set; }
        
        public string? Gorsel { get; set; }
        public int KategoriId { get; set; }
        [ForeignKey(nameof(KategoriId))]
        public Kategoriler? kategoriler { get; set; }
    }
}
