using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(x => x.Role).WithMany(x => x.Users);
            builder.HasMany(x => x.RiskAssessments).WithOne(x => x.User).HasForeignKey(x => x.CreatorUserId);
            builder.HasMany(x => x.Accidents).WithOne(x => x.User).HasForeignKey(x => x.CreatorUserId);
            builder.HasMany(x => x.NearMisses).WithOne(x => x.User).HasForeignKey(x => x.CreatorUserId);
            builder.HasMany(x => x.ContingencyPlans).WithOne(x => x.User).HasForeignKey(x => x.CreatorUserId);
        }
    }
}
