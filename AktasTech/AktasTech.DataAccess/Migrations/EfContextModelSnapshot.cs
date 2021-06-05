﻿// <auto-generated />
using AktasTech.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AktasTech.DataAccess.Migrations
{
    [DbContext(typeof(EfContext))]
    partial class EfContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AktasTech.Entities.Concrete.Kategoriler", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAd")
                        .IsRequired();

                    b.HasKey("KategoriId");

                    b.ToTable("Kategorilers");
                });

            modelBuilder.Entity("AktasTech.Entities.Concrete.Urunler", b =>
                {
                    b.Property<int>("UrunId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Fiyat");

                    b.Property<string>("Gorsel");

                    b.Property<int>("KategoriId");

                    b.Property<short>("Stok");

                    b.Property<string>("UrunAd")
                        .IsRequired();

                    b.HasKey("UrunId");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urunlers");
                });

            modelBuilder.Entity("AktasTech.Entities.Concrete.Urunler", b =>
                {
                    b.HasOne("AktasTech.Entities.Concrete.Kategoriler", "kategoriler")
                        .WithMany("Urunlers")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
