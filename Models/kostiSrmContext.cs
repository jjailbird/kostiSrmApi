using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace kostiSrmApi.Models
{
    public class kostiSrmContext : DbContext
    {
        public kostiSrmContext(DbContextOptions<kostiSrmContext> options) :base(options)
        {
        }

        public DbSet<ResourceItem> ResourceItems { get; set; }
        public DbSet<ResourceType> ResourceTypes { get; set; }
        public DbSet<ResourceImage> ResourceImages { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            /*
            modelBuilder.Entity<ResourceItem>().ToTable(("ResourceItem"));
            modelBuilder.Entity<ResourceType>().ToTable(("ResourceType"));
            modelBuilder.Entity<ResourceImage>().ToTable(("ResourceImage"));
            modelBuilder.Entity<Reservation>().ToTable(("Reservation"));
            */
        }
    }
}
