namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class Inconsistency
    {
        public int Id { get; set; }

        public string? SceneOfInconsistency { get; set; }

        public string? Information { get; set; }

        public DateTime InconsistencyDate { get; set; }

        public DateTime CreationDate { get; set; }

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
