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

        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Mission> Missions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserMissionConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
