using Microsoft.EntityFrameworkCore;
using Xacte.ModuleA.Data.Configurations;
using Xacte.ModuleA.Data.Entities;

namespace Xacte.ModuleA.Data.Contexts
{
    public sealed class ModuleAContext : DbContext
    {
        public ModuleAContext(DbContextOptions<ModuleAContext> options)
        {
        }

        public DbSet<ModuleAEntity> ModuleAEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("modulea");

            modelBuilder.ApplyConfiguration(new ModuleAEntityConfiguration());
        }
    }
}
