using Microsoft.EntityFrameworkCore;
using Testing.Models;

namespace testing2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Components> Components { get; set; }
        public DbSet<Contracts> Contracts { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<EquipMovement> equipMovements { get; set; }
        public DbSet<Location> locations { get; set; }
        public DbSet<Suppliers> suppliers { get; set; }
        public DbSet<WorkPlaces> WorkPlaces { get; set; }
    }
}