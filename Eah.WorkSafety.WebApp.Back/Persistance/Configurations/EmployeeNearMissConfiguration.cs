using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Configurations
{
    public class EmployeeNearMissConfiguration : IEntityTypeConfiguration<EmployeeNearMiss>
    {
        public void Configure(EntityTypeBuilder<EmployeeNearMiss> builder)
        {
            builder.HasKey(x => new { x.EmployeeId, x.NearMissId });
            builder.HasOne(x => x.NearMiss).WithMany(x => x.Employees).HasForeignKey(x => x.NearMissId);
            builder.HasOne(x => x.Employee).WithMany(x => x.NearMisses).HasForeignKey(x => x.EmployeeId);

        }
    }
}
