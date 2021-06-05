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
            optionsBuilder.UseSqlServer("Data Source=213.238.183.40\\MSSQLSERVER2019;Initial Catalog=aktastech;User ID=aktastech; Password=*******");
        }
        //Server=213.238.183.40\MSSQLSERVER2019;Database=aktastech; Trusted_Connection=true
        // 
        //Data Source=213.238.183.40\MSSQLSERVER2019;Initial Catalog = aktastech;Persist Security Info=True;User ID=aktastech;Password=********
        //Data Source=213.238.183.40\MSSQLSERVER2019;Initial Catalog = aktastech;Persist Security Info=True;User ID=aktastech;Password=********
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
    }
}
