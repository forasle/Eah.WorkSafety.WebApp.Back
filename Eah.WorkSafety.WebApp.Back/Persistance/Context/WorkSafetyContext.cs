using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Eah.WorkSafety.WebApp.Back.Persistance.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Context
{
    public class WorkSafetyContext: DbContext
    {
        public WorkSafetyContext(DbContextOptions<WorkSafetyContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Mission> Missons { get; set; }
        public DbSet<UserRole> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserMissionConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
