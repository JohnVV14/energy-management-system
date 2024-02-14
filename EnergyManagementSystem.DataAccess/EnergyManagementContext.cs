using Microsoft.EntityFrameworkCore;
using EnergyManagementSystem.Models;

public class EnergyManagementContext : DbContext
{
    public DbSet<Component> Components { get; set; }
    public DbSet<Group> Groups { get; set; }
    // Add DbSets for other entities...

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Replace with connection string
        optionsBuilder.UseSqlServer("YourConnectionStringHere");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent API configuration for relationships and database mappings
    }
}
