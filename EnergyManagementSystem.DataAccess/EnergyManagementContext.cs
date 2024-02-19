using Microsoft.EntityFrameworkCore;
using EnergyManagementSystem.Models;

namespace EnergyManagementSystem.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Component> Components { get; set; }
    }
}