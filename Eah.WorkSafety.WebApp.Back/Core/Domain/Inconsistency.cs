namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class Inconsistency
    {
        public int Id { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Information { get; set; }

        public DateTime? Date { get; set; }

        public bool RootCauseAnalysisRequirement { get; set; }

        public string? Department { get; set; }

        public bool Status { get; set; }

        public int RiskScore { get; set; }

        public int CreatorUserId { get; set; }

        public User? User { get; set; }

        public Inconsistency()
        {
        }
    }
}
