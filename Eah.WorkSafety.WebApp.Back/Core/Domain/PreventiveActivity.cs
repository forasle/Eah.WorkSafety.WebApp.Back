namespace Eah.WorkSafety.WebApp.Back.Core.Domain
{
    public class PreventiveActivity
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Information { get; set; }

        public string? ReferenceNumber { get; set; }

        public int CreatorUserId { get; set; }

        public bool Status { get; set; }

        public bool RootCauseAnalysis { get; set; }

        public DateTime? Deadline { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? CreationTime { get; set; }

        public string? Method { get; set; }
        public User? User { get; set; }

        public PreventiveActivity()
        {

        }
    }
}
