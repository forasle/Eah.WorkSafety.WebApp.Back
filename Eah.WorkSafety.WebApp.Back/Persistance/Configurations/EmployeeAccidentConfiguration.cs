using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Configurations
{
    public class EmployeeAccidentConfiguration : IEntityTypeConfiguration<EmployeeAccident>
    {
        public void Configure(EntityTypeBuilder<EmployeeAccident> builder)
        {
            builder.HasKey(x => new { x.EmployeeId, x.AccidentId });
            builder.HasOne(x => x.Accident).WithMany(x => x.Employees).HasForeignKey(x => x.AccidentId);
            builder.HasOne(x => x.Employee).WithMany(x => x.Accidents).HasForeignKey(x => x.EmployeeId);
            builder.HasOne(x => x.ThePrecautionsToBeTakenOfEmployeeAccident).WithOne(x => x.EmployeAccident).HasForeignKey<EmployeeAccident>(x=>x.ThePrecautionsToBeTakenOfEmployeeAccidentId);
            builder.HasOne(x => x.TheSubjectOfTheAccidentOfEmployeeAccident).WithOne(x => x.EmployeAccident).HasForeignKey<EmployeeAccident>(x => x.TheSubjectOfTheAccidentOfEmployeeAccidentId);


        }
    }
}
