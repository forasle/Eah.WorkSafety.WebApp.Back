namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class AccidentDto
    {
        public int Id { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? AccidentInfo { get; set; }

        public DateTime? Date { get; set; }

        public bool RootCauseAnalysis { get; set; }

        public int LostDays { get; set; }

        public int CreatorUserId { get; set; }

        public List<int>? Employees { get; set; }

    }
}
