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
        public DbSet<User> Users => this.Set<User>();

        public DbSet<UserRole> UserRoles => this.Set<UserRole>();

        public DbSet<AccidentAndNearMiss> AccidentAndNearMisses => this.Set<AccidentAndNearMiss>();

        public DbSet<Inconsistency> Inconsistencies => this.Set<Inconsistency>();

        public DbSet<ContingencyPlan> ContingencyPlans => this.Set<ContingencyPlan>();

        public DbSet<RiskAssessment> RiskAssessments => this.Set<RiskAssessment>();

       public DbSet<Mission> Missions => this.Set<Mission>();

        public DbSet<PersonOccupationAndChronicDisease> PersonOccupationAndChronicDiseases => this.Set<PersonOccupationAndChronicDisease>();

        public DbSet<PersonAccidentAndNearMiss> PersonAccidentAndNearMisses => this.Set<PersonAccidentAndNearMiss>();


        public DbSet<UserMission> UserMissions => this.Set<UserMission>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new AccidentAndNearMissConfiguration());
            modelBuilder.ApplyConfiguration(new RiskAssesmentConfiguration());
            modelBuilder.ApplyConfiguration(new InconsistencyConfiguration());
            modelBuilder.ApplyConfiguration(new ContingencyPlanConfiguration());
            modelBuilder.ApplyConfiguration(new PersonOccupationAndChronicDiseaseConfiguration());
            modelBuilder.ApplyConfiguration(new PersonAccidentAndNearMissConfiguration());
            modelBuilder.ApplyConfiguration(new UserMissionConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
