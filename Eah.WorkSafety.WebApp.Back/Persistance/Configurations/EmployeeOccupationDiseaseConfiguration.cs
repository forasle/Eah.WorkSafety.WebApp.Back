using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Configurations
{
    public class EmployeeOccupationDiseaseConfiguration : IEntityTypeConfiguration<EmployeeOccupationDisease>
    {
        public void Configure(EntityTypeBuilder<EmployeeOccupationDisease> builder)
        {
            builder.HasKey(x => new { x.EmployeeId, x.OccupationDiseaseId });
            builder.HasOne(x => x.OccupationDisease).WithMany(x => x.Employees).HasForeignKey(x => x.OccupationDiseaseId);
            builder.HasOne(x => x.Employee).WithMany(x => x.OccupationDiseases).HasForeignKey(x => x.EmployeeId);

        }
    }
}
