namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class UserMission
    {
        public int UserId { get; set; }

        public int MissionId { get; set; }
        public User? User { get; set; }

        public Mission? Mission { get; set; }

        public UserMission()
        {
        }
        public UserMission(int userId, int missionId)
        {
            this.UserId = userId;
            this.MissionId = missionId;
        }
    }
}
