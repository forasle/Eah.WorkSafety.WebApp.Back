namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class NearMissDto
    {
        public int Id { get; set; }

        public int NearMissNumber { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? NearMissInfo { get; set; }

        public DateTime? Date { get; set; }

        public bool RootCauseAnalysis { get; set; }

        public int LostDays { get; set; }

        public int CreatorUserId { get; set; }

        public List<int>? Employees { get; set; }

    }
}
