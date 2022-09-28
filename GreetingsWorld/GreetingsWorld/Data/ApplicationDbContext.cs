using Microsoft.EntityFrameworkCore;
using GreetingsWorld.Models;
using System.Collections.Generic;
using System.Security.Claims;

namespace GreetingsWorld.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<World> Worlds { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<FacilityPatient> Facility_Patient { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .HasKey(key => new { key.worldId, key.userId });
        }
    }
}