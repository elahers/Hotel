using Hotel2.Models;
using Hotel2.Models.DB;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Hotels; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PardakhtHotel>()
                         .HasOne<ReserveHotel>(a => a.ReserveHotel)
              .WithMany(b => b.PardakhtHotels)
              .OnDelete(DeleteBehavior.Cascade);
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<EmkanatHotel> EmkanatHotels { get; set; }
        public DbSet<JoziateHotel> JoziateHotels { get; set; }

        public DbSet<Nazarat> Nazarats { get; set; }

        public DbSet<Otagh> Otaghs { get; set; }

        public DbSet<PardakhtHotel> PardakhtHotels { get; set; }
        public DbSet<ReserveHotel> ReserveHotels { get; set; }
        public DbSet<TasvireHotel> TasvireHotels { get; set; }

        public DbSet<TedadSetare> TedadSetares { get; set; }
        public DbSet<TedadTakht> TedadTakhts { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Ostan> Ostans { get; set; }
        public DbSet<DargahPardakht> DargahPardakhts { get; set; }
    }
}
