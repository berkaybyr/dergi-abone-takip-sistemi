﻿using DAboneTakip.Models;
using Microsoft.EntityFrameworkCore;

namespace DergiAboneProje.Models
{
    public class DergiDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-F9KH9U2\\SQLEXPRESS;database=DergiAboneTakipProje; integrated security= true;");
        }
        public DbSet<Dergiler> Dergilers { get; set; }
        public DbSet<Uyeler> Uyelers { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
        public DbSet<Abonelikler> Aboneliklers { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
