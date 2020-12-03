using Amazing.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Amazing.EntityFramework
{
    public class AmazingDbContext : DbContext
    {
        public AmazingDbContext()
        {

        }
        public AmazingDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
