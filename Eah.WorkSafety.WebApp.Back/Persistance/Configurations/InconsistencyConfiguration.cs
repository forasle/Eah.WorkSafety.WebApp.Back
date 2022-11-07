using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Configurations
{
    public class InconsistencyConfiguration : IEntityTypeConfiguration<Inconsistency>
    {
        public void Configure(EntityTypeBuilder<Inconsistency> builder)
        {
            builder.HasOne(x => x.Identifier).WithMany(x => x.Inconsistencies).HasForeignKey(x => x.IdentifierUserId);
        }
    }
}
