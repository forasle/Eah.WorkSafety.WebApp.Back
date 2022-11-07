using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Configurations
{
    public class RiskAssesmentConfiguration : IEntityTypeConfiguration<RiskAssessment>
    {
        public void Configure(EntityTypeBuilder<RiskAssessment> builder)
        {
            builder.HasOne(x => x.Identifier).WithMany(x => x.RiskAssessments).HasForeignKey(x => x.IdentifierUserId);
        }
    }
}
