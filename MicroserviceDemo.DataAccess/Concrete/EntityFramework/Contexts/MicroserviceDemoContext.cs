using MicroserviceDemo.Core.Utilities.Configuration;
using MicroserviceDemo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace MicroserviceDemo.DataAccess.Concrete.EntityFramework.Contexts
{
    public class MicroserviceDemoContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CoreConfig.GetConnectionString("Default"));
        }
    }
}
