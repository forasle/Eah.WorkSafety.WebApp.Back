
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Configurations
{
    public class AccidentAndNearMissConfiguration : IEntityTypeConfiguration<AccidentAndNearMiss>
    {
        public void Configure(EntityTypeBuilder<AccidentAndNearMiss> builder)
        {
            builder.HasOne(x=>x.Identifier).WithMany(x=>x.AccidentNearMisses).HasForeignKey(x=>x.IdentifiedUserId);
            builder.HasOne(x => x.AccidentAndNearMissType).WithMany(x => x.AccidentNearMisses).HasForeignKey(x => x.AccidentOrNearMissTypeId);
        }
    }
}
