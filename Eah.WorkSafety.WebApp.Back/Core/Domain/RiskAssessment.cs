namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class RiskAssessment
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Information { get; set; }

        public string? ReferenceNumber { get; set; }

        public int CreatorUserId { get; set; }

        public DateTime? RevisionDate { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? CreationTime { get; set; }

        public string? Method { get; set; }
        public User? User { get; set; }
        public RiskAssessment()
        {
        }
    }
}
