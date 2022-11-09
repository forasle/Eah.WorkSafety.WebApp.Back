using Eah.WorkSafety.WebApp.Back.Core.Domain;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Dto
{
    public class RiskAssessmentDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Information { get; set; }

        public string? ReferenceNumber { get; set; }

        public int IdentifierUserId { get; set; }

        public DateTime? RevisionDate { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? CreationTime { get; set; }

        public string? Method { get; set; }
    }
}
