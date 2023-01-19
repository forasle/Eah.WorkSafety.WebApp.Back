using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Configurations
{
    public class ThePrecautionsToBeTakenOfEmployeeAccidentConfiguration : IEntityTypeConfiguration<ThePrecautionsToBeTakenOfEmployeeAccident>
    {
        public void Configure(EntityTypeBuilder<ThePrecautionsToBeTakenOfEmployeeAccident> builder)
        {
            builder.HasKey(x => x.id);
            builder.HasOne(x => x.EmployeAccident).WithOne(x => x.ThePrecautionsToBeTakenOfEmployeeAccident);



        }
    }
}
