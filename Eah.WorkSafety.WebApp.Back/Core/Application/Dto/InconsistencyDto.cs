using Eah.WorkSafety.WebApp.Back.Core.Domain;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class InconsistencyDto
    {
        public int Id { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? Information { get; set; }

        public int IdentifierUserId { get; set; }


        public DateTime? Date { get; set; }

        public bool RootCauseAnalysisRequirement { get; set; }

        public string? Department { get; set; }

        public bool Status { get; set; }

        public int RiskScore { get; set; }
    }
}
