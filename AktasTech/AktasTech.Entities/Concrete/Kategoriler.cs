using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using AktasTech.Core.Entities;

namespace AktasTech.Entities.Concrete
{
    public class Kategoriler:IEntity
    {
        [Key]
        [Required]
        public int KategoriId { get; set; }
        [Required]
        public string? KategoriAd { get; set; }
        public ICollection<Urunler>? Urunlers { get; set; }
    }
}
