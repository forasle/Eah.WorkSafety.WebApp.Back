using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Configurations
{
    public class ContingencyPlanConfiguration : IEntityTypeConfiguration<ContingencyPlan>
    {
        public void Configure(EntityTypeBuilder<ContingencyPlan> builder)
        {
            builder.HasOne(x => x.Identifier).WithMany(x => x.ContingencyPlans).HasForeignKey(x => x.IdentifiedUserId);
        }
    }
}
