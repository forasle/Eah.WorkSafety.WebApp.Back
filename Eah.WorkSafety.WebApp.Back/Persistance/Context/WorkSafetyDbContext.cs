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
        public DbSet<UserRole> Roles { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<Accident> Accidents { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<NearMiss> NearMisses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserMissionConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeAccidentConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeNearMissConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
