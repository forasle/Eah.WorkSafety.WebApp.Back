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
        public DbSet<Role> Roles { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<Accident> Accidents { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAccident> EmployeeAccident { get; set; }
        public DbSet<EmployeeNearMiss> EmployeeNearMiss { get; set; }
        public DbSet<EmployeeChronicDisease> EmployeeChronicDisease { get; set; }
        public DbSet<EmployeeOccupationDisease> EmployeeOccupationDisease { get; set; }
        public DbSet<ChronicDisease> ChronicDiseases { get; set; }
        public DbSet<ContingencyPlan> ContingencyPlans { get; set; }
        public DbSet<Inconsistency> Inconsistencies { get; set; }
        public DbSet<NearMiss> NearMisses { get; set; }
        public DbSet<OccupationDisease> OccupationDiseases { get; set; }
        public DbSet<RiskAssessment> RiskAssessments { get; set; }
        public DbSet<PreventiveActivity> PreventiveActivities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserMissionConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeAccidentConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeChronicDiseaseConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeNearMissConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeOccupationDiseaseConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
