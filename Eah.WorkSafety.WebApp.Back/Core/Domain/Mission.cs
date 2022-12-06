namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class Mission
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Department { get; set; }

        public int AssignerUserId { get; set; }

        public DateTime Date { get; set; }

        public DateTime Deadline { get; set; }

        public bool Status { get; set; }

        public List<UserMission> Users { get; set; }
        public Mission()
        {
            Users = new List<UserMission>();
        }
    }
}
