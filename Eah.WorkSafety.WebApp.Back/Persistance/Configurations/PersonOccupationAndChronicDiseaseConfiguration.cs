using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Configurations
{
    public class PersonOccupationAndChronicDiseaseConfiguration : IEntityTypeConfiguration<PersonOccupationAndChronicDisease>
    {
        public void Configure(EntityTypeBuilder<PersonOccupationAndChronicDisease> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.OccupationAndChronicDisease).WithMany(x => x.PersonOccupationAndChronicDiseases).HasForeignKey(x => x.OccupationAndChronicDiseaseId);
            builder.HasOne(x => x.Person).WithMany(x => x.PersonOccupationAndChronicDiseases).HasForeignKey(x => x.PersonId);
        }
    }
}
