using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Configurations
{
    public class PersonAccidentAndNearMissConfiguration : IEntityTypeConfiguration<PersonAccidentAndNearMiss>
    {
        public void Configure(EntityTypeBuilder<PersonAccidentAndNearMiss> builder)
        {
            builder.HasOne(x => x.AccidentAndNearMiss).WithMany(x => x.PersonAccidentAndNearMisses).HasForeignKey(x => x.AccidentAndNearMissId);
            builder.HasOne(x => x.Person).WithMany(x => x.PersonAccidentAndNearMisses).HasForeignKey(x => x.PersonId);
            builder.HasKey(x => new { x.PersonId, x.AccidentAndNearMissId });
        }
    }
}
