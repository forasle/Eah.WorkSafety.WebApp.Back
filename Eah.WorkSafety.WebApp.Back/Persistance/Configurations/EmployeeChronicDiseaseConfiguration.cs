using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Configurations
{
    public class EmployeeChronicDiseaseConfiguration : IEntityTypeConfiguration<EmployeeChronicDisease>
    {
        public void Configure(EntityTypeBuilder<EmployeeChronicDisease> builder)
        {
            builder.HasKey(x => new { x.EmployeeId, x.ChronicDiseaseId });
            builder.HasOne(x => x.ChronicDisease).WithMany(x => x.Employees).HasForeignKey(x => x.ChronicDiseaseId);
            builder.HasOne(x => x.Employee).WithMany(x => x.ChronicDiseases).HasForeignKey(x => x.EmployeeId);

        }
    }
}
