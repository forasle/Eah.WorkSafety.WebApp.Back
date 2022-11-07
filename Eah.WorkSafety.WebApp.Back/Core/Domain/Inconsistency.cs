namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class Inconsistency
    {
        public int Id { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Information { get; set; }

        public User? Identifier { get; set; }

        public int IdentifierUserId { get; set; }


        public DateTime? Date { get; set; }

        public bool RootCauseAnalysisRequirement { get; set; }

        public string? Department { get; set; }

        public bool Status { get; set; }

        public int RiskScore { get; set; }

        public Inconsistency()
        {
        }
    }
}
