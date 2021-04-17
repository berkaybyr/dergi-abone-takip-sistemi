﻿// <auto-generated />
using System;
using DergiAboneProje.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAboneTakip.Migrations.DergiDb
{
    [DbContext(typeof(DergiDbContext))]
    partial class DergiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DergiAboneProje.Models.Abonelikler", b =>
                {
                    b.Property<int>("KayıtID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DergiID")
                        .HasColumnType("int");

                    b.Property<int>("KayıtSuresi")
                        .HasColumnType("int");

                    b.Property<DateTime>("KayıtTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.HasKey("KayıtID");

                    b.HasIndex("DergiID");

                    b.HasIndex("UyeID");

                    b.ToTable("Aboneliklers");
                });

            modelBuilder.Entity("DergiAboneProje.Models.Dergiler", b =>
                {
                    b.Property<int>("DergiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DergiAD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DergiTARIH")
                        .HasColumnType("datetime2");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<int?>("KategorilerKategoriID")
                        .HasColumnType("int");

                    b.HasKey("DergiID");

                    b.HasIndex("KategorilerKategoriID");

                    b.ToTable("Dergilers");
                });

            modelBuilder.Entity("DergiAboneProje.Models.Kategoriler", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategorilers");
                });

            modelBuilder.Entity("DergiAboneProje.Models.Uyeler", b =>
                {
                    b.Property<int>("UyeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<long>("TelNo")
                        .HasColumnType("bigint");

                    b.Property<string>("UyeAD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UyeID");

                    b.ToTable("Uyelers");
                });

            modelBuilder.Entity("DergiAboneProje.Models.Abonelikler", b =>
                {
                    b.HasOne("DergiAboneProje.Models.Dergiler", "Dergi")
                        .WithMany()
                        .HasForeignKey("DergiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DergiAboneProje.Models.Uyeler", "Uye")
                        .WithMany()
                        .HasForeignKey("UyeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dergi");

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("DergiAboneProje.Models.Dergiler", b =>
                {
                    b.HasOne("DergiAboneProje.Models.Kategoriler", "Kategoriler")
                        .WithMany("Dergilers")
                        .HasForeignKey("KategorilerKategoriID");

                    b.Navigation("Kategoriler");
                });

            modelBuilder.Entity("DergiAboneProje.Models.Kategoriler", b =>
                {
                    b.Navigation("Dergilers");
                });
#pragma warning restore 612, 618
        }
    }
}
