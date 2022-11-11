using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Eah.WorkSafety.WebApp.Back.Persistance.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Context
{
    public class WorkSafetyDbContext: DbContext
    {
        public WorkSafetyDbContext(DbContextOptions<WorkSafetyDbContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }

        public DbSet<UserRole> Role { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
