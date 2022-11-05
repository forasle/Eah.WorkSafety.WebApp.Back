using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Configurations
{
    public class UserMissionConfiguration : IEntityTypeConfiguration<UserMission>
    {
        public void Configure(EntityTypeBuilder<UserMission> builder)
        {
            //builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Mission).WithMany(x => x.UserMissions).HasForeignKey(x => x.MissionId);
            builder.HasOne(x => x.User).WithMany(x => x.UserMissions).HasForeignKey(x => x.UserId);

        }
    }
}
