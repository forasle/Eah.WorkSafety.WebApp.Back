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

        public DbSet<AppUser> Users { get; set; }

        public DbSet<AppRole> AppRoles { get; set; }

        public DbSet<RiskAssessment> AccidentAndNearMisses { get; set; }

        public DbSet<Inconsistency> Inconsistencies { get; set; }

        public DbSet<ContingencyPlan> ContingencyPlans { get; set; }

        public DbSet<RiskAssessment> RiskAssessments { get; set; }

        public DbSet<Mission> Missions { get; set; }

        public DbSet<PersonOccupationAndChronicDisease> PersonOccupationAndDiseases { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AccidentAndNearMissConfiguration());
            modelBuilder.ApplyConfiguration(new RiskAssesmentConfiguration());
            modelBuilder.ApplyConfiguration(new InconsistencyConfiguration());
            modelBuilder.ApplyConfiguration(new MissionConfiguration());
            modelBuilder.ApplyConfiguration(new ContingencyPlanConfiguration());
            modelBuilder.ApplyConfiguration(new PersonOccupationAndChronicDiseaseConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
