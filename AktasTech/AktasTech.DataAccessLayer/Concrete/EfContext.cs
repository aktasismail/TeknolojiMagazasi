using System;
using System.Collections.Generic;
using System.Text;
using AktasTech.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace AktasTech.DataAccess.Concrete
{
    public class EfContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
    }
}
