using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Configurations
{
    public class UserMissionConfiguration : IEntityTypeConfiguration<UserMission>
    {
        public void Configure(EntityTypeBuilder<UserMission> builder)
        {
            builder.HasKey(x => new {x.UserId,x.MissionId});
            builder.HasOne(x => x.Mission).WithMany(x => x.Users).HasForeignKey(x => x.MissionId);
            builder.HasOne(x => x.User).WithMany(x => x.Missions).HasForeignKey(x => x.UserId);

        }
    }
}
