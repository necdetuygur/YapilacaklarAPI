﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yapilacaklar.Data;

namespace Yapilacaklar.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Yapilacaklar.Core.Models.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("KullaniciID");

                    b.ToTable("Kullanici");

                    b.HasData(
                        new
                        {
                            KullaniciID = 1,
                            Ad = "Ahmet",
                            Soyad = "Yılmaz"
                        },
                        new
                        {
                            KullaniciID = 2,
                            Ad = "Mehmet",
                            Soyad = "Yılmaz"
                        },
                        new
                        {
                            KullaniciID = 3,
                            Ad = "Ayşe",
                            Soyad = "Yılmaz"
                        });
                });

            modelBuilder.Entity("Yapilacaklar.Core.Models.Yapilacak", b =>
                {
                    b.Property<int>("YapilacakID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Icerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Yapildi")
                        .HasColumnType("bit");

                    b.HasKey("YapilacakID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("Yapilacak");

                    b.HasData(
                        new
                        {
                            YapilacakID = 1,
                            Baslik = "Un al",
                            Icerik = "Un al",
                            KullaniciID = 1,
                            Tarih = new DateTime(2021, 3, 13, 16, 24, 15, 507, DateTimeKind.Local).AddTicks(8802),
                            Yapildi = false
                        },
                        new
                        {
                            YapilacakID = 2,
                            Baslik = "Süt al",
                            Icerik = "Süt al",
                            KullaniciID = 2,
                            Tarih = new DateTime(2021, 3, 13, 16, 24, 15, 509, DateTimeKind.Local).AddTicks(445),
                            Yapildi = false
                        },
                        new
                        {
                            YapilacakID = 3,
                            Baslik = "Yoğurt al",
                            Icerik = "Yoğurt al",
                            KullaniciID = 3,
                            Tarih = new DateTime(2021, 3, 13, 16, 24, 15, 509, DateTimeKind.Local).AddTicks(465),
                            Yapildi = false
                        });
                });

            modelBuilder.Entity("Yapilacaklar.Core.Models.Yapilacak", b =>
                {
                    b.HasOne("Yapilacaklar.Core.Models.Kullanici", "Kullanici")
                        .WithMany("Yapilacaks")
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("Yapilacaklar.Core.Models.Kullanici", b =>
                {
                    b.Navigation("Yapilacaks");
                });
#pragma warning restore 612, 618
        }
    }
}
