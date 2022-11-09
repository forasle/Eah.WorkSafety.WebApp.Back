namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class MissionDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Department { get; set; }

        public int AssignerUserId { get; set; }

        public int AssignedUserId { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? Deadline { get; set; }

        public bool Status { get; set; }
    }
}
